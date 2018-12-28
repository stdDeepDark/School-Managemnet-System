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
    public partial class Teacher : System.Web.UI.Page
    {
        int tid = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"].ToString() == "")
                Response.Redirect("Login.aspx");
            string Myconn = "server=120.78.83.103;port=3306;user id=root;password=ItIsNotAPassword;database=sms";
            MySqlConnection mySql = new MySqlConnection(Myconn);
            mySql.Open();
            MySqlCommand cmd = new MySqlCommand("getTeachingCourseList", mySql);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?tid", MySqlDbType.Int32)); // type要自己选择
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.Int32));
            cmd.Parameters["?tid"].Value = tid;
            cmd.Parameters["?result"].Direction = System.Data.ParameterDirection.Output;
            MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlda.Fill(ds, "Table1");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            if (cmd.Parameters["?result"].Value.ToString() == "0") {
                Response.Write("No Course!");
            }
            mySql.Close();

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='teacher_course.aspx?cid=" + GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text.ToString() + "'</script>");
        }
    }
}