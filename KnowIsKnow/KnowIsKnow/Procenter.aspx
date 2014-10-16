<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="ProCenter.aspx.cs" Inherits="KnowIsKnow.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/ProCenter.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/procenter.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wttop">
		<div id="wtzh-top-inner" class="wtzg-wrap">
			<a href="/" class="wtzu-top-link-logo" id="wtzh-top-link-logo">知乎</a>
			<div id="wtwho">
				<img src="http://pic1.zhimg.com/da8e974dc_s.jpg" class="wtavatar"/>
				<div id="wtname"><span>文韬</span></div>
			</div>
			<div role="search" id="wtzh-top-search" class="wtzu-top-search">
				<div id="wtzh-top-search-form" class="wtzu-top-search-form wtform-with-magnify">
					<input type="text" class="wtzu-top-search-input" id="q" name="q" autocomplete="off"  placeholder="搜索话题、问题或人..."/>
					<button type="submit" class="wtmagnify-button">
						<i class="wticon wticon-magnify-q"></i>
					</button>
				</div>
				<button class="wtzu-top-add-question" id="wtzu-top-add-question">提问</button>
			</div>
			<div id="wtzg-top-nav" class="wtzu-top-nav">
				<ul class="wtzu-top-nav-ul wtzg-clear">
					<li class="wtzu-top-nav-li" id="wtzh-top-home-link">
						<a href="/" class="wtzu-top-nav-link" id="wtzh-top-link-home">首页</a>
					</li>
					<li class="wttop-nav-topic-selector wtzu-top-nav-li" id="wtzh-top-nav-item-topic">
						<a href="/topic" class="wtzu-top-nav-link" id="wttop-nav-dd-topic">话题</a>
					</li>
					<li class="wtzu-top-nav-li">
						<a href="/explore" class="wtzu-top-nav-link">发现</a>
					</li>
					<li class="wttop-nav-noti wtzu-top-nav-li ">
						<a href="javascript" class="wtzu-top-nav-link" id="wtzh-top-nav-count-wrap" role="button" >
							<span class="wtmobi-arrow"></span>
							消息

						</a>
					</li>
					
				</ul>
			</div>
		</div>
	</div>
	<div class="wtzg-wrap wtzu-main">
		<div class="wtzu-main-content-inner">
			<div class="wtzm-profile-header">
				<div class="wtzm-profile-header-main">
					<div class="wt-top">
						<div class="wtellipsis">
							<span class="wtname">文韬</span>
							<span>,</span>
							<span id="wtqianming" title="爱好世间美好的一切">爱好世间美好的一切</span>
						</div>
					</div>
					<div class="wtclearfix">
						<div class="wtzm-profile-header-avatar-container">
							<img src="http://pic2.zhimg.com/da8e974dc_l.jpg" class="wtzm-profile-header-img"/>
						</div>
						<div class="wtzm-profile-header-info">
							<div class="wtitems">
								<div class="wtitem wtit">
									<i class="wticon wticon-profile-location"></i>
									<span class="wtinfo-wrap">
										<span class="wtlocation"><a class="wtzg-link-litblue-normal">填写居住地</a></span>
										<span class="wtbusiness">
											<a href="/topic/19619368" class="wttopic-link">计算机软件</a>
										</span>
										<span class="wtbusiness"><i class="wticon wticon-profile-male"></i></span>
										<a class="wtzu-edit-button wtzubtn"><i class="wtzu-edit-button-icon"></i><span class="wtedit-msg">修改</span></a>
									</span>
									<span class="wtedit-wrap">
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input" autocomplete="off"  placeholder="居住地" aria-label="居住地"/>
										</span>
										<div class="wtbusiness-selection">
											<select name="business">
												<option value="">选择行业</option>
												<option value="高新科技">高新科技</option>
												<option value="互联网">&nbsp;&nbsp;&nbsp;互联网</option>
												<option value="电子商务">&nbsp;&nbsp;&nbsp;电子商务</option>
											</select>
										</div>
										<span class="wtzg-bull">|</span>
										<input type="radio" name="gender" value="1" checked="checked" class="male"/>
										男&nbsp;&nbsp;
										<input type="radio" name="gender" value="0" class="female"/>
										女
										<a href="javascript:;" class="wtzg-btn-blue wtbtnblue1" name="save">确定</a>

									</span>
								</div>
								<div class="wtitem wtempty wtit2">
									<i class="wticon wticon-profile-company"></i>
									<span class="wtinfo-empty-wrap wtinfo2"><a class="wtzg-link-litblue-normal">填写工作信息</a></span>
									<span class="wtedit-wrap2">
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input" autocomplete="off"  placeholder="公司或组织名称" aria-label="公司或组织名称"/>
										</span>
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input" autocomplete="off"  placeholder="你的职位" aria-label="你的职位"/>
										</span>
										<a class="wtzg-btn-blue wtbtnblue2" name="save">确定</a>
									</span>
								</div>
								<div class="wtitem wtempty ">
									<i class="wticon wticon-profile-education"></i>
									<span class="wtinfo-empty-wrap wtinfo3"><a class="wtzg-link-litblue-normal">填写教育信息</a></span>
									<span class="wtedit-wrap3">
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input" autocomplete="off" placeholder="学校或教育机构" aria-label="学校或教育机构"/>
										</span>
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input" autocomplete="off" placeholder="专业方向" aria-label="专业方向"/>
										</span>
										<a  class="wtzg-btn-blue wtbtnblue3" name="save">确定</a>
									</span>
								</div>
								<a class="wtzm-profile-header-user-detail wtzg-link-litblue-normal">
									<i class="wtzm-profile-header-icon wticon"></i>
									<span>查看详细资料</span>
								</a>
							</div>
							<div class="wtzm-profile-header-description">
								<span class="wtinfo-empty-wrap wtgerenjianjie">
									<a name="edit" class="wtzg-link-litblue-normal">
										<i class="wtzg-icon wtzg-icon-edit-button-blue wticon"></i>
										<span>填写个人简介</span>
									</a>
								</span>
								<span class="wtedit-wrap4">
									<div class="wtzm-editable-editor-outer">
										<div class="wtzm-editable-editor-inner wtzg-form-text-input">
											<textarea name="description" class="wtzm-editable-editor-input" style="white-space: pre;" ></textarea>
										</div>
									</div>
									<a class="wtzg-btn-blue wtbtnblue" name="save">确定</a>
								</span>
							</div>
						</div>
						<br style="clear:both;"/>
					</div>
				</div>
				<div class="wtzm-profile-header-operation wtzg-clear">
					<div class="wtzm-profile-header-info-list">
						<span class="wtzm-profile-header-info-title">获得</span>
						<span class="wtzm-profile-header-user-agree">
							<span class="wtzm-profile-header-icon2 wticon"></span>
							<strong class="wthuodezan">0</strong>
							<span>赞同</span>
						</span>
						<span class="wtzm-profile-header-user-agree">
							<span class="wtzm-profile-header-icon3 wticon"></span>
							<strong class="wthuodeganxie">0</strong>
							<span>感谢</span>
						</span>
						<a class="wtzg-right wtzg-link-litblue-normal">
						<i class="wtzg-icon-edit-button-blue wticon"></i>
						<span>编辑我的资料</span>
					</a>
					</div>
					
				</div>
				<div class="wtprofile-navbar">
					<a class="wtitemm  wtactive">
						<i class="wticon wticon-profile-tab-home"></i>
					</a>
					<a class="wtitemm">
						<span>提问</span>
						<span class="wtnum">0</span>
					</a>
					<a class="wtitemm">
						<span>回答</span>
						<span class="wtnum">0</span>
					</a>
					<a class="wtitemm">
						<span>专栏文章</span>
						<span class="wtnum">0</span>
					</a>
					<a class="wtitemm">
						<span>收藏</span>
						<span class="wtnum">0</span>
					</a>
					<a class="wtitemm">
						<span>公共编辑</span>
						<span class="wtnum">0</span>
					</a>

				</div>
			</div>
			<div class="wtzm-profile-section-wrap">
				<div class="wtzm-profile-section-head">
					<h2 class="wtzm-profile-section-title">最新动态</h2>
				</div>
				<div id="wtzh-profile-activity-page-list">
					<div class="wtzm-profile-section-item wtzm-item">
						<span>关注了话题</span>
						<a>
							<img src="http://pic3.zhimg.com/2a098f9db_s.jpg" class="wtpic"/>
							<span>NBA 总决赛</span>
						</a>
						<span class="wtweek">1周前</span> 
					</div>
					<div class="wtzm-profile-section-item wtzm-item">
						<span>关注了话题</span>
						<a>
							<img src="http://pic4.zhimg.com/fb89e0ea3_s.jpg" class="wtpic"/>
							<span>游戏</span>
						</a>
						<span class="wtweek">1周前</span> 
					</div>
				</div>
			</div>
		</div>
		<div class="wtzu-main-sidebar">
			<div class="wtzm-profile-side-following wtzg-clear">
				<a class="wtfoitem">
					<span class="wtzg-gray-normal">关注了</span>
					<br/>
					<strong>0</strong>
					<label>人</label>
				</a>
				<a class="wtfoitem wtleftborder">
					<span class="wtzg-gray-normal">关注了</span>
					<br/>
					<strong>0</strong>
					<label>人</label>
				</a>
			</div>
			<div class="wtzm-profile-side-section">
				<div class="wtzm-profile-side-section-title">
					<span>关注了</span>
					<a class="wtzg-link-litblue">
						<span>2 个话题</span>
					</a>
				</div>
				<div class="wtzm-profile-side-topics">
					<a class="wtlink">
						<img src="images/fb89e0ea3_m.jpg" class="wtavatar2"/>
					</a>
				</div>
				<div class="wtzm-profile-side-topics">
					<a class="wtlink">
						<img src="images/2a098f9db_m.jpg" class="wtavatar2"/>
					</a>
				</div>
			</div>
			<div class="wtzm-profile-side-section2"></div>
			
		</div>
	</div>
</asp:Content>
