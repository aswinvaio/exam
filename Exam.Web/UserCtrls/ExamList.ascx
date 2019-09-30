<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ExamList.ascx.cs" Inherits="Exam.Web.UserCtrls.ExamList" %>
<div class="exam-list">
    <asp:GridView ID="gvExamList" runat="server" OnRowDataBound="gvExamList_RowDataBound" Width="100%" AutoGenerateColumns="false" CssClass="gridview" EmptyDataText="No Exams to list">
        <Columns>
            <asp:TemplateField HeaderText="ExamID">
                <ItemTemplate>
                    <asp:Literal ID="litExamId" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Created Date">
                <ItemTemplate>
                    <asp:Literal ID="litDate" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a id="btnPreviewQuestions" runat="server" href="/">Preview Questions</a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a id="btnViewSubmissions" runat="server" href="/">View Submissions</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
