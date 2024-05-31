<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="PROGPOE7311.ViewProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:SqlDataSource ID="SQLdsPROGDB" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT Product.ProdName, Product.ProdCategory, Product.ProdDate, [User].FullName FROM [Product]
JOIN [User] ON Product.UserID = [User].UserID;"
        DataSourceMode="DataReader"></asp:SqlDataSource>
    <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [ProdCategory] FROM Product" ID="ctl169"></asp:SqlDataSource>
    <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ProdName, ProdCategory, ProdDate, [User].FullName FROM Product JOIN [User] ON [User].UserID = Product.UserID WHERE ProdCategory = @ProdCategory" ID="sqldsCategoryFilter">
        <SelectParameters>
            <asp:Parameter  Name="ProdCategory" Type="String"></asp:Parameter>
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource runat="server"></asp:SqlDataSource>
    <table style="width: 100%">
        <tr>
            <td style="width: 40%; text-align: right">
                <asp:Label ID="Label1" runat="server" Text="Select Category:"></asp:Label>
                &nbsp;<asp:DropDownList ID="ddlCategory" runat="server" DataSourceID="ctl169" DataTextField="ProdCategory" DataValueField="ProdCategory" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                    <asp:ListItem Selected="True"></asp:ListItem>
                </asp:DropDownList></td>
            <td style="width: 10%"><br /></td>
            <td style="width: 40%; text-align: left">
                <asp:Label ID="lblText" runat="server" Text="Between "></asp:Label>&nbsp;<asp:TextBox ID="tbRangeBegin" runat="server" TextMode="Date" OnTextChanged="tbRangeBegin_TextChanged"></asp:TextBox>
                <asp:Label ID="lblText2" runat="server" Text=" and "></asp:Label>&nbsp;<asp:TextBox ID="tbRangeEnd" runat="server" TextMode="Date" OnTextChanged="tbRangeEnd_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><br /></td>
            <td style="text-align: center">
                <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" /></td>        
            <td><br /></td>
        </tr>
                <tr>
    <td><br /></td>
    <td > <br />
       </td>        
    <td><br /></td>
</tr>
         <tr>
     <td><br /></td>
     <td style="text-align: center">
         <asp:Button ID="BtnReset" runat="server" Text="Reset Table" OnClick="btnReset_Click" /></td>        
     <td><br /></td>
 </tr>
    </table>

    <table style="width: 100%;">
        <tr>
            <td>
                
            </td>
            <td>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvProducts" DataSourceID="SQLdsPROGDB" runat="server" AutoGenerateColumns="False" Height="100px" Width="100%"  AllowSorting="true">
                    <Columns>
                        <asp:BoundField DataField="ProdName" HeaderText="Product Name" SortExpression="ProdName"></asp:BoundField>
                        <asp:BoundField DataField="ProdCategory" HeaderText="Product Category" SortExpression="ProdCategory"></asp:BoundField>
                        <asp:BoundField DataField="ProdDate" HeaderText="Production Date" SortExpression="ProdDate" DataFormatString="{0:yyyy-MM-dd}" HtmlEncode="false"></asp:BoundField>
                        <asp:BoundField DataField="FullName" HeaderText="Farmer" SortExpression="FullName"></asp:BoundField>
                    </Columns>
                </asp:GridView>

            </td>
            <td>
                
            </td>

        </tr>
    </table>
</asp:Content>
