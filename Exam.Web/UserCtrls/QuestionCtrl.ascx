<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionCtrl.ascx.cs" Inherits="Exam.Web.UserCtrls.QuestionCtrl" %>
<div id="divMessage" runat="server" visible="false">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</div>
<div id="divWelcome" runat="server" visible="false">
    <div class="instructions">
        <b>Instructions:</b>
        <br/><p>
        <asp:Literal ID="litIstructions" runat="server"></asp:Literal></p>
    </div>
    <div class="time">
        Time: <asp:Literal ID="litTime" runat="server"></asp:Literal> Sec
    </div>
    <div>
        <asp:Button ID="btnContinue" runat="server" Text="Start" OnClick="btnContinue_Click" />
    </div>
</div>
<div class="question-conatiner" id="divQuestionContainer" runat="server">
    <div class="question">
        <asp:Literal ID="litId" runat="server"></asp:Literal>.
                    <asp:Literal ID="litQuestion" runat="server"></asp:Literal>
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
                    <asp:CheckBox ID="chkOption" runat="server" />
                    <asp:Literal ID="litOptionId" runat="server"></asp:Literal>. <asp:Literal ID="litOption" runat="server"></asp:Literal>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div>
        <asp:Button ID="btnNext" runat="server" Text="Save& Continue" OnClick="btnNext_Click" />
    </div>
</div>
