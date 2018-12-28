using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.VisualBasic;
namespace WebApplication4
{
    public partial class teacher_course : System.Web.UI.Page
    {
        int course_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"].ToString() == "")
                Response.Redirect("Login.aspx");
            course_id = Int32.Parse(Request.QueryString["cid"]);
            string Myconn = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=sms";
            MySqlConnection mySql = new MySqlConnection(Myconn);
            mySql.Open();
            MySqlCommand cmd = new MySqlCommand("getC2SList", mySql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?cid", MySqlDbType.Int32)); // type要自己选择
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
            cmd.Parameters["?cid"].Value = course_id;
            cmd.Parameters["?result"].Direction = System.Data.ParameterDirection.Output;
            MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlda.Fill(ds, "Table1");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            if (cmd.Parameters["?result"].Value.ToString() == "0")
            {
                Response.Write("No Student!");
            }
            mySql.Close();

        }
        protected void setCourse(int sid,int course) {
            string Myconn = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=sms";
            MySqlConnection mySql = new MySqlConnection(Myconn);
            mySql.Open();
            MySqlCommand cmd = new MySqlCommand("modifyScore", mySql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?cid", MySqlDbType.Int32)); // type要自己选择
            cmd.Parameters.Add(new MySqlParameter("?sid", MySqlDbType.Int32)); // type要自己选择
            cmd.Parameters.Add(new MySqlParameter("?sco", MySqlDbType.Int32)); // type要自己选择
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
            cmd.Parameters["?cid"].Value = course_id;
            cmd.Parameters["?sid"].Value = sid;
            cmd.Parameters["?sco"].Value = course;
            cmd.Parameters["?result"].Direction = System.Data.ParameterDirection.Output;
            MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlda.Fill(ds, "Table1");
            mySql.Close();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = Interaction.InputBox("Input A New Score:");
            setCourse(Int32.Parse(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text), Int32.Parse(s));
        }
    }
}