<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FarmerHome.aspx.cs" Inherits="PROGPOE7311.FarmerHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!DOCTYPE html>


     <div>
         <table>
             <tr>
                 <td>
                     <br />
                 </td>
                 <td></td>
                 <td></td>
             </tr>

             <tr>

                 <td style="text-align:right; width: 40%"><asp:Button ID="btnView" runat="server" Text="View Products" OnClick="btnView_Click" /></td>
                 <td style="width: 20%"></td>
                 <td style="text-align:left;  width: 40%"> <asp:Button ID="btnAdd" runat="server" Text="Add New Product" OnClick="btnAdd_Click" /></td>
             </tr>
             <tr>
                 <td>
                     <br />
                 </td>
             </tr>
         </table>
         
         
        

     </div>
</asp:Content>
