<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConversionForm.aspx.cs" Inherits="Agilious_CurrencyConveter.CurrencyConversionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblHeader" runat="server" Text="Currency Converter" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtCurrencyInput" runat="server"></asp:TextBox>
            <br />
            Convert
        <asp:DropDownList ID="baseCountryList" runat="server">
            <asp:ListItem Text="Select a Country" Value="" />
            <asp:ListItem Text="USD - US Dollar" Value="USD" />
            <asp:ListItem Text="GBP - British Pound" Value="GBP" />
            <asp:ListItem Text="CAD - Canadian Dollar" Value="CAD" />
            <asp:ListItem Text="CNY - Chinese Yuan" Value="CNY" />
            <asp:ListItem Text="MXN - Mexican Peso" Value="MXN" />
            <asp:ListItem Text="EUR - Euro" Value="EUR" />

        </asp:DropDownList>

        &nbsp;to

        <asp:DropDownList ID="convertedCountryList" runat="server" style="margin-bottom: 0px">
            <asp:ListItem Text="Select a Country" Value="" />
            <asp:ListItem Text="USD - US Dollar" Value="USD" />
            <asp:ListItem Text="GBP - British Pound" Value="GBP" />
            <asp:ListItem Text="CAD - Canadian Dollar" Value="CAD" />
            <asp:ListItem Text="CNY - Chinese Yuan" Value="CNY" />
            <asp:ListItem Text="MXN - Mexican Peso" Value="MXN" />
            <asp:ListItem Text="EUR - Euro" Value="EUR" />

        </asp:DropDownList>
            <br />
            <asp:TextBox ID="txtCurrencyOutput" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Button ID="btnConvert" runat="server" OnClick="btnConvert_Click" Text="Convert!" />
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
            <br />
            <br />
            <br />
            <br />
&nbsp;<br />
            <br />
            <br />
            <br />
        </div>
        <br />
        <br />
        <br />

    </form>
</body>
</html>
