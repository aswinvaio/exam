﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionCtrl.ascx.cs" Inherits="Exam.Web.UserCtrls.QuestionCtrl" %>

<div class="question-conatiner">
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
</div>
