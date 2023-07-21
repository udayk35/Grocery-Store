<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Grocery_Store._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main style="text-align:center;">
       <h1>Grocery Table</h1>
        <asp:Table ID="tblGrocery" runat="server" cssClass="table-bordered" Width="95%">
            <asp:TableHeaderRow >
                <asp:TableHeaderCell>S.NO</asp:TableHeaderCell>
                <asp:TableHeaderCell>Item</asp:TableHeaderCell>
                <asp:TableHeaderCell>In Cart</asp:TableHeaderCell>
                <asp:TableHeaderCell>Quantity </asp:TableHeaderCell>
                <asp:TableHeaderCell>Price per each</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Get Bill" OnClick="Button1_Click1" />
    </main>

</asp:Content>
