using System;
using System.Configuration;
using System.Data.SqlClient;

namespace TeacherAppointmentSystem.Teacher
{
    public partial class Reply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            int ReqID = Convert.ToInt32(Request.QueryString["ReqID"]);

            SqlCommand cmd = new SqlCommand("insert into tblReply values(@ShowInfo,@date,@StartTime,@EndTime,@TID,@ReqID)", con);
            cmd.Parameters.AddWithValue("ShowInfo", txtShowInfo.Text);

            cmd.Parameters.AddWithValue("StartTime", txtsTime.Text);
            cmd.Parameters.AddWithValue("EndTime", TxtEtime.Text);
            cmd.Parameters.AddWithValue("date", txtDate.Text);

            cmd.Parameters.AddWithValue("TID", txtTID.Text);
            cmd.Parameters.AddWithValue("ReqID", ReqID);

            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Appointment Reply succefully Send')</script>");
            txtDate.Text = "";
            TxtEtime.Text = "";
            txtShowInfo.Text = "";

            txtsTime.Text = "";
            // Response.Redirect("~/Teacher/Reply.aspx");


        }
    }
}