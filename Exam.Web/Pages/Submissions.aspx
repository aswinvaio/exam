<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserBase.Master" CodeBehind="Submissions.aspx.cs" Inherits="Exam.Web.Pages.Submissions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Submissions</h3>
    <br />
    <a href="AdminHome.aspx">Back to home</a>
    <br />
    <br />
    <div>
        <div class="submission-list">
            <asp:GridView ID="gvSubmissionList" runat="server" OnRowDataBound="gvSubmissionList_RowDataBound" Width="100%" AutoGenerateColumns="false" CssClass="gridview" EmptyDataText="No Submissions">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Literal ID="litId" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="UserID">
                        <ItemTemplate>
                            <asp:Literal ID="litUserID" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Username">
                        <ItemTemplate>
                            <asp:Literal ID="litUsername" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Full Name">
                        <ItemTemplate>
                            <asp:Literal ID="litFullName" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Score">
                        <ItemTemplate>
                            <asp:Literal ID="litScore" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Updated Date">
                        <ItemTemplate>
                            <asp:Literal ID="litUpdatedDate" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a id="btnView" runat="server" href="/">View</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
