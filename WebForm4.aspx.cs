using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grocery_Store
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        List<customer1> items = new List<customer1>();
        protected void Page_Load(object sender, EventArgs e)
        {
            items.Clear();
            CreateDynamicRows(e);
        }
        public void CreateDynamicRows(EventArgs e)
        {
            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\C# project\\DataBases\\Database1.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from customer";
            cmd.Connection = conn;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select * from Items ";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customer1 item = new customer1();
                item.mobile = ""+reader[0];
                item.date = DateTime.Parse(""+reader[1]);
                item.name = "" + reader[2];
                item.ite =""+ reader[3];
                item.amount = int.Parse("" + reader[3]);
                items.Add(item);
            }
            reader.Close();
            for (int i = 0; i < items.Count; i++)
            {
                TableRow row = new TableRow();
                TableCell[] cell = new TableCell[5];
                for (int j = 0; j < 5; j++)
                {
                    cell[j] = new TableCell();
                }
                cell[0].Text = "" + items[i].mobile;
                cell[1].Text = ""+items[i].date;
                cell[2].Text = "" + items[i].name;
                cell[3].Text = "" + items[i].amount;
                string s = "";
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while(reader2.Read())
                {
                    if (reader2[0].ToString() == ""+items[i].date) 
                      s+= reader2[1].ToString() + "(" + reader2[2]+") ,";
                }
                if(s.Length > 0) 
                s=s.Substring(0, s.Length-1);
                cell[4].Text = s;
                for (int j = 0; j < 5; j++)
                {
                    row.Cells.Add(cell[j]);
                }
                Table1.Rows.Add(row);
                reader2.Close();
            }
        }
        public void createPage(string msg)
        {

        }
    }
    class customer1:customer
    {
        public string ite;
        public Button btn=new Button();
    }
}