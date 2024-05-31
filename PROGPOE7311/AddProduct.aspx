<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Blank.Master" CodeBehind="AddProduct.aspx.cs" Inherits="PROGPOE7311.AddProduct" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <br />
                        <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [ProdCategory] FROM Product" ID="ctl00"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td style="width: 35%; text-align: right">
                        <asp:Label ID="lblProdName" runat="server" Text="Product Name:"></asp:Label></td>
                    <td style="text-align: center">
                        <asp:TextBox ID="tbProdName" runat="server" Width="250"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%; text-align: right">
                        <asp:Label ID="lblProdCat" runat="server" Text="Select Category:"></asp:Label></td>
                    <td style="width: 15%; text-align: center">
                        <asp:DropDownList ID="ddlCategory" runat="server" Width="255px" DataTextField="ProdCategory" DataValueField="ProdCategory" DataSourceID="ctl00"></asp:DropDownList></td>
                    <td></td>
                    <td style="width: 25%"></td>

                    <td></td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 20%; text-align: right">
                        <asp:Label ID="lblProdDate" runat="server" Text="Production Date:"></asp:Label></td>
                    <td style="text-align: center">
                        <asp:TextBox ID="tbProdDate" runat="server" TextMode="Date" Width="250"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td style="text-align: center">
                        <asp:Button ID="btnAddProd" runat="server" Text="Add Product" OnClick="btnAddProd_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>


