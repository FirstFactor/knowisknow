<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="KnowIsKnow.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/QuestionDetail.css" rel="stylesheet" type="text/css"/>
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
					<h3 id="zh-question-answer-num">12 个回答</h3>
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
						<div class="answer-head">
							<div class="zm-item-answer-author-info">
								<h3 class="zm-item-answer-author-wrap">
									<a class="zm-item-link-avatar">
										<img src="Images/da8e974dc_s.jpg" class="zm-list-avatar">
									</a>
									<a>破晓</a>
									,
									<strong class="zu-question-my-bio"title="加钱党，加一党">加钱党，加一党</strong>
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
								我来自AMHC，即阿哈利姆魔法隐修议会的一员，当然现在已经基本退出RPG制作圈子了。自己的作品也停止更新了。
								楼上有人提到了DOTA2版的LOL，是X神试手做着玩的，据说老外那边比我们进度快很多，再后来的情况我也不晓得了。
								===================================================
								我认为，前期LOL的英雄会占据主动，理由有五：LOL打野比DOTA打野更容易成长，团队经验领先
								LOL的召唤师技能给予了英雄可进可退的可能性（闪现与虚弱、点燃之类）
								LOL符文增强强过DOTA出门属性装
								LOL相对DOTA蓝耗更低，技能消耗占上风
								LOL眼更为廉价，在视野控制和团队战略上占据主动
								但中后期DOTA英雄绝对可以反超，理由有五：
								LOL的技能很难克制BKB和林肯
								DOTA中带控制和限制的道具和技能强出太多（变羊3.5秒，随便一个眩晕技都在2秒上）
								DOTA阵容的缺陷一部分程度上可以通过道具弥补（发育-点金，推进-死灵书，爆发-大根，逃生-推推绿杖风杖，限制-大晕羊刀）
								DOTA阵容的发力点基本不在15分钟前，无论是推进还是gank还是冲脸还是发育，基本都需要几个核心的基础装备和等级起来才迎来强势期
								目前DOTA版本决定了DOTA的容错率比LOL高出太多，翻盘局屡屡皆是且有买活
								====================================================
							</div>
						</div>
						<div class="zm-item-meta zm-item-comment-el answer-actions clearfix">
							<div class="zm-meta-panel">
								<span class="answer-date-link-wrap">
									<a class="answer-date-link meta-item">发布于 2014-10-09</a>
								</span>
								<a class=" meta-item toggle-comment">
									<i class="z-icon-comment"></i>
									添加评论
								</a>
								<a class="meta-item zu-autohide">
									<i class="z-icon-thank"></i>
									感谢
								</a>
								<a class="meta-item zu-autohide">
									<i class="z-icon-share"></i>
									分享
								</a>
								<a class="meta-item zu-autohide">
									<i class="z-icon-collect"></i>
									感谢
								</a>
								<span class="zg-bull zu-autohide">•</span>
								<a class="meta-item zu-autohide">没有帮助</a>
								<span class="zg-bull zu-autohide">•</span>
								<a class="meta-item zu-autohide">举报</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div class="zu-main-sidebar"></div>
		<div class="zg-clear"></div>
	</div>

</asp:Content>
