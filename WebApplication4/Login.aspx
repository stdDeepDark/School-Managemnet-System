<%@ Page Title="Login" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       
  
    <div style="margin:auto;display:flex; justify-content:center; align-items:center;height:100px" >
      <h1>Sign in to School Management System
        </h1>
      </div>

        <label for="login_field"style="margin:auto;display:flex; justify-content:center; align-items:center;height:40px">
          Username
        </label>
        <input style="margin:auto;display:flex; justify-content:center; align-items:center;"type="text" name="login" id="login" class="form-control input-block" tabindex="1"   autofocus="autofocus" />

         <label for="password"style="margin:auto;display:flex; justify-content:center; align-items:center;height:40px">
          Password
        </label>
       <input style="margin:auto;display:flex; justify-content:center; align-items:center;"type="password" name="password" id="password" class="form-control form-control input-block" tabindex="2" />
       <div style="height:10px">
           
           </div>
    <div style="margin:auto;display:flex; justify-content:center; align-items:center;height:100px">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign in" BorderColor="#2E6DA4" BackColor="#337AB7" ForeColor="White"  Width="100%" Font-Bold="True" Height="40px" BorderStyle="Double" />
        </div> 
    <div style="margin:auto;display:flex; justify-content:center; align-items:center;height:30px">
     <asp:CheckBox ID="CheckBox1" runat="server" BackColor="White" ForeColor="Black" Text="teacher login" />
       </div>
</asp:Content>
