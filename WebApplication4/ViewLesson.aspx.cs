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
    public partial class ViewLesson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"].ToString() == "")
                Response.Redirect("Login.aspx");
            get_list();

        }
        void get_list()
        {
            int id =Convert.ToInt32(Session["id"]);
            string Myconn = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=sms";
            MySqlConnection mySql = new MySqlConnection(Myconn);
            mySql.Open();
            MySqlCommand cmd = new MySqlCommand("getCourseList", mySql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?sid", MySqlDbType.Int32)); // type要自己选择
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
            cmd.Parameters["?sid"].Direction = ParameterDirection.Input;
            cmd.Parameters["?result"].Direction = ParameterDirection.Output;
            cmd.Parameters["?sid"].Value = id;
            MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            sqlda.Fill(ds, "Table1");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
           
            mySql.Close();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex == -1) return;
            choose(Convert.ToInt32(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text));
            GridView1.SelectedIndex = -1;
        }

        void choose(int i)
        {
            int id = Convert.ToInt32(Session["id"]);
            string Myconn = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=sms";
            MySqlConnection mySql = new MySqlConnection(Myconn);
            mySql.Open();
            MySqlCommand cmd = new MySqlCommand("selectCourse", mySql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?sid", MySqlDbType.Int32)); // type要自己选择
            cmd.Parameters.Add(new MySqlParameter("?cid", MySqlDbType.Int32));
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
            cmd.Parameters["?sid"].Direction = ParameterDirection.Input;
            cmd.Parameters["?cid"].Direction = ParameterDirection.Input;
            cmd.Parameters["?result"].Direction = ParameterDirection.Output;
            cmd.Parameters["?sid"].Value = id;
            cmd.Parameters["?cid"].Value = i;
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('选课成功')</script>");
            get_list();
        }
    }
}