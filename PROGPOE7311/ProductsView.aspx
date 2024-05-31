<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductsView.aspx.cs" Inherits="PROGPOE7311.ProductsView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:SqlDataSource ID="SQLdsPROGDB" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT Product.ProdName AS [Product Name], Product.ProdCategory AS [Product Category], Product.ProdDate AS [Production Date] 
                   FROM Product 
                   WHERE UserID = @UserID"
            DataSourceMode="DataReader">
    <SelectParameters>
        <asp:Parameter Name="UserID" Type="Int32" />
    </SelectParameters>
        </asp:SqlDataSource>

    
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:GridView ID="gvProducts" runat="server" DataSourceID="SQLdsPROGDB" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Product Name" HeaderText="Product Name" SortExpression="Product Name"></asp:BoundField>
                        <asp:BoundField DataField="Product Category" HeaderText="Product Category" SortExpression="Product Category"></asp:BoundField>
                        <asp:BoundField DataField="Production Date" HeaderText="Production Date" SortExpression="Production Date"></asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:DetailsView ID="dvProducts" runat="server" Height="50px" Width="125px" DataSourceID="SQLdsPROGDB" AutoGenerateRows="False">
                    <Fields>
                        <asp:BoundField DataField="Product Name" HeaderText="Product Name" SortExpression="Product Name"></asp:BoundField>
                        <asp:BoundField DataField="Product Category" HeaderText="Product Category" SortExpression="Product Category"></asp:BoundField>
                        <asp:BoundField DataField="Production Date" HeaderText="Production Date" SortExpression="Production Date"></asp:BoundField>
                    </Fields>
                </asp:DetailsView>
            </td>
        </tr>
    </table>
</asp:Content>
