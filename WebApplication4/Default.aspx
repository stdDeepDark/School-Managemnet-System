<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
         <div  class="col-md-2">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/logo.gif" Height="100px" />
          </div>
        <h1>School Management System
        </h1>
        <p class="lead">This is a web application for school management system in BUAA.</p>
                <div  class="col-md-5">
                    </div>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p> 
         </div>
  
    </div>
 

    <div class="row">
        <div class="col-md-4">
            <h2>Official Website</h2>
            <p>
                Beihang University is designated as an aminent key university by China's Ministry of Education Class A . It was one of China's key universities subsidized by "Project 985" funding and by " Project 211" funding. Beihang was founded on October 25, 1952, with an area of over 100 hectares.</p>
            <p>
                <a class="btn btn-default" href="https://www.buaa.edu.cn">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
