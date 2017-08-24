using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherAppointmentSystem.Teacher
{
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            string username = Session["user"].ToString();
            SqlCommand cmd = new SqlCommand("select ReqID, Purpose,StartTime,EndTime,StID,day from tblRequest r inner join tbl_Teacher t on t.TID=r.TID where UserName=@username", con);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridViewRequest.DataSource = rdr;
            GridViewRequest.DataBind();
            con.Close();
        }
    }
}