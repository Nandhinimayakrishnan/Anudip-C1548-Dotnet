<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication21.WebForm1" %>

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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductName,Quantity,Size,Price" DataSourceID="EntityDataSource1" style="z-index: 1; left: 312px; top: 109px; position: absolute; height: 133px; width: 187px">
                <Columns>
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" ReadOnly="True" SortExpression="ProductName" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="True" SortExpression="Quantity" />
                    <asp:BoundField DataField="Size" HeaderText="Size" ReadOnly="True" SortExpression="Size" />
                    <asp:BoundField DataField="Price" HeaderText="Price" ReadOnly="True" SortExpression="Price" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=DressShopEntities" DefaultContainerName="DressShopEntities" EnableFlattening="False" EntitySetName="Dresses">
            </asp:EntityDataSource>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
