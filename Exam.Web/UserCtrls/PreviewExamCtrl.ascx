<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PreviewExamCtrl.ascx.cs" Inherits="Exam.Web.UserCtrls.PreviewExamCtrl" %>

<div class="exam-container">
    <div class="instructions">
        <h3>Instructions:</h3>
        <br />
        <p>
            <asp:Literal ID="litIstructions" runat="server"></asp:Literal>
        </p>
    </div>
    <div class="time">
        <b>Time:
            <asp:Literal ID="litTime" runat="server"></asp:Literal>
            Sec</b>
    </div>
    <br />
    <div>
        <h3>Questions:</h3>
    </div>
    <asp:Repeater ID="repQuestions" runat="server" OnItemDataBound="repQuestions_ItemDataBound">
        <ItemTemplate>
            <br />
            <div class="question-conatiner">
                <div class="question">
                    <b>
                        <asp:Literal ID="litId" runat="server"></asp:Literal>.
                    <asp:Literal ID="litQuestion" runat="server"></asp:Literal>
                    </b>
                </div>
                <div class="question-description">
                    <asp:Literal ID="litDescription" runat="server"></asp:Literal>
                </div>
                <div class="score">
                    <i>Score: 
                    <asp:Literal ID="litScore" runat="server"></asp:Literal></i>
                </div>
                <div class="options">
                    <asp:Repeater ID="repOptions" runat="server" OnItemDataBound="repOptions_ItemDataBound">
                        <ItemTemplate>
                            <div class="option" id="divOption" runat="server">
                                <%--<asp:CheckBox ID="chkOption" runat="server" />--%>
                                <asp:Literal ID="litOptionId" runat="server"></asp:Literal>.
                                <asp:Literal ID="litOption" runat="server"></asp:Literal>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
