<%@ Page Title="" Language="C#" MasterPageFile="~/Steam.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Steam_Powered.Login" %>
<asp:Content ID="LoginContent" ContentPlaceHolderID="DefaultContentPlaceHolder" runat="server">
    
    <div class="container">
        <div class="col-md-4 col-md-offset-4">
            <h2 class="form-signin-heading">Log in uw account</h2>         
            <asp:TextBox runat="server" id="txtUsername" CssClass="form-control" placeholder="Gebruikersnaam" />
            
            <asp:TextBox runat="server" id="txtPassword" Cssclass="form-control" placeholder="Wachtwoord" TextMode="Password" />
            
            <asp:Label runat="server" id="lblWrong" Text="Uw gebruikersnaam of wachtwoord is niet herkend." Visible="False" Font-Bold="True" ForeColor="Red" />
            <asp:Button cssclass="btn btn-lg btn-primary btn-block" ID="btnLogin" runat="server" Text="Inloggen" OnClick="btnLogin_Click"/>
        </div>
    </div>

</asp:Content>
