﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="AdminHome.aspx.cs" Inherits="Exam.Web.Pages.AdminHome" %>

<%@ Register Src="~/UserCtrls/ExamList.ascx" TagPrefix="uc" TagName="ExamList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin's Home</h1>
    <asp:Literal runat="server" ID="litTalk"></asp:Literal>
    <div>
        <a href="UploadExam.aspx" >Upload new Exam XML</a>
    </div>
    <br />
    <br />
    <div>
        <h2>Available Exams:</h2>
        <br />
        <div class="exam-list">
            <uc:ExamList runat="server" />
        </div>
    </div>
</asp:Content>
