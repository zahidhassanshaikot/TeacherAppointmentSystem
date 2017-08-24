using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace TeacherAppointmentSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelStudent.Visible = false;
            PanelTeacher.Visible = false;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
         if(DropDownList1.SelectedValue=="1")

         {
             PanelStudent.Visible = true;
         }
         else if (DropDownList1.SelectedValue == "2")
         {
             PanelTeacher.Visible = true;
         }
            else
         {
             PanelStudent.Visible = false;
             PanelTeacher.Visible = false;
         }
        }



        protected void btnTlogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserName, Password from tbl_Teacher where UserName =@username and Password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtTUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtTPass.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["user"] = txtTUserName.Text;
                Response.Redirect("~/Teacher/Teacher.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            }
        }

        protected void btnSlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserName, Password from tblStudent where UserName =@username and Password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtSUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtSPass.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["Suser"] = txtSUserName.Text;
                Response.Redirect("~/Student/Student.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            }
        }
    }
}