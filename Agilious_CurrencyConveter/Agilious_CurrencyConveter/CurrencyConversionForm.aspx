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
            Please enter the USD(U.S Dollar) Amount:<br />
            <asp:TextBox ID="txtUSD" runat="server"></asp:TextBox>
            <asp:Button ID="btnConvert" runat="server" OnClick="btnConvert_Click" Text="Convert USD to CAD" />
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
            <br />
            <br />
            <asp:Label ID="lblXChangeText" runat="server" Text="The current Canadian exchange rate is:"></asp:Label>
            <br />
            <asp:Label ID="lblXChangeRateValue" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCanadaCurrencyText" runat="server" Text="Your total Canadaian currency is:"></asp:Label>
&nbsp;<br />
            <asp:Label ID="lblCanadianCurrencyValue" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="txtGBRRate" runat="server"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtGBR" runat="server"></asp:TextBox>
        <br />
    </form>
</body>
</html>
