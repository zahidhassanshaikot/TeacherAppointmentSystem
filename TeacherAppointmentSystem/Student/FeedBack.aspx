<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="FeedBack.aspx.cs" Inherits="TeacherAppointmentSystem.Student.FeedBack" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Teacher Appointment form</h2>

    <form class="form-horizontal">
        <fieldset>
            

            <div class="form-group">
                
                <label for="textArea" class="col-lg-2 control-label">Purpose:</label>
                <div class="col-lg-10">
                    <asp:TextBox ID="txtfeedback" Rows="3" class="form-control" runat="server" placeholder="Give feedback"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Give feedback" ControlToValidate="txtfeedback" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                    <span class="help-block"></span>
                </div>


                <div class="col-lg-10 col-lg-offset-2">
                    <button type="reset" class="btn btn-default">Cancel</button>
                    <asp:Button ID="btnSubmit" runat="server" class="btn btn-default" OnClick="btnSubmit_Click" Text="Submit" />
                   
                </div>
                
            </div>
        </fieldset>
    </form>
</asp:Content>
