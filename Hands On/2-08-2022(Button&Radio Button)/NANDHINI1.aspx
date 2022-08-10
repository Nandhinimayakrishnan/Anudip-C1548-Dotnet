<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NANDHINI1.aspx.cs" Inherits="WebApplication20.NANDHINI1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 73px; top: 44px; position: absolute; height: 269px; width: 619px">
                <asp:RadioButton ID="RadioButton1" runat="server" style="z-index: 1; left: 216px; top: 80px; position: absolute" AutoPostBack="True" Font-Bold="True" Font-Italic="True" ForeColor="#3399FF" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Vijay" />
                <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" Font-Bold="True" Font-Italic="True" ForeColor="#9966FF" OnCheckedChanged="RadioButton2_CheckedChanged" style="z-index: 1; left: 214px; top: 119px; position: absolute" Text="Siva Karthickeyan" />
                <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" Font-Bold="True" Font-Italic="True" ForeColor="Red" OnCheckedChanged="RadioButton3_CheckedChanged" style="z-index: 1; left: 216px; top: 157px; position: absolute" Text="Ajith" />
            </asp:Panel>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="Black" Font-Bold="True" ForeColor="#CC0000" OnClick="Button1_Click" style="z-index: 1; left: 304px; top: 268px; position: absolute" Text="CHECK" />
            <asp:Label ID="Label1" runat="server" BorderColor="Red" Font-Bold="True" Font-Italic="True" Font-Strikeout="False" Font-Underline="True" style="z-index: 1; left: 297px; top: 68px; position: absolute" Text="Favourite Actor"></asp:Label>
        </div>
    </form>
</body>
</html>
