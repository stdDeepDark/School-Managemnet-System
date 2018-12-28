using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace WebApplication4
{
    public partial class ScoreQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myconn_str = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=course_system";
            MySqlConnection con = new MySqlConnection(myconn_str);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Course_Score", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?sid", MySqlDbType.Int32)); // type要自己选择

                cmd.Parameters["?sid"].Value = 16211061;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet,"table");
                GridView1.DataSource = dataSet.Tables[0];
                GridView1.DataBind();
            }
            catch { }
            finally { con.Close(); }
        }
    }
}