<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Blank.Master" CodeBehind="AddFarmer.aspx.cs" Inherits="PROGPOE7311.AddFarmer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 5%">
                    <br />
                </td>
                <td style="width: 10%; text-align:right">
                    <asp:Label ID="lblName" runat="server" Text="Full Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbName" runat="server"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
                <td style="width: 10%; text-align:right">
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
                <td style="width: 10%; text-align:right">
                    <asp:Label ID="lblCell" runat="server" Text="Cellphone Number:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbCell" runat="server" TextMode="Phone"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
                <td >
                    
                </td>
                <td style="width: 20%;>
                    <asp:Button ID="btnAddFarmer" runat="server" Text="Add Farmer" OnClick="btnAddFarmer_Click" />
                </td>

            </tr>
        </table>
    </div>
</asp:Content>

