<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="UploadExam.aspx.cs" Inherits="Exam.Web.Pages.UploadExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Upload Exam XML</h2>
    <br />
    <a href="AdminHome.aspx">Back to home</a>
    <br />
    <br />
    <div>
        <div class="w-50">
            <asp:FileUpload runat="server" ID="fuExam" CssClass="custom-file-asw" />
        </div>
        <br />
        <asp:Button runat="server" ID="btnUpload" Text="Upload"
            OnClick="btnUpload_Click" CssClass="btn btn-primary" />
        <br />
        <br />
        <asp:Label runat="server" ID="lblMessage" Text="" CssClass="alert-warning"></asp:Label>
    </div>

</asp:Content>
