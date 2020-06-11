using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agilious_CurrencyConveter
{
    public partial class CurrencyConversionForm : System.Web.UI.Page
    {

        public static string dataResults;
        public static double convertedValue;
        public static double GBR_Rate;

        public class CountryRate
        {
            public CountryRate(string json)
            {
                JObject jObject = JObject.Parse(json);
                JToken jRate = jObject["rates"];
                GBP = (double)jRate["GBP"];

            }
            public double GBP { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            getAPIData();
            lblXChangeRateValue.Visible = false;
            lblCanadianCurrencyValue.Visible = false;
            lblCanadaCurrencyText.Visible = false;
            lblXChangeText.Visible = false;
            btnConvert.Enabled = true;
            lblDate.Visible = false;


        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtUSD.Text != "")
            {
                deserialize(dataResults);
                convertCurrency();
                lblXChangeRateValue.Visible = true;
                lblCanadianCurrencyValue.Visible = true;
                lblCanadaCurrencyText.Visible = true;
                lblXChangeText.Visible = true;
                btnConvert.Enabled = false;
                lblDate.Visible = true;
            }
            else
            {
                Label lblError = new Label();
                lblError.Text = "Input cannot be blank";
            }
         }

        public static void getAPIData()
        {
            string apiURL = String.Format("https://api.exchangeratesapi.io/latest?base=USD");
            WebRequest getRequest = WebRequest.Create(apiURL);
            getRequest.Method = "GET";
            HttpWebResponse getResponse = null;
            getResponse = (HttpWebResponse)getRequest.GetResponse();

            using (Stream stream = getResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                apiURL = reader.ReadToEnd();
                reader.Close();
                
            }


            dataResults = apiURL;

            CountryRate cRate = new CountryRate(dataResults);

            GBR_Rate = cRate.GBP;

        }


        private void deserialize(string string_json)
        {
            var JString = JsonConvert.DeserializeObject<dynamic>(string_json);
            convertedValue = JString.rates.CAD;



            

            string dateStamp = JString.date;
            lblXChangeRateValue.Text = convertedValue.ToString();
            lblDate.Text = "Exchange Rate data accurate as of: " + dateStamp;
        }

        private void convertCurrency()
        {
            double currencyValue = Convert.ToDouble(txtUSD.Text);
            double greatBritainCurrency = currencyValue * GBR_Rate;
            double currentExchangeRate = convertedValue;
            double foreignCurrencyValue = currencyValue * currentExchangeRate;
            double roundedValue = Math.Ceiling(foreignCurrencyValue * 100) / 100;
            string roundedFormattedString = String.Format("{0:0.00}", roundedValue);
            lblCanadianCurrencyValue.Text = "$" + roundedFormattedString;
            txtGBRRate.Text = GBR_Rate.ToString();
            txtGBR.Text = greatBritainCurrency.ToString();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}