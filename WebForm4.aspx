<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Grocery_Store.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .bor{
            border:5px solid white;
            font-weight:bold;
        }
    </style>
    <main style="text-align:center;">
        <asp:Table ID="Table1" runat="server" CssClass="table-bordered bor" Width="98%" ForeColor="White">
            <asp:TableHeaderRow >
                <asp:TableHeaderCell>Mobile No</asp:TableHeaderCell>
                <asp:TableHeaderCell>Date and Time</asp:TableHeaderCell>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Amount</asp:TableHeaderCell>
                <asp:TableHeaderCell>Items</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </main>
</asp:Content>
