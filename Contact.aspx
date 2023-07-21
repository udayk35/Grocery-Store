<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Grocery_Store.Contact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        *{
            color:aliceblue;
        }
        .container1 {
            display: flex;
            margin: 20px auto;
            justify-content:space-around;
            margin-bottom:1rem;
        }
        .image1 {
            flex: 0 0 40%;
      max-width: 40%;
      margin-right: 0; 
      padding-right: 0; 
        }
        .description1 {
            flex: 1;
      margin-left: 0; 
      padding-left: 0;
        }
    </style>
    <main>
        <div class="container1">
            <div class="image1">
                <img alt="" src="Images/uday.jpg" class="img-thumbnail" width="300">
            </div>
            <div class="description1">
                <p>
                    <ul>
                        <li>
                            <h1>Yadagiri Uday Kiran</h1>
                        </li>
                        <li>
                            <h3>Frontend and Backend Development</h3>
                        </li>
                        <li>
                            <h4>Gokaraju Rangaraju institute of engineering and technology</h4>
                        </li>
                        <li>
                            <h4>Ph.no: 95814 94976</h4>
                        </li>
                        <li>
                            <h4>Email: uday62874@gmail.com</h4>
                        </li>
                    </ul>
                </p>
            </div>
        </div>
        <div class="container1">
            <div class="description1">
                <p>
                    <ul>
                        <li>
                            <h1>Varshith Reddy Singidi</h1>
                        </li>
                        <li>
                            <h3>Customer Database Management</h3>
                        </li>
                        <li>
                            <h4>Gokaraju Rangaraju institute of engineering and technology</h4>
                        </li>
                        <li>
                            <h4>Ph.no: +91 86885 60875 </h4>
                        </li>
                        <li>
                            <h4>Email: svarshithreddy@gmail.com</h4>
                        </li>
                    </ul>
                </p>
            </div>
            <div class="image1">
                <img alt="" src="Images/varshith.jpg" class="img-thumbnail" width="300">
            </div>
        </div>
        <div class="container1">
            <div class="image1">
                <img alt="" src="Images/shashi1.jpg" class="img-thumbnail" width="300">
            </div>
            <div class="description1">
                <p>
                    <ul>
                        <li>
                            <h1>ShashiVardhan Dantla</h1>
                        </li>
                        <li>
                            <h3>Frontend Development</h3>
                        </li>
                        <li>
                            <h4>Gokaraju Rangaraju institute of engineering and technology</h4>
                        </li>
                        <li>
                            <h4>Ph.no: +91 93474 40944</h4>
                        </li>
                        <li>
                            <h4>Email: shashivardhan313@gmail.com</h4>
                        </li>
                    </ul>
                </p>
            </div>
        </div>
        <div class="container1">
            <div class="description1">
                <p>
                    <ul>
                        <li>
                            <h1>Harshitha Vemana</h1>
                        </li>
                        <li>
                            <h3>Store Database Management</h3>
                        </li>
                        <li>
                            <h4>Gokaraju Rangaraju institute of engineering and technology</h4>
                        </li>
                        <li>
                            <h4>Ph.no: +91 70930 22222 </h4>
                        </li>
                        <li>
                            <h4>Email: harshitavemana@gmail.com</h4>
                        </li>
                    </ul>
                </p>
            </div>
            <div class="image1">
                <img alt="" src="Images/Harshitha1.jpg" class="img-thumbnail" width="300">
            </div>
        </div>
    </main>
</asp:Content>
