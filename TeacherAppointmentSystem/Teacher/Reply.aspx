<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teacher.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Reply.aspx.cs" Inherits="TeacherAppointmentSystem.Teacher.Reply" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form class="form-horizontal">
        <fieldset>
            <h2>Request Reply</h2>
            <div class="form-group">
                <label for="select" class="col-lg-2 control-label">Date</label>
                <div class="col-lg-10">

                    <asp:TextBox ID="txtDate" runat="server" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Date" ControlToValidate="txtDate" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                    <ajaxToolkit:CalendarExtender ID="txtDate_CalendarExtender" runat="server" BehaviorID="txtDate_CalendarExtender" TargetControlID="txtDate"></ajaxToolkit:CalendarExtender>

                </div>
            </div>

            <div class="form-group">
                <label for="select" class="col-lg-2 control-label">Start Time:</label>
                <div class="col-lg-10">

                    <asp:TextBox ID="txtsTime" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Input Start Date" ControlToValidate="txtsTime" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group">
                <label for="select" class="col-lg-2 control-label">End Time:</label>
                <div class="col-lg-10">
                    <asp:TextBox ID="TxtEtime" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Input End Date" ControlToValidate="TxtEtime" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group">
                <label for="select" class="col-lg-2 control-label">Teacher Id:</label>
                <div class="col-lg-10">
                    <asp:TextBox ID="txtTID" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Give Your Id" ControlToValidate="txtTID" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group">
                <label for="textArea" class="col-lg-2 control-label">ShowInfo:</label>

                <div class="col-lg-10">

                    <asp:TextBox ID="txtShowInfo" class="form-control" runat="server" placeholder="Brief Msg"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Give Brief Msg" ControlToValidate="txtShowInfo" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>


                    <span class="help-block"></span>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-10 col-lg-offset-2">
                    <button type="reset" class="btn btn-default">Cancel</button>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-default" OnClick="btnSubmit_Click" />
                </div>
            </div>
        </fieldset>
    </form>


</asp:Content>
