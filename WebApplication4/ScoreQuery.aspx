﻿<%@ Page Title="Score Query" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site_student.Master" CodeBehind="ScoreQuery.aspx.cs" Inherits="WebApplication4.ScoreQuery" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style =" height:10px"> 
        </div>       
        <div style =" display:flex; justify-content:center; align-items:center; " >

          
        <h3>Score Table
        </h3>
            </div>
    <div  style =" display:flex; justify-content:center; align-items:center; " >

            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  Width="800px">
                <AlternatingRowStyle BackColor="White"/>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
           </div>
   </asp:Content>
