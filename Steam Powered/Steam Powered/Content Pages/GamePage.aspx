<%@ Page Title="" Language="C#" MasterPageFile="~/Steam.Master" AutoEventWireup="true" CodeBehind="GamePage.aspx.cs" Inherits="Steam_Powered.Content_Pages.GamePage" %>

<asp:Content ID="GamePage" ContentPlaceHolderID="DefaultContentPlaceHolder" runat="server">

    <div>
        <div class=" row">
            <div class="col-md-8">
                <div class="setFullWidth">
                    <asp:Image ID="imgGameImage" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <asp:Label ID="lblGameInfo" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>

    <div>
        <div class="row">
            <div class="col-md-4">
                <asp:Button ID="btnAddWishlist" CssClass="form-control" runat="server" Text="Toevoegen Verlanglijst" OnClick="btnAddWishlist_Click" />
                <asp:Label ID="lblWishInfo" runat="server" Text=""></asp:Label>
            </div>

            <div class="col-md-4">
            </div>

            <div class="col-md-4">
                <asp:Button ID="btnBuyGame" CssClass="form-control" runat="server" Text="Kopen" OnClick="BuyGame_Click" />
                <asp:Label ID="lblBuyInfo" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>



</asp:Content>
