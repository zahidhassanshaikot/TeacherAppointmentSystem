using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherAppointmentSystem.Student
{
    public partial class TeacherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT TName,Designation,DeptID,Phone,mail FROM tbl_Teacher", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridViewTeacherInfo.DataSource = rdr;
            GridViewTeacherInfo.DataBind();
            con.Close();
        }
    }
}