using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grocery_Store
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<TItem1> items = new List<TItem1>();
        protected void Page_Load(object sender, EventArgs e)
        {
            items.Clear();
            CreateDynamicRows();
        }
        public void CreateDynamicRows()
        {
            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\C# project\\DataBases\\Database1.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from store";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TItem1 item = new TItem1();
                item.id = int.Parse("" + reader[0]);
                item.name = "" + reader[1];
                item.Quantity = int.Parse(""+reader[2]);
                item.price = int.Parse("" + reader[3]);
                items.Add(item);
            }
            for (int i = 0; i < items.Count; i++)
            { 
                TableRow row = new TableRow();
                TableCell[] cell = new TableCell[4];
                for (int j = 0; j < 4; j++)
                {
                    cell[j] = new TableCell();
                }
                cell[0].Text = "" + items[i].id;
                cell[1].Text = items[i].name;
                cell[2].Text = ""+items[i].Quantity;
                cell[3].Text = "" + items[i].price;
                for (int j = 0; j < 4; j++)
                {
                    row.Cells.Add(cell[j]);
                }
                tblGrocery.Rows.Add(row);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
     class TItem1:TItem
    {
        public int Quantity;
    }
}