<%@ Page Title="Login" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div style ="display:flex; height : 300px; justify-content:center; align-items:center; " >
        
 
                <asp:Login ID="Login1" runat="server" style="margin:auto;" PasswordLabelText="Password:" UserNameLabelText="Username:" LoginButtonText="Sign in" RememberMeText="Remember Me" FailureText="Login failure. Please retry." PasswordRequiredErrorMessage="Password Required" TitleText="Sign in"></asp:Login>

        </div>
</asp:Content>
