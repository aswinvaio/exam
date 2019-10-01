<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="Home.aspx.cs" Inherits="Exam.Web.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Begin exam</h2>
    <div class="d-flex flex-column">
        <div class="alert alert-primary">
            <asp:Literal runat="server" ID="litTalk"></asp:Literal>
        </div>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="h-100 row align-items-center">
        <div class="input-group justify-content-center">
            <div class="input-group-prepend">
                <span class="input-group-text">
                    <asp:Literal runat="server" ID="litExamID" Text="Exam ID: "></asp:Literal></span>
            </div>
            <asp:TextBox runat="server" ID="txtExamID" CssClass="form-control col-2"></asp:TextBox>
            <div class="input-group-append">
                <asp:Button runat="server" ID="btnExamID" Text="Go!" OnClick="btnExamID_Click" CssClass="btn btn-primary" />
            </div>
        </div>
        <br />
        <br />
        <br />
        <div class="w-100">
            <div class="alert-warning i-am-centered">
                <asp:Literal runat="server" ID="litError"></asp:Literal>

            </div>
        </div>
    </div>
</asp:Content>
