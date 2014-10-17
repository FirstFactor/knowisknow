<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="KnowIsKnow.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/Setting.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script> 
    <script type="text/javascript" src="js/setting.js"></script>
    <title>知乎—设置</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

	<div id="setting-main">
		<div class="settingMainContent">
			<ul class="topnavs">
				<li class="topnav">
					<a class="topnava topnavActive tn1">账号</a>
				</li>
				<li class="topnav">
					<a class="topnava tn2">密码</a>
				</li>
				<li class="topnav">
					<a class="topnava tn3">消息</a>
				</li>
				<li class="topnav">
					<a class="topnava tn4">邮件</a>
				</li>
				<li class="topnav">
					<a class="topnava tn5">社区绑定</a>
				</li>
				<li class="topnav">
					<a class="topnava tn6">屏蔽</a>
				</li>
				<li class="topnav">
					<a class="topnava tn7">实验室</a>
				</li>
				<li class="topnav">
				</li>
				<li class="topnav">
				</li>
				<li class="topnav">
				</li>
				<li class="topnav">
				</li>

			</ul>


		<div class="mianform f1">
				<div class="settings-intro">
				修改你的帐户基本资料，登录信息和其他安全设置。
				</div>

				<div class="settings-section">
					<div class="settings-item clearfix">
						<label for="fullname" class="settings-item-title">姓名</label>
						<div class="settings-item-content rename-section" id="rename-section">
							<span class="name">文韬</span>


							<a class="zu-edit-button rename-button" name="edit"><i class="zu-edit-button-icon"></i>修改</a>





							<div class="rename-tab hidden">
								<p>
									<input class="zg-form-text-input half" type="text" name="lastname" placeholder="姓"/>
									<input class="zg-form-text-input half" type="text" name="firstname" placeholder="名"/>

								</p>
								<div class="note gray">提示：180 天只能修改一次</div>
							</div>

						</div>
					</div>
					<div class="settings-item clearfix">
						<label for="url_token" class="settings-item-title with-input">个性网址</label>
						<div class="settings-item-content">
						<input autocomplete="off" class="zg-form-text-input" name="url_token" id="url_token" value="wen-tao-6-49" required=""/>

						<div id="js-url-preview" class="url-preview">zhihu.com/people/<span class="token">wen-tao-6-49</span></div>
						</div>
					</div>
					<div class="settings-item clearfix">
						<label for="email" class="settings-item-title with-input">邮箱</label>
						<div class="settings-item-content">
							<input autocomplete="off" class="zg-form-text-input" type="email" name="email" id="email" value="135957091@163.com" required=""/>


							<div class="hidden email-confirm" id="js-email-confirm">
								<input autocomplete="off" class="zg-form-text-input" type="password" value="" name="password" id="password" placeholder="	当前密码"/>
							</div>


						</div>
					</div>
				<div class="settings-item clearfix">
					<label for="private" class="settings-item-title">隐私保护</label>
					<div class="settings-item-content">
						<div>


						<label class="settings-checkbox-label">
							<input type="checkbox" name="private" id="private"/> 在站外搜到我在知乎创作的内容时，我的姓名将不会被显示
						</label>
						</div>
						<div class="settings-item-content-desc">
							<a class="zg-link-litblue" href="//www.zhihu.com/question/20758264" target="_blank">什么情况下应该使用这个选项？</a>
						</div>
					</div>
				</div>
				<div class="settings-save">
					<button type="submit" class="zg-btn-blue">保存</button>
				</div>
			</div>
		</div>
        
		<div class="mianform f2 hidden">
			<div class="settings-intro">
				修改你的登录密码。
				</div>

			<div class="settings-section">

				<div class="settings-item clearfix">
					<label for="op" class="settings-item-title with-input">当前密码</label>
					<div class="settings-item-content">
						<input type="password" autocomplete="off" class="zg-form-text-input" name="op" id="op" placeholder="当前密码" required=""/>
					</div>
				</div>

				<div class="settings-item clearfix">
					<label for="np" class="settings-item-title with-input">新的密码</label>
					<div class="settings-item-content">
						<input data-rule-strongpassword="true" type="password" autocomplete="off" class="zg-form-text-input" name="np" id="np" placeholder="新的密码" required=""/>
					</div>
				</div>
				<div class="settings-item clearfix">
					<label for="rp" class="settings-item-title with-input">确认密码</label>
					<div class="settings-item-content">
						<input type="password" autocomplete="off" class="zg-form-text-input" name="rp" id="rp" placeholder="确认密码" required=""/>
					</div>
				</div>
				<div class="settings-save">
					<button type="submit" class="zg-btn-blue">保存</button>
				</div>
			</div>
				
			
		</div>	
		<div class="mianform f3 hidden">
			<div class="settings-intro">
				消息是在使用知乎的过程中，其他用户对你的操作产生的动态信息。这些信息会出现在页首导航栏的消息提示中。现在，你可以自定义接收哪些类型的消息。
			</div>

			<div class="settings-section1 noti">
				<div class="settings-section-title1">
					<h2>接收哪些消息</h2>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-content">
						<label class="settings-checkbox-label">
							<input checked="" type="checkbox" name="subscribe_member_follow" value="1"/> 有人关注我
						</label>
					</div>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-title1">
						有人邀请我回答问题时，邀请者为
					</div>
					<div class="settings-item-content">
						<label class="settings-radio-label">
							<input checked="" type="radio" name="subscribe_question_invite" value="3"/> 所有人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_question_invite" value="1"/> 我关注的人
						</label>
					</div>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-title1">
						有人赞同了我的答案，赞同者为
					</div>
					<div class="settings-item-content">
						<label class="settings-radio-label">
							<input checked="" type="radio" name="subscribe_answer_vote" value="3"/> 所有人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_answer_vote" value="1"/> 我关注的人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_answer_vote" value="0"/> 我不接受此类通知
						</label>
					</div>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-title1">
						有人感谢了我的答案，感谢者为
					</div>
					<div class="settings-item-content">
						<label class="settings-radio-label">
							<input checked="" type="radio" name="subscribe_answer_thank" value="3"/> 所有人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_answer_thank" value="1"/> 我关注的人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_answer_thank" value="0"/> 我不接受此类通知
						</label>
					</div>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-title1">
						有人赞了我的评论，这些人为
					</div>
					<div class="settings-item-content">
						<label class="settings-radio-label">
							<input checked="" type="radio" name="subscribe_comment_like" value="3"/> 所有人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_comment_like" value="1"/> 我关注的人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_comment_like" value="0"/> 我不接受此类通知
						</label>
					</div>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-title1">
						有人赞了我的专栏文章，这些人为
					</div>
					<div class="settings-item-content">
						<label class="settings-radio-label">
							<input checked="" type="radio" name="subscribe_column_article_vote" value="3"/> 所有人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_column_article_vote" value="1"/> 我关注的人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_column_article_vote" value="0"/> 我不接受此类通知
						</label>
					</div>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-title1">
						有人关注了我的专栏，这些人为
					</div>
					<div class="settings-item-content">
						<label class="settings-radio-label">
							<input checked="" type="radio" name="subscribe_column_follow" value="3"/> 所有人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_column_follow" value="1"/> 我关注的人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="subscribe_column_follow" value="0"/> 我不接受此类通知
						</label>
					</div>
				</div>
			</div>
			<div class="settings-section2 noti">
				<div class="settings-section-title1">
					<h2>谁可以给我发私信</h2>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-content">
						<label class="settings-radio-label">
							<input checked="" type="radio" name="recv_option" value="0"/> 所有人
						</label>
						<label class="settings-radio-label">
							<input type="radio" name="recv_option" value="1"/> 我关注的人
						</label>
					</div>
				</div>
			</div>
			<div class="settings-section3 noti">
				<div class="settings-section-title1">
					<h2>更快获知我关注问题的新回答</h2>
					<p class="settings-section-desc">
						<a class="zg-link-litblue" href="/question/20573655" target="_blank">选中这个会发生什么？</a>
					</p>
				</div>
				<div class="settings-item1 clearfix">
					<div class="settings-item-content">
						<label class="settings-checkbox-label gray">
							<input type="checkbox" name="subscribe_question_answered" value="1"/> 我接受所关注问题的全部新回答的通知，即便这些回答与问题的相关度可能不够高
						</label>
					</div>
				</div>
				<div class="settings-save1">
				<button type="submit" class="zg-btn-blue">保存</button>
			</div>
			</div>
			
		</div>	
		<div class="mianform f4 hidden">
				<div class="settings-section noti">
					<div class="settings-section-title">
						<h2>当有以下事情发生时，发邮件给我</h2>
					</div>
					<div class="settings-item1 clearfix">
						<div class="settings-item-content"><label class="settings-checkbox-label">
							<input id="action_153" name="action_153" type="checkbox" value="y"/> 有人关注了我
						</label></div>
					</div>

					<div class="settings-item1 clearfix">
						<div class="settings-item-content"><label class="settings-checkbox-label">
							<input checked="" id="action_61" name="action_61" type="checkbox" value="y"/> 有人邀请我回答一个问题
						</label></div>
					</div>

					<div class="settings-item1 clearfix">
						<div class="settings-item-content"><label class="settings-checkbox-label">
							<input checked="" id="action_251" name="action_251" type="checkbox" value="y"/> 有人向我发送私信
						</label></div>
					</div>
					<div class="settings-section-title">
						<h2>知乎每周精选</h2>
					</div>
					<div class="settings-item1 clearfix">
						<div class="settings-item-content">
							<label class="settings-checkbox-label">
								<input checked="" id="newsletter" name="newsletter" type="checkbox" value="y"/> 订阅知乎每周精选
							</label>
							<div class="settings-item-content-desc">
								你每周会收到一封根据你的兴趣精心定制的内容合集。
							</div>
						</div>
					</div>
					<div class="settings-section-title1 spec1">
						<h2>新品发布与活动信息</h2>
					</div>
					<div class="settings-item1 clearfix">
						<div class="settings-item-content">
							<label class="settings-checkbox-label">
								<input checked="" id="promotion" name="promotion" type="checkbox" value="y"/> 接收来自知乎的新产品发布、热点内容、活动信息等邮件
							</label>
						</div>
					</div>
				</div>
				<div class="settings-save2">
					<button type="submit" class="zg-btn-blue">保存</button>
				</div>

		</div>		
		<div class="mianform f5 hidden">
			<div class="settings-intro">
				绑定社区帐号后，你可以在知乎上找到你的好友，邀请好友加入知乎，以及把精彩问答分享到其他社区。
			</div>
			<div class="settings-section">
				<div class="settings-item">
					<div class="sina">
						<a href="" target="_blank">绑定新浪微博帐号</a>
					</div>
				</div>
				<div class="settings-item">
					<div class="qq">
						<a href="" target="_blank">绑定 QQ 帐号</a>
					</div>
				</div>

			</div>
		</div>	
    	<div class="mianform f6 hidden">
			<div id="zh-setting-page-black-list-wrap">
				<div class="settings-section4">
					<div class="settings-section-title">
						<h2>屏蔽话题设置</h2>
						<p class="settings-section-desc">
							在个人首页动态中屏蔽来自特定话题的内容
						</p>
					</div>
					<div class="settings-item clearfix">
						<div class="settings-item-content">
							<div id="zh-topic-block-editors" class="zm-tag-editor zg-section">
								<div class="zm-tag-editor-labels clearfix" style="display: none;"></div><div class="zm-tag-editor-editor"><div class="zg-section zg-clear"></div><div class="zg-section zm-tag-editor-command-buttons-wrap"><input class="zg-form-text-input zg-mr15 label-input-label" type="text" placeholder="搜索话题" title="搜索话题" aria-haspopup="true"><a class="zg-mr15 zg-btn-blue" href="#" name="add" style="display: none;">添加</a><a href="#" name="close" style="display: none;">完成</a></div><div class="zm-tag-editor-maxcount zg-section" style="display: none;"><span>最多只能为一个问题绑定 Infinity 个话题</span><a href="#" name="close">完成</a></div></div>
							</div>
						</div>
					</div>
				</div>
				<div class="settings-section4">
					<div class="settings-section-title">
						<h2>受限话题</h2>
						<p class="settings-section-desc">
							除非主动关注，来自以下话题和它们的部分子话题的内容不会出现在你的首页动态中。<br/>详情参见 <a class="zg-link-litblue" href="http://www.zhihu.com/question/20806546">知乎上的哪些内容需要主动关注才会出现在首页动态中？</a>
						</p>
					</div>
					<div class="settings-item clearfix">
						<div class="settings-item-content">
							<div id="zh-topic-block-editor" class="zm-tag-editor zg-section">

								<a href="/topic/19550887" class="zm-item-tag" data-tip="t$t$19550887">知乎社区</a>

								<a href="/topic/19805970" class="zm-item-tag" data-tip="t$t$19805970">成人内容</a>

								<a href="/topic/19651696" class="zm-item-tag" data-tip="t$t$19651696">个人咨询</a>

								<a href="/topic/19554151" class="zm-item-tag" data-tip="t$t$19554151">调查类问题</a>

								<a href="/topic/19554791" class="zm-item-tag" data-tip="t$t$19554791">感情</a>

							</div>
						</div>
					</div>
				</div>
				<div class="settings-section4" id="section-blocked-columns">
					<div class="settings-section-title">
						<h2>屏蔽专栏设置</h2>
						<p class="settings-section-desc">
							在个人首页动态中屏蔽来自特定专栏的内容
						</p>
					</div>
					<div class="settings-item clearfix">
						<div class="settings-item-content">
							<div>还没有被屏蔽的专栏</div>
						</div>
					</div>
				</div>
				<div class="settings-section3" id="section-blocked-users">
					<div class="settings-section-title">
						<h2>屏蔽用户设置</h2>
						<p class="settings-section-desc">
							在个人首页动态中屏蔽来自特定用户的内容
						</p>
					</div>
					<div class="settings-item clearfix">
						<div class="settings-item-content">

							<div>请在用户个人页面将其添加到屏蔽列表。</div>

						</div>
					</div>
				</div>
			</div>
		</div>	
		<div class="mianform f7 hidden">
			<div class="settings-section noti">
				<div class="settings-section-title">
					<h2>首页动态</h2>
				</div>
				<div class="settings-item clearfix">
					<div class="settings-item-content">
						<label class="settings-checkbox-label">
							<input type="checkbox" name="use_topstory" value="1"/> 开启新版首页动态体验
							<span style="color:#999">（可随时在设置页开启或者关闭。）</span>
						</label>
						<div class="settings-item-content-desc">
							<a class="zg-link-litblue" href="//www.zhihu.com/question/22008558" target="_blank">新首页动态包含哪些改进？</a>
						</div>
					</div>
				</div>
			</div>
			<div class="settings-save2">
				<button type="submit" class="zg-btn-blue">保存</button>
			</div>

		</div>		

		</div>
		
	</div>

</asp:Content>
