<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Grocery_Store.WebForm3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main style="text-align:center;">
       <asp:Table ID="tblGrocery" runat="server" Width="95%">
            <asp:TableHeaderRow >
                <asp:TableHeaderCell>S.NO</asp:TableHeaderCell>
                <asp:TableHeaderCell>Item</asp:TableHeaderCell>
                <asp:TableHeaderCell>ADD Quantity</asp:TableHeaderCell>
                <asp:TableHeaderCell>ADD Prize</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow><asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <center>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
            </center>
    </main>

</asp:Content>
        
