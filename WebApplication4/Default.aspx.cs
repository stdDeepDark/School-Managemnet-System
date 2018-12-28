using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["role"].ToString() == "student")
                this.MasterPageFile = "~/Site_student.Master";
            else if (Session["role"].ToString() == "teacher")
                this.MasterPageFile = "~/Site_teacher.Master";
        }
    }
}