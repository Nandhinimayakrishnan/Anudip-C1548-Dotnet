<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication22.WebForm1" %>

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
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=CakeShopEntities" DefaultContainerName="CakeShopEntities" EnableFlattening="False" EntitySetName="Cakes">
            </asp:EntityDataSource>
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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductName,Flavours,Quantity,Price" DataSourceID="EntityDataSource1" style="z-index: 1; left: 326px; top: 156px; position: absolute; height: 133px; width: 187px">
                <Columns>
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" ReadOnly="True" SortExpression="ProductName" />
                    <asp:BoundField DataField="Flavours" HeaderText="Flavours" ReadOnly="True" SortExpression="Flavours" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="True" SortExpression="Quantity" />
                    <asp:BoundField DataField="Price" HeaderText="Price" ReadOnly="True" SortExpression="Price" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
