<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 342px">
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 197px; top: 15px; position: absolute; height: 380px; width: 612px">
                <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 357px; top: 87px; position: absolute">APPLE</asp:TextBox>
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 280px; top: 26px; position: absolute" Text="Label"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" style="z-index: 1; left: 395px; top: 188px; position: absolute; height: 27px; width: 82px">
                    <asp:ListItem>red</asp:ListItem>
                    <asp:ListItem>blue</asp:ListItem>
                    <asp:ListItem>orange</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button runat="server" BorderColor="Black" BorderStyle="Double" ForeColor="Red" OnClick="Unnamed1_Click" style="z-index: 1; left: 271px; top: 156px; position: absolute" Text="BUTTON" />
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" style="z-index: 1; left: 141px; top: 205px; position: absolute; height: 27px; width: 82px">
                    <asp:ListItem>Bold</asp:ListItem>
                    <asp:ListItem>Italic</asp:ListItem>
                </asp:CheckBoxList>
                <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 127px; top: 87px; position: absolute" OnTextChanged="TextBox1_TextChanged">MANGO</asp:TextBox>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
