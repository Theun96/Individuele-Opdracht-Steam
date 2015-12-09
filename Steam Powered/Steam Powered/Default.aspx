<%@ Page Title="" Language="C#" MasterPageFile="~/Steam.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Steam_Powered.Default" %>

<asp:Content ID="AnonymousLogin" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="navbar navbar-default">
        <div class="container">
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a runat="server" href="/">Uitgelicht</a></li>
                    <li><a runat="server" href="/">Games</a></li>
                    <li><a runat="server" href="/">Software</a></li>
                    <li><a runat="server" href="/">Hardware</a></li>
                    <li><a runat="server" href="/">Videos</a></li>
                    <li><a runat="server" href="/">Nieuws</a></li>
                </ul>

                <ul class="nav navbar-nav navbar-right navbar-form">
                    <li class="form-group">
                        <input type="text" class="form-control" placeholder="Search" />
                    </li>
                    <li>
                        <button type="submit" class="btn btn-default">Submit</button></li>
                </ul>
            </div>
            <!--/.navbar-collapse -->
        </div>
    </div>

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
                    <div class="item active">
                        <img src="/pictures/1.jpg" alt="picture 1" />
                    </div>

                    <div class="item">
                        <img src="/pictures/2.jpg" alt="picture 1" />
                    </div>

                    <div class="item">
                        <img src="/pictures/3.jpg" alt="picture 1" />
                    </div>

                    <div class="item">
                        <img src="/pictures/4.jpg" alt="picture 1" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
