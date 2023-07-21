<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Grocery_Store.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main style="text-align:center;">
        <div style="text-align:center;"><h1>Here is Your Bill!!</h1></div>
        <asp:Table ID="Table1" runat="server" CssClass="table-bordered" Width="98%">
            <asp:TableHeaderRow >
                <asp:TableHeaderCell>S.NO</asp:TableHeaderCell>
                <asp:TableHeaderCell>Item</asp:TableHeaderCell>
                <asp:TableHeaderCell>Quantity </asp:TableHeaderCell>
                <asp:TableHeaderCell>Price per each</asp:TableHeaderCell>
                <asp:TableHeaderCell>Total</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <div style="text-align:center;"><h1>******** Thank you ********</h1></div>
    </main>
</asp:Content>

