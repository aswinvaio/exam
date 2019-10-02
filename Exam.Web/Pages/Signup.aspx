<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Exam.Web.Pages.Signup" MasterPageFile="~/MasterPages/Anonymous.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1>Sign Up</h1>
    <br />
    <br />
    <div class="form-signup">
        <div class="form-group row">
            <asp:Label runat="server" CssClass="col-sm-2 col-form-label" AssociatedControlID="txtFullName">Name</asp:Label>
            <div class="col-sm-10">
                <asp:TextBox runat="server" ID="txtFullName" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label runat="server" CssClass="col-sm-2 col-form-label" AssociatedControlID="txtEmail">Email ID</asp:Label>
            <div class="col-sm-10">
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label runat="server" CssClass="col-sm-2 col-form-label" AssociatedControlID="txtMobile">Mobile Number</asp:Label>
            <div class="col-sm-10">
                <asp:TextBox runat="server" ID="txtMobile" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label runat="server" CssClass="col-sm-2 col-form-label" AssociatedControlID="txtUsername">Username</asp:Label>
            <div class="col-sm-10">
                <asp:TextBox runat="server" ID="txtUsername" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label runat="server" CssClass="col-sm-2 col-form-label" AssociatedControlID="txtPassword">Password</asp:Label>
            <div class="col-sm-10">
                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div runat="server" role="alert" visible="false" id="divAlert">
            <asp:Literal runat="server" ID="litMessage"></asp:Literal>
        </div>

        <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button runat="server" CssClass="btn btn-primary" ID="btnSignup" OnClick="btnSignup_Click" Text="Sign Up" />
                &nbsp;
            <div class="btn btn-light"><a href="/">Login</a></div>
            </div>
        </div>
    </div>
</asp:Content>
