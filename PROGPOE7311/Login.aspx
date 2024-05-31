<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Blank.Master" CodeBehind="Login.aspx.cs" Inherits="PROGPOE7311.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>


    <div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <br />
                </td>
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
            </tr>
            <tr>
                <td style="width: 10%">&nbsp;</td>
                <td style="text-align: right; width: 30%">
                    <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label></td>
                <td style="width: 20%">
                    <asp:TextBox ID="tbUsername" runat="server" Style="width: 100%"></asp:TextBox>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="text-align: right; width: 30%">
                    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbPassword" TextMode="Password" runat="server" Style="width: 100%"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td style="text-align: center">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
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
