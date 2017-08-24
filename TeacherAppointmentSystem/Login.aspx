<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TeacherAppointmentSystem.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" class="dropdown-header" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="40px" Width="139px">
        <asp:ListItem Value="0">Selected item</asp:ListItem>
        <asp:ListItem Value="1">Student</asp:ListItem>
        <asp:ListItem Value="2">Teacher</asp:ListItem>
    </asp:DropDownList>

    </center>
    <asp:Panel ID="PanelStudent" runat="server">

        <form>
            <h1>Student log Here</h1>
            <div class="input-group">
                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>

                <asp:TextBox ID="txtSUserName" class="form-control" runat="server" placeholder="User Name"></asp:TextBox>
            </div>

            <div class="input-group">
                <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>

                <asp:TextBox ID="txtSPass" class="form-control" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
            </div>

            <asp:Button ID="btnSlogin" runat="server" class="btn btn-default" Text="Login" OnClick="btnSlogin_Click"  />

        </form>


    </asp:Panel>

    <asp:Panel ID="PanelTeacher" runat="server">

       
        <form >
            <h1>Teacher log Here </h1>
            <div class="input-group">
                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>

                <asp:TextBox ID="txtTUserName" class="form-control" runat="server" placeholder="User Name"></asp:TextBox>
            </div>

            <div class="input-group">
                <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>

                <asp:TextBox ID="txtTPass" class="form-control" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
            </div>

             <div class="input-group">
                <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>

                <asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
            </div>

            <asp:Button ID="btnTlogin" runat="server" class="btn btn-default" Text="Login" OnClick="btnTlogin_Click" />

        </form>
            
    </asp:Panel>








</asp:Content>
