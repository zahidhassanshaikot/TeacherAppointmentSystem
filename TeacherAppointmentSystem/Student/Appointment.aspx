<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Appointment.aspx.cs" Inherits="TeacherAppointmentSystem.Student.Appointment" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Teacher Appointment form</h2>

    <form class="form-horizontal">
        <fieldset>
            

            <div class="form-group">
                <label for="select" class="col-lg-2 control-label">Teacher:</label>
                <div class="col-lg-10">

                    <asp:DropDownList ID="DropDownListTeacher" class="form-control" runat="server" DataTextField="TName" DataValueField="TID"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Teacher" ControlToValidate="DropDownListTeacher" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </div>



                <label for="select" class="col-lg-2 control-label">Date</label>
                <div class="col-lg-10">

                    <asp:TextBox ID="txtDate" runat="server" class="form-control"></asp:TextBox>


                    <ajaxToolkit:CalendarExtender ID="txtDate_CalendarExtender" runat="server" BehaviorID="txtDate_CalendarExtender" TargetControlID="txtDate" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Select Appointment Date" ControlToValidate="txtDate" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>


                </div>



                <label for="select" class="col-lg-2 control-label">Start Time:</label>
                <div class="col-lg-10">

                    <asp:TextBox ID="txtsTime" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Input Start time" ControlToValidate="txtsTime" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>


                </div>



                <label for="select" class="col-lg-2 control-label">End Time:</label>
                <div class="col-lg-10">
                    <asp:TextBox ID="TxtEtime" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Input End time" ControlToValidate="TxtEtime" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </div>



                <label for="select" class="col-lg-2 control-label">Student Id:</label>
                <div class="col-lg-10">
                    <asp:TextBox ID="txtSID" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Input Your Id" ControlToValidate="txtSID" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </div>


                <label for="textArea" class="col-lg-2 control-label">Purpose:</label>
                <div class="col-lg-10">
                    <asp:TextBox ID="txtPurpose" Rows="3" class="form-control" runat="server" placeholder="why do you want to meet?"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Write Why need Appointment?" ControlToValidate="txtPurpose" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                    <span class="help-block"></span>
                </div>


                <div class="col-lg-10 col-lg-offset-2">
                    <button type="reset" class="btn btn-default">Cancel</button>
                    <asp:Button ID="btnSubmit" runat="server" class="btn btn-default" OnClick="btnSubmit_Click" Text="Submit" />
                   
                </div>
                 <asp:Label ID="Label1" runat="server" Visible="false" Text="Label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            </div>
        </fieldset>
    </form>
</asp:Content>
