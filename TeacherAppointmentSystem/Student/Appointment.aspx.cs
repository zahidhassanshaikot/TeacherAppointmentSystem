using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace TeacherAppointmentSystem.Student
{
    public partial class Appointment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


            if (!IsPostBack)
            {
                
                DropDownListTeacher.Items.Clear();
                DropDownListTeacher.Items.Add(new ListItem("--Select Teacher--", ""));

                DropDownListTeacher.AppendDataBoundItems = true;
                String strConnString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                String strQuery = "select TID, TName from tbl_Teacher";
                SqlConnection con = new SqlConnection(strConnString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Connection = con;
                try
                {
                    con.Open();
                    DropDownListTeacher.DataSource = cmd.ExecuteReader();
                    DropDownListTeacher.DataTextField = "TName";
                    DropDownListTeacher.DataValueField = "TID";
                    DropDownListTeacher.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
                

            }

            //if (!IsPostBack)
            //{
            //    DropDownListDepartment.DataSource= getData("spGetDept", null);
            //    DropDownListDepartment.DataBind();

            //    ListItem listDept = new ListItem("Select Dept", "-1");
            //    DropDownListDepartment.Items.Insert(0, listDept);

            //    ListItem listTeacher = new ListItem("Select Teacher", "-1");
            //    DropDownListTeacher.Items.Insert(0, listTeacher);

            //    //DropDownListTeacher.Enabled = false;
            //}
        }

        //private DataSet getData(string spName, SqlParameter SPParameter)
        //{
        //    string CS = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        //    SqlConnection con = new SqlConnection(CS);
        //    SqlDataAdapter da = new SqlDataAdapter(spName, con);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    if (SPParameter != null)
        //    {
        //        da.SelectCommand.Parameters.Add(SPParameter);
        //    }
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds;
        //}

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                con.Open();
                //string username = Session["user"].ToString();
                //SqlCommand cmd1 = new SqlCommand("Select StID from tblStudent where UserName=@user ", con);
                //cmd1.Parameters.AddWithValue("@user", username);

                //int sId = Convert.ToInt32(cmd1.ExecuteScalar());


                SqlCommand cmd = new SqlCommand("insert into tblRequest values(@purpose,@StartTime,@EndTime,@StID,@TID,@day)", con);
                cmd.Parameters.AddWithValue("purpose", txtPurpose.Text);
                cmd.Parameters.AddWithValue("StartTime", txtsTime.Text);
                cmd.Parameters.AddWithValue("EndTime", TxtEtime.Text);
                cmd.Parameters.AddWithValue("StID", txtSID.Text);
                cmd.Parameters.AddWithValue("TID", DropDownListTeacher.SelectedValue);
                cmd.Parameters.AddWithValue("day", txtDate.Text);
                cmd.ExecuteNonQuery();
            }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Check your input..')</script>");
                }

            Response.Write("<script>alert('Appointment Request succefully Send')</script>");


            txtDate.Text = "";
            TxtEtime.Text = "";
            txtPurpose.Text = "";
            txtSID.Text = "";
            txtsTime.Text = "";
           // Response.Redirect("Appointment.aspx");




            //Session["day"] = Convert.ToDateTime(txtDate.Text).DayOfWeek.ToString();
            //Session["TID"] = DropDownListTeacher.DataValueField;
            //Response.Redirect("Appointment2.aspx");
        }

        //protected void DropDownListDepartment_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (DropDownListDepartment.SelectedIndex == 0)
        //    {

        //    }
        //    else
        //    {
        //        //DropDownListTeacher.Enabled = true;
        //        SqlParameter parameter = new SqlParameter("@DeptID", DropDownListDepartment.SelectedValue);
        //        DataSet ds = getData("spGetTeacher", parameter);
        //        DropDownListTeacher.DataSource = ds;
        //        DropDownListTeacher.DataBind();

        //    }
        //}

        //protected void DropDownListStartTime_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    DropDownListStartTime.Items.Clear();
        //    DropDownListStartTime.Items.Add(new ListItem("--Select Time--", ""));

        //    DropDownListTeacher.AppendDataBoundItems = true;
        //    String strConnString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        //    String strQuery = "select StartTime from tblAvailableTime join tblday on tblday.Day= @day join tbl_Teacher on tbl_Teacher.TID=@TID";
        //    SqlConnection con = new SqlConnection(strConnString);

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Parameters.AddWithValue("@TID", DropDownListTeacher.SelectedItem.Value);
        //    string day = Convert.ToDateTime(txtDate.Text).DayOfWeek.ToString();    

        //    cmd.Parameters.AddWithValue("@day", day);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = strQuery;
        //    cmd.Connection = con;
        //    txtday.Text = day;
        //    try
        //    {
        //        con.Open();
        //        DropDownListStartTime.DataSource = cmd.ExecuteReader();
        //        DropDownListStartTime.DataTextField = "StartTime";
        //        //DropDownListTeacher.DataValueField = "TID";
        //        DropDownListStartTime.DataBind();
        //        //if (DropDownListTeacher.Items.Count > 1)
        //        //{
        //        //    DropDownListTeacher.Enabled = true;
        //        //}
        //        //else
        //        //{
        //        //    DropDownListTeacher.Enabled = false;
        //        //    DropDownListavTime.Enabled = false;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //    }
        //}

        //protected void DropDownListTeacher_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DropDownListTeacher.Items.Clear();
        //    DropDownListTeacher.Items.Add(new ListItem("--Select Teacher--", ""));
        //    DropDownListavTime.Items.Clear();
        //    DropDownListavTime.Items.Add(new ListItem("--Select Time--", ""));

        //    DropDownListTeacher.AppendDataBoundItems = true;
        //    String strConnString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        //    String strQuery = "select TID, TName from tbl_Teacher where DeptID=@DID";
        //    SqlConnection con = new SqlConnection(strConnString);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Parameters.AddWithValue("@DID", DropDownListDepartment.SelectedItem.Value);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = strQuery;
        //    cmd.Connection = con;
        //    try
        //    {
        //        con.Open();
        //        DropDownListTeacher.DataSource = cmd.ExecuteReader();
        //        DropDownListTeacher.DataTextField = "TName";
        //        DropDownListTeacher.DataValueField = "TID";
        //        DropDownListTeacher.DataBind();
        //        if (DropDownListTeacher.Items.Count > 1)
        //        {
        //            DropDownListTeacher.Enabled = true;
        //        }
        //        else
        //        {
        //            DropDownListTeacher.Enabled = false;
        //            DropDownListavTime.Enabled = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //    }
        //}

        //protected void LoadDropDown()
        //{
        //    //Get your connection string
        //    string connstring = ConfigurationManager.ConnectionStrings["dbconnection"].ToString();
        //    //Create connection here
        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        //Sample Query here; You need to update the query as per your need
        //        string sqlquery = "select DeptID as Dept from tbl_Department";
        //        //Create SQLCommand object
        //        using (SqlCommand cmd = new SqlCommand(sqlquery, conn))
        //        {
        //            //Open the SQLConnection
        //            conn.Open();
        //            //Execute the query
        //            SqlDataReader rdr = cmd.ExecuteReader();

        //            //Assign the values to dropdownlist
        //            DropDownListDepartment.DataSource = rdr;
        //            //Set the DataValueField of dropdownlist
        //            DropDownListDepartment.DataValueField = "Dept";
        //            //Set the DataTextField of dropdownlist
        //            DropDownListDepartment.DataTextField = "Dept";
        //            //Bind the dropdownlist
        //            DropDownListDepartment.DataBind();
        //        }
        //    }
        //}

        //protected void DropDownListTeacher_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //Get your connection string
        //    string connstring = ConfigurationManager.ConnectionStrings["dbconnection"].ToString();
        //    //Create connection here
        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        //Sample Query here; You need to update the query as per your need
        //        string sqlquery = "select TName as Tname from tbl_Teacher where tbl_Teacher.DeptID =@Dept";
        //        //Create SQLCommand object
        //        using (SqlCommand cmd = new SqlCommand(sqlquery, conn))
        //        {
        //            //Open the SQLConnection
        //            conn.Open();

        //            //Pass the value selected in previous dropdownlist as parameter to this query
        //            cmd.Parameters.AddWithValue("@Dept", DropDownListDepartment.SelectedItem.ToString());
        //            //Execute the query
        //            SqlDataReader rdr = cmd.ExecuteReader();

        //            //Assign the values to dropdownlist
        //            DropDownListTeacher.DataSource = rdr;
        //            //Set the DataValueField of dropdownlist
        //            DropDownListTeacher.DataValueField = "Tname";
        //            //Set the DataTextField of dropdownlist
        //            DropDownListTeacher.DataTextField = "Tname";
        //            //Bind the dropdownlist
        //            DropDownListTeacher.DataBind();
        //        }
        //    }
        //}



    }
}