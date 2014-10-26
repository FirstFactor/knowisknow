<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="CaredQuestion.aspx.cs" Inherits="KnowIsKnow.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Home.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/home.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="userid" userid="<%=userid_caredquestion %>"></div>
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

                                    <div class="zqq-goog-hovercard zqq-bottom">
						        		<div class="zqq-popover-content zqq-no-hovercard">
								          <div class="zqq-profile-card zqq-topic">
									    	<div class="zqq-upper">
										    	<a class="zqq-avatar-link" href="/topic/19577143">
												<span class="zqq-name">诺贝尔奖</span>
												<img class="zqq-avatar" src="images/07685ae24_m.jpg"/>
										    	</a>
											    <br/>
										    	<div class="zqq-tagline">诺贝尔奖是根据瑞典化学家阿尔弗雷德·诺贝尔的遗嘱所设立的奖项，以表彰那些对社会做出卓越贡…</div>
										    </div>
									    	<div class="zqq-lower zqq-clearfix">
										    	<div class="zqq-meta">
											    	<a class="zqq-item" target="_blank" href="/topic/19577143/questions">
												    	<span class="zqq-value">735</span>
											    		<span class="zqq-key">问题</span>
											    	</a>
											    	<a class="zqq-item" target="_blank" href="/topic/19577143/top-answers">
											    		<span class="zqq-value">241</span>
											    		<span class="zqq-key">精华</span>
										    		</a>
											    	<a class="zqq-item" target="_blank" href="/topic/19577143/followers">
											    		<span class="zqq-value">840</span>
										    			<span class="zqq-key">关注者</span>
										    		</a>
										    	</div>
											    <div class="zqq-operation">
											    	<button data-follow="t:button" data-id="8978" class="zqq-zg-btn zqq-zg-btn-follow zqq-zm-rich-follow-btn">关注</button>
										    	</div>
									    	</div>
									     </div>
							        	</div>
						        		<div class="zqq-arrow"></div>
						        		<div class="zqq-arrow2"></div>
						        	</div>
							    </div>
							    <div class="zqq-question-detail">
                                    <div class="zqq-question-hd">
                                        <div class="zqq-question-info "><%# Eval("userNickName") %> 提出了问题</div>
                                        <div class="zqq-question-pubTime "><%# Eval("quetionPubTime") %></div>
                                        <div class="clear"></div>
                                    </div>
							    	<%--<div id="zqq-questionTitle1" class="zqq-question-title" questionid="<%# Eval("questionID") %>"><%# Eval("questionTitle") %></div>--%>
                                    <a href='QuestionDetail.aspx?QuesID=<%# Eval("careQuestionID")%>' class="zqq-question-title" questionid='<%# Eval("careQuestionID") %>' ><%# Eval("questionTitle") %></a>
								    <div class="zqq-question-content">
									    <div class="zqq-content-word"><%# Eval("questionContent") %></div>
									    <img class="zqq-content-pic" src="" /> 
								    </div>
								    <div class="zqq-question-ft">
									    <div class="zqq-follow-topic">
                                            <a class="zqq-noFollow-topic-button"   questionid='<%# Eval("careQuestionID") %>'>取消关注</a>
                                           <%-- <a class="zqq-display zqq-noFollow-topic-button">取消关注</a>--%>
								    	</div>
								    	<div class="zqq-jubao" questionid='<%# Eval("careQuestionID") %>'>举报</div>
							    	</div>
							    </div>
							</div>
                            </ItemTemplate>
                            </asp:Repeater>
						</div>
					</div>
					<div class="zqq-main-R">
                        <div class="zqq-side zqq-lm1"></div>
                        <div class="zqq-side zqq-lm2">
                            <ul class="zqq-lm2-ul">
                                <li class="zqq-side-li zqq-side-li1">
                                    <a href="CaredQuestion.aspx" class="zqq-side-link">
                                        <i class="zqq-icon zqq-icon-caredQuestion"></i>
                                        我关注的问题
                                    </a>
                                </li>
                                <li class="zqq-side-li zqq-side-li4">
                                    <a href="MyQuestion.aspx" class="zqq-side-link">
                                        <i class="zqq-icon zqq-icon-myQuestion"></i>
                                        我提过的问题
                                    </a>
                                </li>
                                <li class="zqq-side-li zqq-side-li2">
                                    <a href="AllQuestion.aspx" class="zqq-side-link">
                                        <i class="zqq-icon zqq-icon-allQuestion"></i>
                                        所有问题
                                    </a>
                                </li>
                                <li class="zqq-side-li zqq-side-li3">
                                    <a href="TopicSquare.aspx" class="zqq-side-link">
                                        <i class="zqq-icon zqq-icon-topicSquare"></i>
                                        话题广场
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <div class="zqq-side zqq-lm3">
                            <div class="zqq-lm3-T">
                                <h3>常去话题</h3>
                                <a href="TopicSquare.aspx" class="zqq-offenTopic">查看全部 »</a>
                            </div>
                            <ul class="zqq-lm3-ul">
                                <li class="zqq-side-li zqq-side-li11">
                                    <a href="" class="zqq-side-link1">
                                        <img src="images/zqq-dianying.jpg" class="zqq-side-photo"/>
                                        <div class="zqq-side-lm3-a">电影</div>
                                    </a>
                                </li>
                                <li class="zqq-side-li zqq-side-li11">
                                    <a href="" class="zqq-side-link1">
                                        <img src="images/zqq-falv.jpg" class="zqq-side-photo"/>
                                        <div class="zqq-side-lm3-a">法律</div>
                                    </a>
                                </li>
                                <li class="zqq-side-li zqq-side-li11">
                                    <a href="" class="zqq-side-link1">
                                        <img src="images/zqq-yingyue.jpg" class="zqq-side-photo"/>
                                        <div class="zqq-side-lm3-a">音乐</div>
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <div class="zqq-side zqq-lm4">
                            <div class="zqq-lm3-T">
                                <h3>你可能感兴趣的人</h3>
                                <a href="TopicSquare.aspx" class="zqq-offenTopic">更多推荐 »</a>
                            </div>
                            <ul class="zqq-lm4-ul">
                                <li class="zqq-side-lm4-li">
                                    <img src="images/zqq-dianying.jpg" class="zqq-side-photo"/>
                                    <div class="zqq-famousUsers">
                                        <div class="zqq-famousUsers-hd">
                                            <div class="zqq-famousUsers-nickName">知为知官方</div>
                                            <div class="zqq-famousUsers-follow">关注</div>
                                        </div>
                                        <div class="zqq-famousUsers-shuoshuo">知为知官方团队，合作请私信。</div>
                                    </div>
                                </li>
                                <li class="zqq-side-lm4-li">
                                    <img src="images/zqq-dianying.jpg" class="zqq-side-photo"/>
                                    <div class="zqq-famousUsers">
                                        <div class="zqq-famousUsers-hd">
                                            <div class="zqq-famousUsers-nickName">王思聪</div>
                                            <div class="zqq-famousUsers-follow">关注</div>
                                        </div>
                                        <div class="zqq-famousUsers-shuoshuo">太有钱是我这辈子最大的痛苦..</div>
                                    </div>
                                </li>
                            </ul>
                        </div>
					</div>
				</div>
		<div class="zqq-footer"></div>
</asp:Content>
