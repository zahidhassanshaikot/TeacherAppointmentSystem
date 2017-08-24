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
    public partial class TProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            con.Open();
            string username = Session["user"].ToString();
            SqlCommand cmd = new SqlCommand("Select * from tbl_Teacher where UserName=@username ", con);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridViewTProfile.DataSource = rdr;
            GridViewTProfile.DataBind();
            con.Close();
            }
            
        }


    }
}