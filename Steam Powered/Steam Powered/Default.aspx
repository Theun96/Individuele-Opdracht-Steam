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

                <ul class="nav navbar-nav navbar-right">
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
</asp:Content>
