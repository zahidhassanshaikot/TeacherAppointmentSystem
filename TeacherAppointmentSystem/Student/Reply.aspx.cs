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
    public partial class Reply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String username = Session["Suser"].ToString();

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Select r.RipID, r.ShowInfo ,r.StartTime, r.EndTime, r.date, r.TID, r.ReqID from tblRequest req inner join tblReply r on r.TID=req.TID inner join tblStudent s on req.StID=s.StID where UserName=@username ", con);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader rdr = cmd.ExecuteReader();
                GridViewReply.DataSource = rdr;
                GridViewReply.DataBind();
                con.Close();
            }
        }
    }
}