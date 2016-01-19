<%@ Page Title="" Language="C#" MasterPageFile="~/Steam.Master" AutoEventWireup="true" CodeBehind="GamePage.aspx.cs" Inherits="Steam_Powered.Content_Pages.GamePage" %>

<asp:Content ID="GamePage" ContentPlaceHolderID="DefaultContentPlaceHolder" runat="server">

    <div class="marginBottem">
        
        <div class="GameNaamTitle">
            <asp:Label ID="lblGameNaam" runat="server" Text=""></asp:Label>
        </div>

        <div class=" row">
            <div class="col-md-7">
                <div class="setFullWidth">
                    <asp:Image ID="imgGameImage" runat="server" />
                </div>
            </div>

            <div class="col-md-5">
                <div class="marginBottem">
                    <asp:Image ID="imgGameHeader" runat="server" />
                    <asp:Label ID="lblGameInfo" runat="server" Text=""></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblReleaseDate" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>

    <div>
        <div class="row">
            <div class="col-md-3">
                
                <div>
                    
                    <asp:Button ID="btnAddWishlist" CssClass="btn btn-default" runat="server" Text="Toevoegen Verlanglijst" OnClick="btnAddWishlist_Click" />
                </div>
                <div>
                    <asp:Label ID="lblWishInfo" runat="server" Text=""></asp:Label>
                </div>

            </div>

            <div class="col-md-3">
            </div>
            
            <div class="col-md-3">
                
            </div>

            <div class="col-md-3">
                
                <div>
                    <asp:Label ID="lblPrijs" CssClass="btn btn-default setHalfWidht" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btnBuyGame" CssClass="btn btn-default setHalfWidht" runat="server" Text="Kopen" OnClick="BuyGame_Click" />
                </div>
                <div>
                    <asp:Label ID="lblBuyInfo" runat="server" Text=""></asp:Label>
                </div>
                
            </div>
        </div>
    </div>



</asp:Content>
