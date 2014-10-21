<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KnowIsKnow.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/Home.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/home.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <div class="zqq-jubao-inner">
            <div class="zqq-tiwen-menban-title">
                <div class="zqq-tiwen-menban-title-main">为什么举报这个问题？</div>
                <div class="zqq-tiwen-menban-close">X</div>
            </div>
            <div class="zqq-jubao-chose">
                <div class="zqq-jubao-chose-title">请选择理由</div>
                <ul class="zqq-jubao-chose-main">
                    <li class="zqq-jubao-chose-list">
                        <label>
                            <input class="zqq-jubao-checked1" value="1" mark="0" type="radio" />
                             广告等垃圾信息
                        </label>
                    </li>
                    <li class="zqq-jubao-chose-list">
                        <label>
                            <input class="zqq-jubao-checked2" value="2" mark="0" type="radio" />
                             不友善内容
                        </label>
                    </li>
                    <li class="zqq-jubao-chose-list">
                        <label>
                            <input class="zqq-jubao-checked3" value="3" mark="0" type="radio" />
                             违法违规内容
                        </label>
                    </li>
                    <li class="zqq-jubao-chose-list">
                        <label>
                            <input class="zqq-jubao-checked4" value="4" mark="0" type="radio" />
                             不宜公开讨论的政治内容
                        </label>
                    </li>
                    <li class="zqq-jubao-chose-list">
                        <label>
                             <input class="zqq-jubao-checked5" value="5" mark="0" type="radio" />
                             其他（可自行填写）
                        </label>
                        <input class="zqq-jubao-otherReason" type="text" placeholder="请填写原因" />
                    </li>
                </ul>
                <div class="zqq-jubao-submit">确定</div>
            </div>
        </div>
        
        <div class="zqq-main">
			<div class="zqq-mini-main">
				<div class="zqq-mm-R">
					<div class="zqq-mm-R-L">
						<div class="zqq-question-area">
						<div class="zqq-newQuestion"></div>

                        <asp:Repeater ID="rpt" runat="server">
                            <ItemTemplate>
                                <div class="zqq-small-question">
							<div class="zqq-head-photo">
								<img class="zqq-head-face" src="image/1.jpg"/>
							</div>
							<div class="zqq-question-detail">
								<div class="zqq-question-info"><%# Eval("questionProvider") %> 提出了问题</div>
								<div class="zqq-question-title">
									<%# Eval("questionTitle") %>
								</div>
								<div class="zqq-question-content">
									<div class="zqq-content-word"><%# Eval("questionContent") %></div>
									<img class="zqq-content-pic" src="" /> 
								</div>
								<div class="zqq-question-ft">
									<div class="zqq-follow-topic">
                                        <a class="zqq-follow-topic-button">关注话题</a>
                                        <a class="zqq-display zqq-noFollow-topic-button">取消关注</a>
									</div>
									<div class="zqq-jubao">举报</div>
								</div>
							</div>
							</div>
                            </ItemTemplate>
                        </asp:Repeater>
                           
                        
						<%--<div class="zqq-small-question">
							<div class="zqq-head-photo">
								<img class="zqq-head-face" src="image/1.jpg"/>
							</div>
							<div class="zqq-question-detail">
								<div class="zqq-question-info">pansz 提出了问题</div>
								<div class="zqq-question-title">
									有哪些功能和名称完全没有关系的东西？
								</div>
								<div class="zqq-question-content">
									<div class="zqq-content-word">比如蓝牙……</div>
									<img class="zqq-content-pic" src="" /> 
								</div>
								<div class="zqq-question-ft">
									<div class="zqq-follow-topic">
                                        <a class="zqq-follow-topic-button">关注话题</a>
                                        <a class="zqq-display zqq-noFollow-topic-button">取消关注</a>
									</div>
									<div class="zqq-jubao">举报</div>
								</div>
							</div>
							</div>--%>
						</div>
					</div>
					<div class="zqq-mm-R-R"></div>
				</div>
			</div>
		</div>
		<div class="zqq-footer"></div>
</asp:Content>
