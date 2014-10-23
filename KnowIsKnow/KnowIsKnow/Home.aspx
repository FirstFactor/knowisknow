<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KnowIsKnow.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/Home.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/home.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        
        <div class="userid" userid="<%=userid %>"></div>
		<div class="zqq-main">
					<div class="zqq-main-L">
						<div class="zqq-question-area">
                            <div class="zqq-question-area-hd">
                                <i class="zqq-icon zqq-icon-questionList"></i>
                                最新动态
                                <a href="Setting.aspx" class="zqq-question-area-setting">
                                    <i class="zqq-icon zqq-icon-setting"></i>
                                    设置
                                </a>
                            </div>

						    <div class="zqq-newQuestion"></div>

                            <asp:Repeater ID="rpt" runat="server">
                            <ItemTemplate>
                                <div class="zqq-small-question">
							    <div class="zqq-head-photo">
								    <img class="zqq-head-face" src="<%# Eval("userHeadImage") %>" />
							    </div>
							    <div class="zqq-question-detail">
							    	<div class="zqq-question-info"><%# Eval("userNickName") %> 提出了问题</div>
							    	<%--<div id="zqq-questionTitle1" class="zqq-question-title" questionid="<%# Eval("questionID") %>"><%# Eval("questionTitle") %></div>--%>
                                    <a href='QuestionDetail.aspx?QuesID=<%# Eval("questionID")%>' class="zqq-question-title" questionid='<%# Eval("questionID") %>' ><%# Eval("questionTitle") %></a>
								    <div class="zqq-question-content">
									    <div class="zqq-content-word"><%# Eval("questionContent") %></div>
									    <img class="zqq-content-pic" src="" /> 
								    </div>
								    <div class="zqq-question-ft">
									    <div class="zqq-follow-topic">
                                            <a class="zqq-follow-topic-button">关注问题</a>
                                            <a class="zqq-display zqq-noFollow-topic-button">取消关注</a>
								    	</div>
								    	<div class="zqq-jubao" questionid='<%# Eval("questionID") %>'>举报</div>
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
					<div class="zqq-main-R">
                        <div class="zqq-side zqq-lm1"></div>
                        <div class="zqq-side zqq-lm2">
                            <ul class="zqq-lm2-ul">
                                <li class="zqq-side-li">
                                    <a href="TopicSquare.aspx" class="zqq-side-link">
                                        <i class="zqq-icon zqq-icon-topicSquare"></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
					</div>
				</div>
		<div class="zqq-footer"></div>
</asp:Content>
