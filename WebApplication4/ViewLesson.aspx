﻿<%@ Page Title="Select Course" Language="C#" MasterPageFile="~/Site_student.Master" AutoEventWireup="true" CodeBehind="ViewLesson.aspx.cs" Inherits="WebApplication4.ViewLesson" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <div style =" height:10px"> 
        </div>       
        <div style =" display:flex; justify-content:center; align-items:center; " >

          
        <h3>Courses List
        </h3>
            </div>        
    <div  style =" display:flex; justify-content:center; align-items:center; " >
            <asp:GridView  ID="GridView1" runat="server" Width="600px"  CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField SelectText="Select Course" ShowSelectButton="True" ButtonType="Button"  />
                </Columns>
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
