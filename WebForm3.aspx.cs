using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grocery_Store
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\C# project\\DataBases\\Database1.mdf\";Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                int ID;
                if (TextBox1.Text.Equals(""))
                {
                    msg = "Enter S.NO";
                    alert(msg, e);
                    return;
                }
                else if (TextBox2.Text.Equals(""))
                    {
                    msg = "Enter Item Name";
                    alert(msg, e);
                    return;
                    }
                else if(TextBox3.Text.Equals(""))
                {
                    msg = "Enter Item Quantity";
                    alert(msg, e);
                    return;
                }
                else
                        {
                            ID = int.Parse("" + TextBox1.Text);
                            // Use parameterized query to avoid SQL injection
                            string query = "SELECT * FROM store WHERE id=@ID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim());

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                        reader.Close();
                        query ="update store set Quantity="+TextBox3.Text+",Price="+TextBox4.Text+" where id="+TextBox1.Text;
                         cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        msg = "Data Updated";
                                alert(msg, e);
                            }
                            else
                            {
                        reader.Close();
                        // Record doesn't exist, you can perform insert or any other logic here
                        query = "insert into store values("+TextBox1.Text+",'"+TextBox2.Text+"',"+TextBox3.Text+","+TextBox4.Text+")";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        msg = "New Data Added";
                                alert(msg, e);
                    }
                            TextBox1.Text =string.Empty;
                            TextBox2.Text =string.Empty;
                            TextBox3.Text =string.Empty;
                            TextBox4.Text =string.Empty;
                            
                        }
            }
        }
        public void alert(string msg, EventArgs e)
        {
            string message = msg;
            string script = $@"<script type='text/javascript'>alert('{message}');</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "AlertBox", script);
        }
    }
}