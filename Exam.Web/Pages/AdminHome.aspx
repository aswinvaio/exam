<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="AdminHome.aspx.cs" Inherits="Exam.Web.Pages.AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin's Home</h1>
    <asp:Literal runat="server" ID="litTalk"></asp:Literal>

    <div>
        <asp:FileUpload runat="server" ID="fuExam" />
        <asp:Button runat="server" ID="btnUpload" Text="Upload"
            OnClick="btnUpload_Click" />
        <asp:Label runat="server" ID="lblMessage" Text=""></asp:Label>
    </div>
</asp:Content>
