<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Grocery_Store.WebForm2" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .bor{
            border:5px solid white;
            font-weight:bold;
        }
    </style>
    <main style="text-align:center;">
       <h1 style="color:white">Store Table</h1>
        <asp:Table ID="tblGrocery" runat="server" CssClass="table-bordered bor" Width="95%" ForeColor="White">
            <asp:TableHeaderRow >
                <asp:TableHeaderCell>S.NO</asp:TableHeaderCell>
                <asp:TableHeaderCell>Item</asp:TableHeaderCell>
                <asp:TableHeaderCell>Quantity in Store</asp:TableHeaderCell>
                <asp:TableHeaderCell>Price per each</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
         <center style="padding:5px"><asp:Button ID="Button1" runat="server" Text="ADD/UPDATE" OnClick="Button1_Click" /></center>
    </main>

</asp:Content>
        

