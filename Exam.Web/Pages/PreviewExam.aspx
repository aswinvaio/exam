<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/AdminBase.Master" CodeBehind="PreviewExam.aspx.cs" Inherits="Exam.Web.Pages.PreviewExam" %>

<%@ Register Src="~/UserCtrls/PreviewExamCtrl.ascx" TagPrefix="uc" TagName="PreviewExamCtrl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <a href="AdminHome.aspx">Back to home</a>
        <br />
    </div>
    <div>
        <br />
        <uc:PreviewExamCtrl runat="server" />
    </div>
</asp:Content>

