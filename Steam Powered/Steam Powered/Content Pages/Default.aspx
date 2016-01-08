<%@ Page Title="" Language="C#" MasterPageFile="~/Steam.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Steam_Powered.Default" %>

<asp:Content ID="DefaultStorePage" ContentPlaceHolderID="DefaultContentPlaceHolder" runat="server">
    
    <!-- Content voor de spotlights -->
    <div class=" container row">
        <div class="col-md-8">
            <div id="myCarousel" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                    <li data-target="#myCarousel" data-slide-to="3"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <div class="item active setFullWidth">
                        <a href="/Content Pages/GamePage.aspx"><img src="/pictures/1.jpg" alt="picture 1"/></a>
                    </div>

                    <div class="item">
                        <a href="/Content Pages/GamePage.aspx"><img src="/pictures/2.jpg" alt="picture 2" /></a>
                    </div>

                    <div class="item">
                        <a href="/Content Pages/GamePage.aspx"><img src="/pictures/3.jpg" alt="picture 3" /></a>
                    </div>

                    <div class="item">
                        <a href="/Content Pages/GamePage.aspx"><img src="/pictures/4.jpg" alt="picture 4" /></a>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-md-4">
            <div id="spotlightCarousel" class="carousel slide setFullWidth" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#spotlightCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#spotlightCarousel" data-slide-to="1"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <img src="/pictures/spotlight1.jpg" alt="picture 1" />
                    </div>

                    <div class="item">
                        <img src="/pictures/spotlight2.jpg" alt="picture 2" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    <!-- Content voor de rest van de store -->
    
    <div class="container">
        
    </div>
</asp:Content>
