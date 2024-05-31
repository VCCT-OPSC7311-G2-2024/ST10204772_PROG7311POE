<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeHome.aspx.cs" Inherits="PROGPOE7311.EmployeeHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td></td>

    </tr>
    <tr>
        <td style="width: 35%"></td>
        <td>
            <asp:Button ID="btnProductView" runat="server" Text="View All Products" OnClick="btnProductView_Click" /></td>
        <td style="width: 25%"><br />&nbsp;</td>
        <td>
            <asp:Button ID="btnAddFarmer" runat="server" Text="Add Farmer" OnClick="btnAddFarmer_Click" /></td>
        <td style="width: 35%"></td>
    </tr>
</table>
</asp:Content>
