<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionCtrl.ascx.cs" Inherits="Exam.Web.UserCtrls.QuestionCtrl" %>
<br />
<br />
<div id="divMessage" runat="server" visible="false">
    <div class="alert alert-success finished" role="alert">
        <h4 class="alert-heading">Well done!</h4>
        <p>You have successfully completed the exam.</p>
    </div>
</div>
<div class="welcome" id="divWelcome" runat="server" visible="false">
    <div class="instructions">
        <h3>Instructions:</h3>
        <p>
            <asp:Literal ID="litIstructions" runat="server"></asp:Literal>
        </p>
    </div>
    <div class="time">
        <b>Time:
        <asp:Literal ID="litTime" runat="server"></asp:Literal></b>
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="btnContinue" runat="server" Text="Start" OnClick="btnContinue_Click" CssClass="btn btn-primary btn-start float-right" />
    </div>
</div>
<div class="question-conatiner" id="divQuestionContainer" runat="server">
    <div class="question">
        <b>
            <asp:Literal ID="litId" runat="server"></asp:Literal>.
                    <asp:Literal ID="litQuestion" runat="server"></asp:Literal></b>
    </div>
    <div class="question-description">
        <asp:Literal ID="litDescription" runat="server"></asp:Literal>
    </div>
    <div class="score">
        Score: 
                    <asp:Literal ID="litScore" runat="server"></asp:Literal>
    </div>
    <div class="options">
        <asp:Repeater ID="repOptions" runat="server" OnItemDataBound="repOptions_ItemDataBound">
            <ItemTemplate>
                <div class="option" id="divOption" runat="server">
                    <asp:CheckBox ID="chkOption" runat="server" />
                    <asp:Literal ID="litOptionId" runat="server"></asp:Literal>.
                    <asp:Literal ID="litOption" runat="server"></asp:Literal>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <br />
    <br />
    <div class="float-right">
        <asp:Button ID="btnNext" runat="server" Text="Save & Continue" OnClick="btnNext_Click" CssClass="btn btn-primary" />
    </div>
</div>
