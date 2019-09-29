<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="PreviewExam.aspx.cs" Inherits="Exam.Web.Pages.PreviewExam" %>
<%@ Register Src="~/UserCtrls/PreviewExamCtrl.ascx" TagPrefix="uc" TagName="PreviewExamCtrl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc:PreviewExamCtrl runat="server" />
</asp:Content>