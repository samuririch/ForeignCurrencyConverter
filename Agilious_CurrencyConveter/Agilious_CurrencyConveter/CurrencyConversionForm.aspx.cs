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
        public static double USD_Rate; //US
        public static double GBR_Rate; //Great Britain
        public static double CNY_Rate; //China
        public static double MXN_Rate; //Mexico
        public static double EUR_Rate; //Euros
        public static double CAD_Rate; //Canada
        public static string baseCountry;
        public static double conversionRate;
        

        public class CountryRate
        {
            public CountryRate(string json)
            {
                JObject jObject = JObject.Parse(json);
                JToken jRate = jObject["rates"];
                USD = (double)jRate["USD"];
                GBP = (double)jRate["GBP"];
                CNY = (double)jRate["CNY"];
                MXN = (double)jRate["MXN"];
                EUR = (double)jRate["EUR"];
                CAD = (double)jRate["CAD"];

            }
            public double USD { get; set; }
            public double GBP { get; set; }
            public double CNY { get; set; }
            public double MXN { get; set; }
            public double EUR { get; set; }
            public double CAD { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
          if(txtCurrencyInput.Text != "")
            {
                lblNoInput.Visible = false;
                if (baseCountryList.SelectedItem.Value != "" && convertedCountryList.SelectedItem.Value != "")
                {
                    lblNotSelected.Visible = false;
                    getAPIData();
                    convertCurrency();
                }
                else
                {
                    lblNotSelected.Visible = true;
                    lblNotSelected.Text = "Please make both conversion selections!";
                    lblNotSelected.ForeColor = System.Drawing.Color.Red;
                }
            }
          else
            {
                lblNoInput.Visible = true;
                lblNoInput.Text = "Please provide currency input for conversion";
                lblNoInput.ForeColor = System.Drawing.Color.Red;
            }



         }

        protected void getAPIData()
        {
            baseCountry = baseCountryList.SelectedItem.Value;
            string selectedCountry = baseCountry;
            string apiURL = String.Format("https://api.exchangeratesapi.io/latest?base=" + selectedCountry);
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

            USD_Rate = cRate.USD;
            GBR_Rate = cRate.GBP;
            CNY_Rate = cRate.CNY;
            MXN_Rate = cRate.MXN;
            EUR_Rate = cRate.EUR;
            CAD_Rate = cRate.CAD;


        }


        public void convertCurrency()
        {
            double currencyValue = Convert.ToDouble(txtCurrencyInput.Text);
            //double conversionRate;
            double foreignCurrencyValue;
            double roundedValue;
            if (convertedCountryList.SelectedItem.Value == "GBR")
            {
                conversionRate = GBR_Rate;
            }
            else if (convertedCountryList.SelectedItem.Value == "USD")
            {
                conversionRate = USD_Rate;
            }
            else if (convertedCountryList.SelectedItem.Value == "CNY")
            {
                conversionRate = CNY_Rate;
            }
            else if (convertedCountryList.SelectedItem.Value == "MXN")
            {
                conversionRate = MXN_Rate;
            }
            else if (convertedCountryList.SelectedItem.Value == "EUR")
            {
                conversionRate = EUR_Rate;
            }
            else if(convertedCountryList.SelectedItem.Value == "CAD")
            {
                conversionRate = CAD_Rate;
            }


            foreignCurrencyValue = currencyValue * conversionRate;
            roundedValue = Math.Round(foreignCurrencyValue * 100) / 100;
            string roundedFormattedString = String.Format("{0:0.00}", roundedValue);
            lblCurrencyOutput.Visible = true;
            lblCurrencyOutput.Text = roundedFormattedString;

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}