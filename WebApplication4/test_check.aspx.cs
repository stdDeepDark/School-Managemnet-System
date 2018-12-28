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
    public partial class test_check : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"].ToString() == "")
                Response.Redirect("Login.aspx");
            string myconn_str = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=sms";
            MySqlConnection con = new MySqlConnection(myconn_str);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("queryExam", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?sid", MySqlDbType.Int32)); // type要自己选择
                cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
                cmd.Parameters["?sid"].Direction = ParameterDirection.Input;
                cmd.Parameters["?result"].Direction = ParameterDirection.Output;
                cmd.Parameters["?sid"].Value = Session["id"];
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet, "table");
                GridView1.DataSource = dataSet.Tables[0];
                GridView1.DataBind();
            }
            catch { }
            finally { con.Close(); }
        }
    }
}