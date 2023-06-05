using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xBiz_Assesment
{
    public partial class Redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_Checked(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_Checked(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                Response.Redirect("View_Emp.aspx");
            }
            else
            { 
                Response.Redirect("Add_Emp.aspx");
            }
        }
    }
}