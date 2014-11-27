<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.UI.Login" %>

<asp:Content runat="server" ContentPlaceHolderID="Main">
    <div style="width: 100%;">
        <br />
        <br />
        <br />
        <div style="text-align: center;">SIGN IN</div>
        <br />
        <br />
        <table style="width: 100%;">
            <tr>
                <td style="width: 35%"></td>
                <td style="width: 30%">
                    <table style="vertical-align: central; width: 100%">
                        <tr>
                            <td style="width: 50%">
                                <asp:Label ID="lblEmail" runat="server" Text="Email ID"></asp:Label>
                            </td>
                            <td style="width: 50%">
                                <asp:TextBox ID="txtEmail" TextMode="Email" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td style="width: 50%">
                                <asp:TextBox ID="txtPass" TextMode="Password" runat="server" Width="98%"></asp:TextBox>
                               
                            </td>
                        </tr>

                        <tr>
                            <td colspan="2">
                                <br />
                                </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: center">
                                <asp:Button ID="btnSubmit" Width="200px" runat="server" Text="Enter" OnClick="btnSubmit_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td  colspan="2">
                                <asp:Label ID="lblErr" runat="server" Visible="false" Text="user name or password incorrect" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="width: 35%"></td>
            </tr>
        </table>

    </div>
</asp:Content>
