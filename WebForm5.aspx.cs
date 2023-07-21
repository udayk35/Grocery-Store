using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Grocery_Store
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public static customer c = new customer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            c.mobile=TextBox2.Text;
            c.date=DateTime.Now;
            c.name=TextBox1.Text;
            List<string> list = new List<string>();
            for(int i=0;i<Items.Count;i++)
            {
                 list.Add(WebForm6.items[i].name);
            }
            c.Items=list;
            Response.Redirect("WebForm1.aspx");
        }
    }
    public class customer
    {
        public string mobile;
        public DateTime date;
        public string time;
        public string name;
        public List<string> Items;
        public int amount;
    }
}