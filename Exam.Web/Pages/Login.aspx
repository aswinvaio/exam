<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Anonymous.Master" CodeBehind="Login.aspx.cs" Inherits="Exam.Web.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-50">
                <span class="login100-form-title p-b-33">Account Login</span>
                <div class="wrap-input100 validate-input" data-validate="Valid email is required: ex@abc.xyz">
                    <asp:TextBox CssClass="input100" ID="txtUserName" placeholder="Username" runat="server"></asp:TextBox>
                </div>
                <div class="wrap-input100 rs1 validate-input" data-validate="Password is required">
                    <asp:TextBox CssClass="input100" ID="txtPassword" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                </div>
                <div class="container-login100-form-btn m-t-20">
                    <asp:Button ID="btnSignIn" CssClass="login100-form-btn" OnClick="btnSignIn_Click" runat="server" Text="Sign in" />
                </div>
                <div class="text-center p-t-45 p-b-4"></div>
            </div>
        </div>
    </div>
</asp:Content>
