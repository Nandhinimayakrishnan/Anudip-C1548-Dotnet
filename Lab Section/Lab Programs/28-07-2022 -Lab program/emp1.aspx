<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emp1.aspx.cs" Inherits="WebApplication19.emp1" %>

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
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 69px; top: 69px; position: absolute; height: 218px; width: 727px">
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 369px; top: 24px; position: absolute" Text="Employee"></asp:Label>
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 242px; top: 85px; position: absolute">
                    <asp:ListItem>nandhini</asp:ListItem>
                    <asp:ListItem>nandhu</asp:ListItem>
                    <asp:ListItem>nandhu1</asp:ListItem>
                    <asp:ListItem>nandhini1</asp:ListItem>
                    <asp:ListItem>nandhu2</asp:ListItem>
                    <asp:ListItem>nandhini2</asp:ListItem>
                    <asp:ListItem>nandy1</asp:ListItem>
                    <asp:ListItem>nandy</asp:ListItem>
                </asp:ListBox>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" style="z-index: 1; left: 344px; top: 176px; position: absolute" Text="CHECK" />
                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" style="z-index: 1; left: 435px; top: 69px; position: absolute; height: 89px;" TextMode="MultiLine"></asp:TextBox>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
