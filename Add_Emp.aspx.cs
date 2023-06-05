using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace xBiz_Assesment
{
    public partial class Add_Emp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand sqlCommand = new SqlCommand("Add_EmpDetail",con);
                    using (SqlCommand cmd1 = sqlCommand)
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;

                        string FilePath = string.Concat(Server.MapPath("~/UploadResume/" + FileUpload1.FileName));
                        string filename = FileUpload1.FileName;
                        string path = "~\\UploadResume\\ " + filename.Trim();

                        cmd1.Parameters.AddWithValue("@Name", TextBox1.Text.Trim());
                        cmd1.Parameters.AddWithValue("@Contact", TextBox2.Text.Trim());
                        cmd1.Parameters.AddWithValue("@City", TextBox3.Text.Trim());
                        cmd1.Parameters.AddWithValue("@State", DropDownList1.SelectedValue.Trim());

                        String str = "";
                        for(int i=0;i<=CheckBoxList1.Items.Count -1; i++)
                        {
                            if (CheckBoxList1.Items[i].Selected)
                            {
                                if(str == "")
                                {
                                    str = CheckBoxList1.Items[i].Text;
                                }
                                else
                                {
                                    str += "," + CheckBoxList1.Items[i].Text;
                                }
                            }
                        }
                        cmd1.Parameters.AddWithValue("@Hobbies", str.Trim());
                        cmd1.Parameters.AddWithValue("@Resume", path.Trim());
                        cmd1.Connection = con;
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted.');", true);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}