<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="KnowIsKnow.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Message.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/message.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
	<div class="main">
		<div class="content">
			<div class="main-content-inner" id="wk-page">
				<div class="zg-section">
					<div class="zg-btn" id="wk-pm">写私信</div>
					<h2>我的私信</h2>
				</div>
                <asp:Repeater runat="server" ID="rptMsg">
                    <ItemTemplate>
                        
                
                        <div id="wk-item" class="navigable">
					<div class="zm-pm-item">
						<a class="zm-item-link">
							<img class="zm-pm-item-img" src="<%#getHeaderImage(Eval("MessageSenderID"),Eval("MessageReceiverID")) %>"/>
						</a>
						<div class="zm-pm-item-main">
							<a class="pm-touser" ><%# getNickName(Eval("MessageSenderID"),Eval("MessageReceiverID")) %></a>
							：<%# getContent( Eval("MessageSenderID"),Eval("MessageReceiverID")) %></div>
						<div class="zg-gray zu-pm-item-meta">
							<span class="zg-gray zg-left">
								<%#getDatatime( Eval("MessageSenderID"),Eval("MessageReceiverID")) %>
							</span>
							<a href="MessageDetail.aspx?MsgsID=<%# Eval("MessageSenderID") %>" class="zg-link-litblue">共 <%#getMessageCount(Eval("MessageSenderID"),Eval("MessageReceiverID")) %> 条对话</a>
                            
							<span class="zg-bull">|</span>
							<a href="#" class="zg-link-litblue huifusixin" usernickname="<%#getchatNickName(Eval("MessageSenderID"),Eval("MessageReceiverID")) %>" userid="<%# Eval("MessageSenderID")%>">回复</a>
							<span class="zg-bull">|</span>
							<a href="#" class="zg-link-litblue">举报</a>
							<span class="zg-bull">|</span>
							<a href="#" class="zg-link-litblue">删除</a>
						</div>
					</div>
				</div>
                    </ItemTemplate>
                </asp:Repeater>
				<%--<div id="wk-item" class="navigable">
					<div class="zm-pm-item">
						<a class="zm-item-link">
							<img class="zm-pm-item-img" src="Images/touxiang.jpg"/>
						</a>
						<div class="zm-pm-item-main">
							<a class="pm-touser">朱祁钰</a>
							：而恶恶恶恶
						</div>
						<div class="zg-gray zu-pm-item-meta">
							<span class="zg-gray zg-left">
								10月9日 15:38
							</span>
							<a href="MessageDetail.aspx" class="zg-link-litblue">共 6 条对话</a>
							<span class="zg-bull">|</span>
							<a href="#" class="zg-link-litblue">回复</a>
							<span class="zg-bull">|</span>
							<a href="#" class="zg-link-litblue">举报</a>
							<span class="zg-bull">|</span>
							<a href="#" class="zg-link-litblue">删除</a>
						</div>
					</div>
				</div>--%>
			</div>
		</div>
		<div class="main-sidebar"></div>
		<div class="zg-clear"></div>
	</div>
	<div class="modal-dialog">
		<div class="modal-dialog-title modal-dialog-title-draggable">
			<span class="modal-dialog-title-text">发送私信>发送私信</span>
			<span class="modal-dialog-title-close"></span>
		</div>
		<div class="modal-dialog-content">
			<div class="zm-pm-wrap">
				<dl class="zm-form-table zm-form-table-medium">
					<dt class="zm-form-table-head zm-form-table-head-align-middle">
						<label class="zg-medium-gray">发给：</label>
					</dt>
					<dd class="zm-form-table-field">
						<div class="zm-pm-selector-wrap">
							<asp:TextBox ID="txtMessageReceive" runat="server" class="zg-form-text-input zm-pm-user-selector label-input-label" type="text" placeholder="搜索用户">
                                
                            </asp:TextBox>
                            <asp:TextBox runat="server" id="wkuserid" class="zm-wkuserid" type="text"></asp:TextBox>
						</div>
					</dd>
					<dt class="zm-form-table-head zm-form-table-head-align-middle">
						<label class="zg-medium-gray">内容：</label>
					</dt>
					<dd class="zm-form-table-field zm-form-table-field-last">
						<div class="zg-editor-simple-wrap zg-form-text-input">
							<asp:TextBox ID="txtMessageContent" runat="server" class="zg-editor-input zu-seamless-input-origin-element" style="font-weight: normal; white-space: pre; height: 66px; min-height: 66px; width:320px; border:none;outline:none; " TextMode="MultiLine"></asp:TextBox>
						</div>
					</dd>
				</dl>
				<div class="zm-command zg-clear">
					<a class="zm-command-cancel">取消</a>
					<asp:Button  runat="server"  class="zg-btn-blue zg-r3px" id="btnsendMessage" OnClick="sendMessage" Text="发送"/>
				</div>
                <div class="ac-renderer">
					<%--<div class="ac-row">
						<img class="zm-item-img-avatar zg-left" src="Images/sprites.png"/>
						<span class="zu-autocomplete-row-name">aaa</span>
						<span class="zg-gray-normal zu-autocomplete-row-description">呵呵</span>
					</div>
					<div class="ac-row">
						<img class="zm-item-img-avatar zg-left" src="Images/sprites.png"/>
						<span class="zu-autocomplete-row-name">nnn</span>
						<span class="zg-gray-normal zu-autocomplete-row-description">呵呵</span>
					</div>
					<div class="ac-row">
						<img class="zm-item-img-avatar zg-left" src="Images/sprites.png"/>
						<span class="zu-autocomplete-row-name">ddd</span>
						<span class="zg-gray-normal zu-autocomplete-row-description">呵呵</span>
					</div>--%>
				</div>
			</div>
		</div>
	</div>
	<div class="mengban"></div>

</asp:Content>
