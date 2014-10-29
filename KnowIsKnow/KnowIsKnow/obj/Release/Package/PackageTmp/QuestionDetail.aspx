<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="KnowIsKnow.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/QuestionDetail.css" rel="stylesheet" type="text/css"/>
    <!--全峻佚修改_Umditor-->

   

    <%--<script src="umeditor/umeditor.config.js"></script>
    <script src="umeditor/umeditor.js"></script>
    <link href="umeditor/themes/default/css/umeditor.css" rel="stylesheet" />--%>

    <!--全峻佚修改_Umditor-->

    <script type="text/javascript" src="js/questiondetail.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
	<div class="zg-wrap zu-main question-page">
		<div class="zu-main-content">
			<div class="zu-main-content-inner with-indention-votebar">
                
				<div class="zm-tag-editor zg-section">
					<div class="zm-tag-editor-labels zg-clear">
                        <asp:Repeater runat="server" ID="rptQttip">
                    <ItemTemplate>
						<asp:Label ID="wkquestiont" runat="server" class="zm-item-tag"><%# GetTopicTittle(Eval("quesrionTTID"),Eval("topicTID")) %></asp:Label>
					</ItemTemplate>
                </asp:Repeater>
                        </div>
				</div>
                    
				<div id="zh-question-title" class="zm-editable-status-normal">
					<h2 class="zm-item-title zm-editable-content"><%=questitle %></h2>
				</div>
				<div id="zh-question-detail" class="zm-item-rich-text zm-editable-status-normal">
					<div class="zm-editable-content">
						<%=quescontent %>
					</div>
				</div>

				<div class="zm-item-meta zm-item-comment-el clearfix" id="zh-question-meta-wrap">
					<div class="zm-meta-panel">
						<a href="#" name="share" class="share meta-item">
							<i class="z-icon-share">
								
							</i>
							分享
						</a>
						<span class="zg-bull">•</span>
						<a href="#" name="invite" class="meta-item">邀请回答</a>
						<a href="#" name="report-question" class="report zg-right">
							<i class="z-icon-no-help"></i>
							举报
							</a>
					</div>
				</div>
				<div class="zh-answers-title clearfix">
					<div id="zh-answers-filter" class="answers-sorter">
						<span class="lbl">按票数排序</span>
						<a class="lbl">按时间排序</a>
						<i class="zg-icon zg-icon-double-arrow"></i>
					</div>
					<h3 id="zh-question-answer-num"><%=wkcount %> 个回答</h3>
				</div>
				<div id="zh-question-answer-wrap" class="zh-question-answer-wrapper navigable">
					<div class="zm-item-answer ">
						<div class="zm-votebar goog-scrollfloater">
							<button class="up" title="赞同">
								<i class="icon vote-arrow"></i>
								<span class="label">赞同</span>
								<span class="count">3</span>
							</button>
							<button class="down" title="反对，不会显示你的姓名">
								<i class="icon vote-arroe"></i>
							</button>
						</div>
                         <asp:Repeater runat="server" ID="wkrtpReply">
                    <ItemTemplate>
                        <div class="answer-main">
						<div class="answer-head">
							<div class="zm-item-answer-author-info">
								<h3 class="zm-item-answer-author-wrap">
									<div class="zm-item-link-avatar">
										<img src="<%#Eval("userHeadImage") %>" class="zm-list-avatar"/>
                                        <div class="zqq-goog-hovercard zqq-bottom">
						        		<div class="zqq-popover-content zqq-no-hovercard">
								          <div class="zqq-profile-card zqq-topic">
									    	<div class="zqq-upper">
										    	<a class="zqq-avatar-link" href="/topic/19577143">
												<span class="zqq-name"><%# Eval("userNickName") %></span>
												<img class="zqq-avatar" src="<%# Eval("userHeadImage") %>"/>
										    	</a>
											    <br/>
										    	<div class="zqq-tagline"><%# Eval("userShuoShuo") %></div>
										    </div>
									    	<div class="zqq-lower zqq-clearfix">
											    <div class="zqq-operation">
                                                    
											    	<button class="zqq-zg-btn-follow" checkcareperson="<%# CheckCarePerson(Eval("replyofUID")) %>"  questionprovider="<%#Eval("replyofUID") %>">关注</button>
                                                    <div class="zqq-messageButtonArea" userid="<%# Eval("replyofUID") %>" usernickname="<%# Eval("userNickName") %>">
                                                        <i class="zqq-icon zqq-messageButton"></i>
                                                    </div>
										    	</div>
									    	</div>
									     </div>
							        	</div>
						        		<div class="zqq-arrow"></div>
						        		<div class="zqq-arrow2"></div>
						        	</div>
									</div>
									<a><%# GetreplyName(Eval("replyofUID")) %></a>
									
									<strong class="zu-question-my-bio"title="加钱党，加一党"><%# Eval("userShuoShuo") %></strong>
								</h3>
                                
							</div>
							<div class="zm-item-vote-info ">
								<span class="voters">
									<a class="zg-link">刀二</a>
									、
									<a class="zg-link">潘彬</a>
									、
									<a class="zg-link">阿呆阿瓜</a>
								</span>
								<span>赞同</span>
							</div>
						</div>
                       
						<div class="zm-item-rich-text">
							<div class=" zm-editable-content clearfix">
								<%# Eval("replyContent") %>
							</div>
						</div>
						<div class="zm-item-meta zm-item-comment-el answer-actions clearfix">
							<div class="zm-meta-panel">
								<span class="answer-date-link-wrap">
									<a class="answer-date-link meta-item">发布于<%= datatime %></a>
								</span>
								<a class=" meta-item toggle-comment" IsOpen="1" wkreplyid="<%# Eval("replyofUID") %>" wkreplyofreplyid="<%#Eval("ReplyID")%>" nextclass="ll<%#Eval("ReplyID") %>" quesid="<%=quesid %>>
									<i class="z-icon-comment"></i>
									添加评论
								</a>
								
								<span class="zg-bull zu-autohide">•</span>
								<a class="meta-item zu-autohide zqq-jubao" checkreplyofuid="<%# checkreplyofuid(Eval("ReplyID")) %>" wkreplyid="<%# Eval("replyofUID") %>" wkreplyofreplyid="<%#Eval("ReplyID")%>">举报</a>
							</div>
                            <div class="zm-comment-box empty">
                                <i class="icon icon-spike zm-comment-bubble"></i>
                                <a class="zg-anchor-hidden"></a>
                                <div class="zm-comment-list LL<%# Eval("ReplyID") %>>">
                                   <%-- <div class="zm-item-comment">
                                        <a class="zm-item-link-avatar">
                                            <img src="#" />
                                        </a>
                                        <div class="zm-comment-content-wrap">
                                            <div class="zm-comment-hd">
                                                <a class="zg-link">董君</a>
                                            </div>
                                            <div class="zm-comment-content">
                                                AP估计需要比较好的逃生手段了
                                            </div>
                                            <div class="zm-comment-ft">
                                                <span class="date">2014-10-11</span>
                                                <a class="reply zm-comment-op-link">
                                                    <i class="zg-icon zg-icon-comment-reply"></i>
                                                    回复
                                                </a>
                                                <a class="like zm-comment-op-link ">
                                                    <i class="zg-icon zg-icon-comment-like"></i>
                                                    赞
                                                </a>
                                                <a class="report zm-comment-op-link needsfocus">
                                                    <i class="zg-icon z-icon-no-help"></i>
                                                    举报
                                                </a>
                                            </div>
                                        </div>
                                    </div>--%>
                                </div>
                                <div class="zm-comment-form zm-comment-box-ft expanded ">
                                    <input class="zm-comment-editable editable" />
                                    <div class="zm-command zg-clear">
                                        <div class="zg-right zg-btn-blue wkpinglun" wkreplyid="<%# Eval("replyofUID") %>" wkreplyofreplyid="<%#Eval("ReplyID")%>" quesid="<%=quesid %>" >评论</div>
                                        <a class="zm-command-cancel">取消</a>
                                    </div>
                                </div>
                            </div>
						</div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
					</div>
				</div>
			</div>
		</div>
		<div class="zu-main-sidebar">
           
		</div>
		<div class="zg-clear"></div>
        <div class="wkreplyint" id="mao">
            <!--全峻佚修改_ueditor添加回答-->
            <div id="container"  class="zm-editable-editor-field-element editable" ></div>
            <input type="button" id="wkreply"  class="submit-button zg-btn-blue" name="name" quesid="<%=quesid %>"   value="添加回答 " />
            <!--全峻佚修改_ueditor添加回答-->
        </div>
	</div>
   
    <div id="getuserid" uid="<%=userid %>"></div>

</asp:Content>
