<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="ViewSubmission.aspx.cs" Inherits="Exam.Web.Pages.ViewSubmission" %>

<%@ Register Src="~/UserCtrls/PreviewExamCtrl.ascx" TagPrefix="uc" TagName="PreviewExamCtrl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <a id="aBack" runat="server">Back to submissions</a>
        <br />
        <br />
    </div>
    <div class="submitted-user">
        UserID:
        <asp:Literal ID="litUserID" runat="server" /><br />
        Username:
        <asp:Literal ID="litUsername" runat="server" /><br />
        FullName:
        <asp:Literal ID="litFullName" runat="server" /><br />
        Score:
        <asp:Literal ID="litScore" runat="server" /><br />
        Updated on:
        <asp:Literal ID="litUpdatedDate" runat="server" /><br />
    </div>
    <div>
        <br />
        <uc:PreviewExamCtrl runat="server" />
    </div>
</asp:Content>
