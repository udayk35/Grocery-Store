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
    public partial class WebForm6 : System.Web.UI.Page
    {
            public static List<Item> list = new List<Item>();
        public static List<TItem> items = new List<TItem>();
        CheckBox[] checkBoxes;
        TextBox[] textBoxes;
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            list.Clear();
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
                TItem item = new TItem();
                item.id = int.Parse("" + reader[0]);
                item.name = "" + reader[1];
                item.price = int.Parse("" + reader[3]);
                items.Add(item);
            }
            checkBoxes = new CheckBox[items.Count];
            textBoxes = new TextBox[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                checkBoxes[i] = new CheckBox();
                textBoxes[i] = new TextBox();
                TableRow row = new TableRow();
                TableCell[] cell = new TableCell[5];
                for (int j = 0; j < 5; j++)
                {
                    cell[j] = new TableCell();
                }
                cell[0].Text = "" + items[i].id;
                cell[1].Text = items[i].name;
                cell[2].Controls.Add(checkBoxes[i]);
                cell[3].Controls.Add(textBoxes[i]);
                cell[4].Text = "" + items[i].price;
                for (int j = 0; j < 5; j++)
                {
                    row.Cells.Add(cell[j]);
                }
                tblGrocery.Rows.Add(row);
            }
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    if (!textBoxes[i].Text.Equals(""))
                        list.Add(returnItem(i + 1, int.Parse(textBoxes[i].Text)));
                    else
                        list.Add(returnItem(i + 1, 0));
                }
            }
            Response.Redirect("WebForm5.aspx");
        }
        static Item returnItem(int id, int q)
        {
            Item item = new Item();
            item.id = id;
            item.quantity = q;
            return item;
        }
    }
    public class TItem
    {
        public int id;
        public String name;
        public int price;
    }
    public class Item
    {
        public int id;
        public int quantity;
    }
}