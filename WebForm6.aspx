<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Grocery_Store.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        *{
            text-align:center;
        }
        .bor{
            border:5px solid white;
            font-weight:bold;
        }
    </style>
    <center>
     <h1 style="color:white" >Grocery Table</h1>           
        <asp:Table ID="tblGrocery" runat="server" cssClass="table-bordered bor" width="95%"  ForeColor="White" Height="100%">
            <asp:TableHeaderRow >
                <asp:TableHeaderCell>S.NO</asp:TableHeaderCell>
                <asp:TableHeaderCell>Item</asp:TableHeaderCell>
                <asp:TableHeaderCell>In Cart</asp:TableHeaderCell>
                <asp:TableHeaderCell>Quantity </asp:TableHeaderCell>
                <asp:TableHeaderCell>Price per each</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click1" Height="40" Width="60" CssClass="btn btn-dark"/>
        </center>
</asp:Content>
