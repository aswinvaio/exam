<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="UploadExam.aspx.cs" Inherits="Exam.Web.Pages.UploadExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Upload Exam XML</h2>
    <br />
    <a href="AdminHome.aspx">Back to home</a>
    <br />
    <br />
    <div>
        <asp:FileUpload runat="server" ID="fuExam" />
        <asp:Button runat="server" ID="btnUpload" Text="Upload"
            OnClick="btnUpload_Click" />
        <asp:Label runat="server" ID="lblMessage" Text=""></asp:Label>
    </div>

</asp:Content>
