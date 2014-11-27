<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebApplication2.UI.Signup" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="Main">
    <div style="width: 100%;">
        <br />
        <br />
        <br />
        <div style="text-align: center;">SIGN UP DETAILS</div>
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td style="width: 35%"></td>
                <td style="width: 30%">
                    <table style="vertical-align: central;width:100%">
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtFname" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblMname" runat="server" Text="Middle Name"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtMname" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblLname" runat="server" Text="Last Name"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtLname" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblAddr2" runat="server" Text="Address"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtAddr2" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtCity" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtState" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblZip" runat="server" Text="Zip Code"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtZip" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtPhone" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtEmail" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="LblPass" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" Width="98%" Height="22px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:50%">
                                <asp:Label ID="lblConfPass" runat="server" Text="Confirm Password"></asp:Label>
                            </td>
                            <td style="width:50%">
                                <asp:TextBox ID="txtConfPass" TextMode="Password" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr><td colspan="2">
                            <asp:Label ID="lblErr" runat="server" Vivble="false" Text="" ForeColor="Red"></asp:Label></td></tr>
                        <tr>
                            <td colspan="2" style="text-align:center">
                                <asp:Button id="btnCreate" Width="200px" runat="server" Text="Submit" OnClick="btnCreate_Click"/>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="width: 35%"></td>
            </tr>
        </table>

    </div>
</asp:Content>
