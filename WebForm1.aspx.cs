using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Grocery_Store
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\C# project\\DataBases\\Database1.mdf\";Integrated Security=True;Connect Timeout=30";
        static SqlConnection conn = new SqlConnection(ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            int i = 0;
            int total = 0;
            while(i<WebForm6.list.Count)
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from store where id="+ WebForm6.list[i].id;
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                    TableRow row = new TableRow();
                    TableCell[] cell = new TableCell[5];
                    for (int j = 0; j < 5; j++)
                    {
                        cell[j] = new TableCell();
                    }
                    cell[0].Text = "" + (i + 1);
                    cell[1].Text = ""+reader[1];
                cell[2].Text = "" + WebForm6.list[i].quantity;
                cell[3].Text = "" + reader[3];
                int units = WebForm6.list[i].quantity;
                int tunits = int.Parse("" + reader[2]);
                int prize = int.Parse("" + reader[3]);
                int tp = units * prize;
                total += tp;
                cell[4].Text = "" + tp;
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into Items values('" + WebForm5.c.date.ToString() + "','" + reader[1] + "'," + WebForm6.list[i].quantity +")";
                for (int j = 0; j < 5; j++)
                    {
                        row.Cells.Add(cell[j]);
                    }
                    Table1.Rows.Add(row);
                reader.Close();
                cmd2.ExecuteNonQuery();
                updateDataBase(WebForm6.list[i].id, tunits- WebForm6.list[i].quantity);
                i++;
            }
            WebForm5.c.amount = total;
            TableRow row1= new TableRow();
            TableCell celltag= new TableCell();
            celltag.Text = "Total Amount";
            celltag.ColumnSpan = 4;
            TableCell cellAmount = new TableCell();
            cellAmount.Text = "" + total; 
            row1.Cells.Add(celltag);
            row1.Cells.Add(cellAmount);
            Table1.Rows.Add(row1);
            SqlCommand cmd1 = new SqlCommand();
            
            cmd1.Connection = conn;
            
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into customer values('"+WebForm5.c.mobile+"','"+ WebForm5.c.date.ToString()+"','" + WebForm5.c.name.ToString()+"',"+total+")";
            cmd1.ExecuteNonQuery();
            conn.Close();

        }
        protected static void updateDataBase(int id ,int q)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update store set Quantity="+q+" where id=" +id;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }
    }
}