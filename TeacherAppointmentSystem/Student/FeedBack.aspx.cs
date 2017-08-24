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
    public partial class FeedBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            int ReqID = Convert.ToInt32(Request.QueryString["ReqID"]);

            SqlCommand cmd = new SqlCommand("insert into tblFeedback values(@ShowInfo,@ReqID)", con);
            cmd.Parameters.AddWithValue("ShowInfo", txtfeedback.Text);
            cmd.Parameters.AddWithValue("ReqID", ReqID);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Feedback succefully Send')</script>");
            txtfeedback.Text = "";
        }
    }
}