<%@ Page Language="C#" MasterPageFile="~/Master.Master"  AutoEventWireup="true" CodeBehind="Tracker.aspx.cs" Inherits="WebApplication2.UI.Tracker" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="Main">
    
    <div>
        <asp:Label ID="lblOrderid" runat="server" Text="OrderId"></asp:Label>
        <asp:TextBox ID="txtOrderid" runat="server" TextMode="Number"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClientClick="javaScript:GetStatus();" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblStatus" runat="server" Visible="true" Text=""></asp:Label>

    </div>
</asp:Content>
