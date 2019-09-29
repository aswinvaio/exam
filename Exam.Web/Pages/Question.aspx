<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="Question.aspx.cs" Inherits="Exam.Web.Pages.Question" %>
<%@ Register Src="~/UserCtrls/QuestionCtrl.ascx" TagPrefix="uc" TagName="QuestionCtrl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc:QuestionCtrl runat="server" />
</asp:Content>