using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        static int id;
        public MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConn_str = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=sms";
            conn = new MySqlConnection(myConn_str);      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {      
            string username = Request["login"].ToString();
            string password = Request["password"].ToString();
            MySqlCommand cmd;
            string role;
            if (CheckBox1.Checked)
            {
                cmd = new MySqlCommand("tLogin", conn);
                role = "teacher";
            }
            else
            {
                cmd = new MySqlCommand("Login", conn);
                role = "student";
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?un", MySqlDbType.VarChar));
            cmd.Parameters.Add(new MySqlParameter("?pw", MySqlDbType.VarChar));
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
            cmd.Parameters["?un"].Direction = ParameterDirection.Input;
            cmd.Parameters["?pw"].Direction = ParameterDirection.Input;
            cmd.Parameters["?result"].Direction = ParameterDirection.Output;
            cmd.Parameters["?un"].Value = username;
            cmd.Parameters["?pw"].Value = password;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                int id = Convert.ToInt32(cmd.Parameters["?result"].Value);
                if (id == 0)
                {
                    Response.Write("<script>alert('Login failure:username or password wrong!')</script>");
                }
                else
                {
                    Session["id"] = id.ToString();
                    Session["role"] = role;
                    Response.Redirect("Default.aspx");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}