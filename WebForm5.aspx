<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Grocery_Store.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style=" color:white" >
        <center style="padding:5px">
            <h1 >Customer Details</h1></center>
        <center>
    <asp:Table ID="Table1" runat="server" Font-Size="Large">
        <asp:TableRow>
            <asp:TableCell>Name</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Mobile No.</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
            </center>
        <center style="padding:5px">
            <asp:Button ID="Button1" runat="server" Text="Get Bill" OnClick="Button1_Click" /></center>
        </div>
</asp:Content>
