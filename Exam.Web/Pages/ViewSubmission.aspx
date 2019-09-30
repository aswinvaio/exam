<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="ViewSubmission.aspx.cs" Inherits="Exam.Web.Pages.ViewSubmission" %>

<%@ Register Src="~/UserCtrls/PreviewExamCtrl.ascx" TagPrefix="uc" TagName="PreviewExamCtrl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <a id="aBack" runat="server">Back to submissions</a>
        <br />
    </div>
    <div>
        <br />
        <uc:PreviewExamCtrl runat="server" />
    </div>
</asp:Content>