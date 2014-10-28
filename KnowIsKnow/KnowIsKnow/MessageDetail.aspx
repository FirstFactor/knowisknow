<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="MessageDetail.aspx.cs" Inherits="KnowIsKnow.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/MessageDetail.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/messagedetail.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
	<div class="zg-wrap zu-main">
		<div class="zu-main-content">
			<div class="zu-main-content-inner" id="zh-pm-detail-page-wrap">
				<div class="zg-section">
					<a href="Message.aspx">« 返回</a>
				</div>
				<div class="zg-section zg-14px">
					<span class="zg-gray-normal">发私信给 </span>
					<span class="zg-gray-darker"><%=chatusername %></span>
					:
				</div>
				<div class="zg-section" id="zh-pm-editor-form">
					<div class="zg-editor-simple-wrap zg-form-text-input">
						<asp:TextBox runat="server" ID="chatSendContent" class="zg-editor-input zu-seamless-input-origin-element" style="font-weight: normal; white-space: pre; height: 66px; min-height: 66px;" TextMode="MultiLine"></asp:TextBox>
					</div>
					<div class="zm-command">
						<asp:Button runat="server" ID="chatSendMessage" name="send" class="zg-btn-blue zg-r3px" Text="发送" OnClick="chatSendMessage_Click1"></asp:Button>	
					</div>
				</div>
                <asp:Repeater runat="server" ID="repMsg">
                    <ItemTemplate>
                    <div id="zh-pm-detail-item-wrap" class="navigable">
					<div class="zm-pm-item">
						<a class="zm-item-link-avatar50">
							<img class="zm-item-img-avatar50" src="<%# Eval("userHeadImage") %>"/>
						</a>
						<div class="zm-pm-item-main">
							<a><%# Eval("userNickName") %></a>
							：<%# Eval("MessageContent") %></div>
						<div class="zg-gray zu-pm-item-meta clearfix">
							<span class="zg-gray zg-left"><%# Eval("MessageSendTime") %>
							</span>
							<a class="zg-link-litblue" >删除</a>
						</div>
					</div>
				
				</div>
                    </ItemTemplate>
                </asp:Repeater>
				<%--<div id="zh-pm-detail-item-wrap" class="navigable">
					<div class="zm-pm-item">
						<a class="zm-item-link-avatar50">
							<img class="zm-item-img-avatar50" src="Images/touxiang.jpg"/>
						</a>
						<div class="zm-pm-item-main">
							<a>朱祁钰</a>
							：而恶恶恶恶
						</div>
						<div class="zg-gray zu-pm-item-meta clearfix">
							<span class="zg-gray zg-left">10月9日 15:38
							</span>
							<a class="zg-link-litblue">回复</a>
							<span class="zg-bull">|</span>
							<a class="zg-link-litblue" >举报</a>
							<span class="zg-bull">|</span>
							<a class="zg-link-litblue" >删除</a>
						</div>
					</div>
					<div class="zm-pm-item">
						<a class="zm-item-link-avatar50">
							<img class="zm-item-img-avatar50" src="Images/touxiang.jpg">
						</a>
						<div class="zm-pm-item-main">
							<a>我</a>
							：而恶恶恶恶
						</div>
						<div class="zg-gray zu-pm-item-meta clearfix">
							<span class="zg-gray zg-left">10月9日 15:36
							</span>
							<a class="zg-link-litblue" >删除</a>
						</div>
					</div>
				</div>--%>
			</div>
		</div>
	</div>
</body>
</asp:Content>
