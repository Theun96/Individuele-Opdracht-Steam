<%@ Page Title="" Language="C#" MasterPageFile="~/Steam.Master" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="Steam_Powered.Content_Pages.UserPage" %>

<asp:Content ID="UserContentPH" ContentPlaceHolderID="DefaultContentPlaceHolder" runat="server">
    
    <div>
        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="lblWishlistGames" runat="server" Text="Wishlist"></asp:Label>
            </div>

            <div class="col-md-4">
                <asp:Label ID="lblWishGameNaam" runat="server" Text="Game Naam:"></asp:Label>
            </div>
            
            <div class="col-md-4">
                <asp:Label ID="lblGamePrijs" runat="server" Text="Prijs:"></asp:Label>
            </div>
        </div>
        
        <div>
            <asp:Table ID="WishTable" runat="server"></asp:Table>
        </div>

    </div>

    <div>
        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="lblGekochteGames" runat="server" Text="Gekochte Games"></asp:Label>
            </div>

            <div class="col-md-4">
                <asp:Label ID="lblGameNameTable" runat="server" Text="Game Naam:"></asp:Label>
            </div>

            <div class="col-md-4">
                <asp:Label ID="lblUrenGespeeld" runat="server" Text="Uren Gespeeld:"></asp:Label>
            </div>
        </div>

        <div>
            <asp:Table ID="GekochtTable" runat="server"></asp:Table>
        </div>
    </div>


</asp:Content>
