<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="ProCenter.aspx.cs" Inherits="KnowIsKnow.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="Stylesheet" href="js/uploadify.css" />

    <link href="css/ProCenter.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/swfobject.js"></script>
    <script type="text/javascript" src="js/jquery.uploadify.min.js"></script>
    <script type="text/javascript" src="js/procenter.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="mengban">
        
    </div>
    <div id="uploadArea">
        <div id="upAreaHeader"><div id="upAreaClose">X</div></div>
        <input type="file" name="uploadify" id="uploadify" />
        <a href="javascript:$('#uploadify').uploadifyUpload()" id="uploadbtn">上传</a>| <a href="javascript:$('#uploadify').uploadifyClearQueue()"> 取消上传</a>
        <div id="fileQueue"></div>
    </div>

    <div class="wtzg-wrap wtzu-main">
		<div class="wtzu-main-content-inner">
			<div class="wtzm-profile-header">
				<div class="wtzm-profile-header-main">
					<div class="wt-top">
						<div class="wtellipsis" uid="<%=userid %>">
							<span class="wtname"><%=nickname %></span>
							<span>,</span>
							<span id="wtqianming" title="爱好世间美好的一切"><%=shuoshuo %></span>
						</div>
					</div>
					<div class="wtclearfix">
						<div class="wtzm-profile-header-avatar-container">
							<img src="<%=headimg %>" class="wtzm-profile-header-img"/>
						</div>
						<div class="wtzm-profile-header-info">
							<div class="wtitems">
								<div class="wtit">
									<i class="wticon wticon-profile-location"></i>
									<span class="wtinfo-wrap">
										<span class="wtlocation"><a class="wtzg-link-litblue-normal">填写居住地</a></span>
										<span class="wtbusiness wthangye">
											<a class="wttopic-link">填写行业</a>
										</span>
										<span class="wtbusiness"><i class="wticon  wticon-male wticon-profile-male"></i></span>
										<a class="wtzu-edit-button wtzubtn"><i class="wtzu-edit-button-icon"></i><span class="wtedit-msg">修改</span></a>
									</span>
									<span class="wtedit-wrap">
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input" autocomplete="off"  placeholder="居住地" aria-label="居住地"/>
										</span>
										<div class="wtbusiness-selection">
											<select name="business" class="wtbusiness-selection2">
												<option value="">选择行业</option>
												<option value="高新科技">高新科技</option>
												<option value="互联网">&nbsp;&nbsp;&nbsp;互联网</option>
												<option value="电子商务">&nbsp;&nbsp;&nbsp;电子商务</option>
											</select>
										</div>
										<span class="wtzg-bull">|</span>
										<input type="radio" name="gender" value="1" checked="checked" class="male"/>
										男&nbsp;&nbsp;
										<input type="radio" name="gender" class="female"/>
										女
										<a href="javascript:;" class="wtzg-btn-blue wtbtnblue1" name="save">确定</a>

									</span>
								</div>
								<div class="wtitem wtempty wtit2">
									<i class="wticon wticon-profile-company"></i>
									<span class="wtinfo-empty-wrap wtinfo2 wtinfo21"><a class="wtzg-link-litblue-normal">填写工作信息</a></span>
                                    <span class="wtinfo-empty-wrap wtinfo2 wtbusiness wtinfo22"><a class="wtzg-link-litblue-normal">填写职位</a></span>
									<span class="wtedit-wrap2">
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input wtzg-form-text-input2" autocomplete="off" placeholder="公司或组织名称" aria-label="公司或组织名称"/>
										</span>
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input3 wtzg-form-text-input" autocomplete="off" placeholder="你的职位" aria-label="你的职位"/>
										</span>
										<a class="wtzg-btn-blue wtbtnblue2" name="save">确定</a>
									</span>
								</div>
								<div class="wtitem wtempty ">
									<i class="wticon wticon-profile-education"></i>
									<span class="wtinfo-empty-wrap wtinfo3 wtinfo31"><a class="wtzg-link-litblue-normal">填写教育信息</a></span>
                                    <span class="wtinfo-empty-wrap wtinfo3 wtbusiness wtinfo32"><a class="wtzg-link-litblue-normal">专业方向</a></span>
									<span class="wtedit-wrap3">
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input wtzg-form-text-input4" autocomplete="off"  placeholder="学校或教育机构" aria-label="学校或教育机构"/>
										</span>
										<span class="wttopic-input-wrap">
											<input class="wtzg-form-text-input wtzg-form-text-input5" autocomplete="off"  placeholder="专业方向" aria-label="专业方向"/>
										</span>
										<a  class="wtzg-btn-blue wtbtnblue3" name="save">确定</a>
									</span>
								</div>
								<a class="wtzm-profile-header-user-detail wtzg-link-litblue-normal">
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
											<textarea name="description" class="wtzm-editable-editor-input" style="white-space: pre;" value></textarea>
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
						<a class="wtzg-right wtzg-link-litblue-normal" id="wtbianjiwodeziliao">
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
							<img src="images/2a098f9db_s.jpg" class="wtpic"/>
							<span>NBA 总决赛</span>
						</a>
						<span class="wtweek">1周前</span> 
					</div>
					<div class="wtzm-profile-section-item wtzm-item">
						<span>关注了话题</span>
						<a>
							<img src="images/fb89e0ea3_s.jpg" class="wtpic"/>
							<span>游戏</span>
						</a>
						<span class="wtweek">1周前</span> 
					</div>
				</div>
			</div>


		</div>
		<div class="wtzu-main-content-inner2">
			<div class="wtzm-profile-mbox wtziliao">
				<div class="wtzm-profile-module wtzg-clear">
					<span class="wtzm-profile-progress-title">资料完善度</span>
					<span class="wtzm-profile-progress-bar">
						<span id="wtzm-profile-progress-anim">37%</span>
					</span>
				</div>
			</div>
			<div id="wtzm-profile-details-editform">
				<div class="wtzm-profile-details wtzm-profile-mbox">
					<div class="wtzm-profile-module wtzg-clear">
						<a class="wtzg-link-litblue2 wtzg-right" id="wtfanhuigerenzhuye">返回个人主页</a>
						<h2 class="wtzm-profile-mbox-title">
							<a>文韬</a>
							<span> » 编辑个人资料</span>
						</h2>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-avatar">
						<h3>头像</h3>	
						<div class="wtzm-profile-module-desc">
							<dl class="wtzm-form-table">
								<dt class="wtzm-form-table-head">
									<img class="wtzg-avatar-big" src="http://pic4.zhimg.com/da8e974dc_l.jpg"/>
								</dt>
								<dd class="wtzm-form-table-field">
									<a class="wtzg-btn-blue wtprofile-edit-avatar-btn">选择头像</a>
									<div class="wtprofile-edit-avatar-tip wtzg-gray">支持 JPG、PNG、GIF 格式，不要超过 2M 。</div>
								</dd>
							</dl>
						</div>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-gender">
						<h3>性别</h3>
						<div class="wtzm-profile-module-desc2">
							<label>
								<input type="radio" name="gender" value="1" checked="checked" class="male"/>
								男&nbsp;&nbsp;
							</label>
							<label>
								<input type="radio" name="gender" value="0" class="female"/>
								女
							</label>
										
						</div>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-weibo">
						<h3>社区绑定</h3>
						<div class="wtzm-profile-module-desc">
							<div class="wtzm-profile-edit-fieldset wtweibo-edit-wrap">
								<label>
								<input type="radio" name="gender" value="1" checked="checked" class="male"/>
								显示&nbsp;&nbsp;
								</label>
								<label>
								<input type="radio" name="gender" value="0" class="female"/>
								隐藏
								</label>
								<p class="wtdesc">你可以邀请好友加入知乎、回答问题，或把知乎上精彩问答分享到其他社区。</p>
							</div>
							<div class="wtsettings-item">
								<div class="wtzu-settings-sina-bind">
									<a>绑定新浪微博帐号</a>
								</div>
							</div>
							<div class="wtsettings-item">
								<div class="wtzu-settings-qqconn-bind">
									<a>绑定 QQ 帐号</a>
								</div>
							</div>
						</div>
					</div>
					<div class="wtzm-profile-module wtyijvhua">
						<h3>一句话介绍</h3>
						<div class="wtzm-profile-module-desc">
							<div class="wtzm-profile-edit-fieldset">
								<input class="wtzg-form-text-input" value="爱好世间美好的一切"/>
								<p class="wtdesc">例如：汽车制造 / 产品设计师 / 登山爱好者</p>
							</div>
						</div>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-desc">
						<h3>个人简介</h3>
						<div class="wtzm-profile-module-desc">
							<div class="wtzm-profile-edit-fieldset">
								<div class="wtzm-editable-editor-wrap">
									<div class="wtzm-editable-editor-outer">
										<div class="wtzg-form-text-input wtzg-form-text-inputse">
											<textarea id="wtzm-profile-edit-description" class="wtzm-editable-editor-input"></textarea>
										</div>
									</div>
									<p class="wtdesc">用一段话介绍你自己，会在你的个人页面显示</p>
								</div>
							</div>
						</div>
					</div>
					<div class="wtzm-profile-module wtsuozaihangye">
						<h3>所在行业</h3>
						<div class="wtzm-profile-module-desc">
							<div class="wtzm-profile-edit-fieldset">
								<div class="wtbusiness-selection">
									<select name="business">
										<option value="">选择行业</option>
										<option value="高新科技">高新科技</option>
										<option value="互联网">&nbsp;&nbsp;&nbsp;互联网</option>
										<option value="电子商务">&nbsp;&nbsp;&nbsp;电子商务</option>
									</select>
								</div>
								<p class="wtdesc">行业信息会显示在你的个人页面</p>
							</div>
						</div>
					</div>
					<div class="wtzm-profile-module wtjvzhudi2">
						<h3>居住地</h3>
						<div class="wtzm-profile-module-desc">
							<div class="wtzm-profile-edit-fieldset">
								<span class="wttopic-input-wrap">
									<input autocomplete="off" aria-haspopup="true" type="text" class="wttianjiajvzhudi wtzg-form-text-input" placeholder="添加居住地" aria-label="添加居住地"/>
								</span>
								<button class="wtzg-btn-blue">添加</button>
							</div>
						</div>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-career">
						<h3>职业经历</h3>
						<div class="wtzm-profile-module-desc">
							<div class="wtzm-profile-edit-fieldset">
								<p>
									<span class="wttopic-input-wrap">
										<input autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="公司或组织名称" aria-label="公司或组织名称"/>
									</span>
									<span class="wttopic-input-wrap wtzhiwei">
										<input autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="你的职位（选填）" aria-label="你的职位（选填）"/>
									</span>
									<button class="wtzg-btn-blue">添加</button>
								</p>

							</div>
						</div>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-career">
						<h3>教育经历</h3>
						<div class="wtzm-profile-module-desc">
							<div class="wtzm-profile-edit-fieldset">
								<p>
									<span class="wttopic-input-wrap">
										<input autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="学校或教育机构名" aria-label="学校或教育机构名"/>
									</span>
									<span class="wttopic-input-wrap wtzhiwei">
										<input autocomplete="off" aria-haspopup="true" type="text" class="wtzg-form-text-input wtgsname" placeholder="专业方向（选填）" aria-label="专业方向（选填）"/>
									</span>
									<button class="wtzg-btn-blue">添加</button>
								</p>

							</div>
						</div>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-gender">
						<h3>擅长话题</h3>
						<div class="wtzm-profile-module-desc2">
							<label>
								<input type="radio" name="gender" value="1" class="male"/>
								开启&nbsp;&nbsp;
							</label>
							<label>
								<input type="radio" name="gender" value="0" class="female" checked="checked" />
								关闭
							</label>
										
						</div>
					</div>
					<div class="wtzm-profile-module wtzm-profile-details-editform-footer">
						<p>
							<button class="wtzg-btn-blue">保存设置</button>
							<a class="wtzg-gray-normal">取消修改</a>
						</p>
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
						<img src="http://pic4.zhimg.com/fb89e0ea3_m.jpg" class="wtavatar2"/>
					</a>
				</div>
				<div class="wtzm-profile-side-topics">
					<a class="wtlink">
						<img src="http://pic1.zhimg.com/2a098f9db_m.jpg" class="wtavatar2"/>
					</a>
				</div>
			</div>
			<div class="wtzm-profile-side-section2">
				<div class="wtzm-side-section-inner">
					<span class="wtzg-gray-normal">
						个人主页被
						<strong>2</strong>
						人浏览
					</span>
				</div>
			</div>
			<div class="wtzh-footer">
				<div class="wtzg-wrap2">
					<ul>
						<li>
							<a href="#">知乎指南</a>
						</li>
						<li>
							<a href="#">建议反馈</a>
						</li>
						<li>
							<a href="#">移动应用</a>
						</li>
						<li>
							<a href="#">知乎阅读</a>
						</li>
						<br/>
						<li>
							<a href="#">加入知乎</a>
						</li>
						<li>
							<a href="#">知乎协议</a>
						</li>
						<li>
							<a href="#">商务合作</a>
						</li>
					</ul>
					<span class="wtcopy">© 2014 知乎</span>
				</div>
			</div>
			
		</div>
	</div>

</asp:Content>
