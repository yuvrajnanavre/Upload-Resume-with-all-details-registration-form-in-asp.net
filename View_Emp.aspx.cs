using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace xBiz_Assesment
{
    public partial class View_Emp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BindGrid();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("BIND_Menu1", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "CombinetwoColumn";
            DropDownList1.DataValueField = "CombinetwoColumn";
            DropDownList1.DataBind();       
            //DropDownList1.Items.Insert(0, new System.Web.UI.WebControls.ListItem("-- Select --","0"));

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("sp_selectemp", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd1);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@empid", Convert.ToString(DropDownList1.Text));

                cmd1.Connection = con;
                DataTable dt = new DataTable();
                sd.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();
                
            }
            catch(Exception ex)
            {

            }

        }
    }
}