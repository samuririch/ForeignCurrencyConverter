<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConversionForm.aspx.cs" Inherits="Agilious_CurrencyConveter.CurrencyConversionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 650px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:auto; width: 50%; left:0; right:0; top:0; bottom:0; position:fixed; max-height:100%; max-width:100%; overflow:auto; border: 3px solid green; padding: 10px; text-align: center; display: block;">
            <div style="position:fixed; top:50%; left:50%; transform: translate(-50%, -50%)">
            <asp:Label ID="lblHeader" runat="server" Text="Currency Converter" Font-Bold="True"></asp:Label>
            <br />
            Convert
            <asp:TextBox ID="txtCurrencyInput" runat="server"></asp:TextBox>
        <asp:DropDownList ID="baseCountryList" runat="server">
            <asp:ListItem Text="Select a Country" Value="" />
            <asp:ListItem Text="USD - US Dollar" Value="USD" />
            <asp:ListItem Text="GBP - British Pound" Value="GBP" />
            <asp:ListItem Text="CAD - Canadian Dollar" Value="CAD" />
            <asp:ListItem Text="CNY - Chinese Yuan" Value="CNY" />
            <asp:ListItem Text="MXN - Mexican Peso" Value="MXN" />
            <asp:ListItem Text="EUR - Euro" Value="EUR" />

        </asp:DropDownList>

            to<asp:DropDownList ID="convertedCountryList" runat="server" style="margin-bottom: 0px">
            <asp:ListItem Text="Select a Country" Value="" />
            <asp:ListItem Text="USD - US Dollar" Value="USD" />
            <asp:ListItem Text="GBP - British Pound" Value="GBP" />
            <asp:ListItem Text="CAD - Canadian Dollar" Value="CAD" />
            <asp:ListItem Text="CNY - Chinese Yuan" Value="CNY" />
            <asp:ListItem Text="MXN - Mexican Peso" Value="MXN" />
            <asp:ListItem Text="EUR - Euro" Value="EUR" />

        </asp:DropDownList>
            &nbsp;<br />
                <asp:Label ID="lblCurrencyOutput" runat="server" Font-Size="XX-Large" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="btnConvert" runat="server" OnClick="btnConvert_Click" Text="Convert!" />
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
            <br />
            <asp:Label ID="lblNotSelected" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblNoInput" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <br />
&nbsp;<br />
            <br />
            <br />
            <br />
            </div>
        </div>
        <br />
        <br />
        <br />

    </form>
</body>
</html>
