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
        protected TextBox TextBox1;
        public MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConn_str = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=course_system";
            conn = new MySqlConnection(myConn_str);
            TextBox1.Text = "trying";
            try
            {
                conn.Open();
                TextBox1.Text = "connection succeed";
            }
            catch (MySqlException ex)
            {
                TextBox1.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = Login1.UserName.ToString().Trim().Replace("'", "").Replace("=", ""); ;
            string password = Login1.Password.ToString().Trim().Replace("'", "").Replace("=", ""); ;
            TextBox1.Text = "button clicked, trying to log in";
            MySqlCommand cmd = new MySqlCommand("login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?un", MySqlDbType.VarChar));
            cmd.Parameters.Add(new MySqlParameter("?pw", MySqlDbType.VarChar));
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
            cmd.Parameters["?un"].Direction = ParameterDirection.Input;
            cmd.Parameters["?pw"].Direction = ParameterDirection.Input;
            cmd.Parameters["?result"].Direction = ParameterDirection.Output;
            cmd.Parameters["?un"].Value = userName;
            cmd.Parameters["?pw"].Value = password;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                TextBox1.Text = cmd.Parameters["?result"].Value.ToString();
            }
            catch (Exception ex)
            {
                TextBox1.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}