<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="KnowIsKnow.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/TopicSquare.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/topicsquare.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ymid"><%=userID %></div>
	<div class="zg-wrap zu-main">
		<div class="zu-main-cotent-inner">
			<div class="zm-topic-cat-page">
				<div class="zm-topic-cat-title">
					<h2>
						<i class="zg-icon zg-icon-topic-square"></i>
						话题广场
					</h2>
				</div>
				<ul class="zm-topic-cat-main clearfix">
					<li data-id="1538" class="current">
						<a href="#体育">体育</a>
					</li>
					<li data-id="1027">
						<a href="#自然科学">自然科学</a>
					</li>
					<li data-id="520">
						<a href="#苹果公司 (Apple Inc.)">苹果公司 (Apple Inc.)</a>
					</li>
					<li data-id="395">
						<a href="#投资">投资</a>
					</li>
					<li data-id="658">
						<a href="#健身">健身</a>
					</li>
					<li data-id="17686">
						<a href="#Android">Android</a>
					</li>
					<li data-id="6058">
						<a href="#人文">人文</a>
					</li>
					<li data-id="307">
						<a href="#生活">生活</a>
					</li>
					<li data-id="570">
						<a href="#汽车">汽车</a>
					</li>
					<li data-id="445">
						<a href="#设计">设计</a>
					</li>
					<li data-id="2955">
						<a href="#足球">足球</a>
					</li>
					<li data-id="68">
						<a href="#电影">电影</a>
					</li>
					<li data-id="75">
						<a href="#音乐">音乐</a>
					</li>
					<li data-id="1740">
						<a href="#商业">商业</a>
					</li>
					<li data-id="2253">
						<a href="#物理学">物理学</a>
					</li>
					<li data-id="595">
						<a href="#iOS 应用">iOS 应用</a>
					</li>
					<li data-id="215">
						<a href="#法律">法律</a>
					</li>
					<li data-id="19800">
						<a href="#金融">金融</a>
					</li>
					<li data-id="186">
						<a href="#电子商务">电子商务</a>
					</li>
					<li data-id="2143">
						<a href="#科技">科技</a>
					</li>
					<li data-id="99">
						<a href="#互联网">互联网</a>
					</li>
					<li data-id="4196">
						<a href="#篮球">篮球</a>
					</li>
					<li data-id="237">
						<a href="#健康">健康</a>
					</li>
					<li data-id="112">
						<a href="#创业">创业</a>
					</li>
					<li data-id="8437">
						<a href="#生物学">生物学</a>
					</li>
					<li data-id="4217">
						<a href="#化学">化学</a>
					</li>
					<li data-id="3324">
						<a href="#经济学">经济学</a>
					</li>
					<li data-id="253">
						<a href="#游戏">游戏</a>
					</li>
				</ul>
				<div class="zm-topic-cat-sub">
					<div class="zh-general-list clearfix">
						
                        <asp:DataList runat="server" ID="rptquestionlist" RepeatColumns="2" RepeatDirection="Horizontal" RepeatLayout="Table">                       

                                <ItemTemplate>
                                    
                                    <div class="item">
                                        
							            <div class="blk">
								            <a target="_blank" href="/topic/19554827">
									            <img src="<%# Eval("topicPicUrl") %>"/>
									            <strong><%# Eval("topicTitle") %></strong>
								            </a>
								            <p><%# Eval("topicDes") %></p>
								            <a href="javascript:;" class="follow meta-item zg-follow" teshu="<%# Check(Eval("topicID")) %>" thid="<%#Eval("topicID") %>"><i class="z-icon-follow"></i>关注</a>
                                                                          
							            </div>
						            </div>
                                </ItemTemplate>
                        </asp:DataList>
						<a class="zg-btn-white zu-button-more">
							<span> 更多</span>
						</a>
						<a href="javascript:;" id="zh-load-more" data-method="next" class="zg-btn-white zg-r3px zu-button-more" style="display:none">更多</a>
					</div>
				</div>
			</div>
		</div>
		<div class="zu-main-sidebar">
			<div class="zm-side-section explore-side-section">
				<div class="zm-side-section-inner">
					<div class="section-title">
						<h3>热门话题</h3>
					</div>
					<ul class="list hot-topics">
						<li class="clearfix first">
							<a target="_blank" class="avatar-link" href="/topic/19592999" data-tip="t$b$19592999">
								<img src="images/eedf96dcb_m.jpg" alt="瑞典银行经济学奖" class="avatar 40"/>
							</a>
							<div class="content">
								<a href="/topic/19592999" target="_blank" data-tip="t$b$19592999">瑞典银行经济学奖</a>
								<div class="meta">
									<span>2574 人关注</span>
								</div>
							</div>
							<div class="bottom">
								<a class="question_link" target="_blank" href="/question/26014071">2014 年诺贝尔经济学奖得主 Jean Tirole 对于经济学的发展做出哪些贡献？</a>
							</div>
							
								<div id="first" class="goog-hovercard popover bottom">
									<div class="popover-content no-hovercard">
										<div class="zh-profile-card topic">
											<div class="upper">
												<a class="avatar-link" href="/topic/19592999">
													<span class="name">瑞典银行经济学奖</span>
													<img class="avatar" src="images/eedf96dcb_m.jpg"/>
												</a>
												<br/>
												<div class="tagline">瑞典国家银行纪念阿尔弗雷德·诺贝尔经济学奖（瑞典语：Sveriges riksbanks pris i ekonomisk …</div>
											</div>
											<div class="lower clearfix">
												<div class="meta">
													<a class="item" target="_blank" href="/topic/19592999/questions">
														<span class="value">96</span>
														<span class="key">问题</span>
													</a>
													<a class="item" target="_blank" href="/topic/19592999/top-answers">
														<span class="value">35</span>
														<span class="key">精华</span>
													</a>
													<a class="item" target="_blank" href="/topic/19592999/followers">
														<span class="value">2576</span>
														<span class="key">关注者</span>
													</a>
												</div>
												<div class="operation">
													<button data-follow="t:button" data-id="14255" class="zg-btn zg-btn-follow zm-rich-follow-btn">关注</button>
												</div>
											</div>
										</div>
									</div>
									<div class="arrow"></div>
									<div class="arrow2"></div>
								</div>	
						</li>
						<li class="clearfix second">
							<a target="_blank" class="avatar-link" href="/topic/19577143" data-tip="t$b$19577143">
								<img src="images/07685ae24_m.jpg" alt="诺贝尔奖" class="avatar 40"/>
							</a>
							<div class="content">
								<a href="/topic/19577143" target="_blank" data-tip="t$b$19577143">诺贝尔奖</a>
								<div class="meta">
									<span>802 人关注</span>
								</div>
							</div>
							<div class="bottom">
								<a class="question_link" target="_blank" href="/question/26014071">2014 年诺贝尔经济学奖得主 Jean Tirole 对于经济学的发展做出哪些贡献？</a>
							</div>
							<div id="second" class="goog-hovercard popover bottom">
								<div class="popover-content no-hovercard">
									<div class="zh-profile-card topic">
										<div class="upper">
											<a class="avatar-link" href="/topic/19577143">
												<span class="name">诺贝尔奖</span>
												<img class="avatar" src="images/07685ae24_m.jpg"/>
											</a>
											<br/>
											<div class="tagline">诺贝尔奖是根据瑞典化学家阿尔弗雷德·诺贝尔的遗嘱所设立的奖项，以表彰那些对社会做出卓越贡…</div>
										</div>
										<div class="lower clearfix">
											<div class="meta">
												<a class="item" target="_blank" href="/topic/19577143/questions">
													<span class="value">735</span>
													<span class="key">问题</span>
												</a>
												<a class="item" target="_blank" href="/topic/19577143/top-answers">
													<span class="value">241</span>
													<span class="key">精华</span>
												</a>
												<a class="item" target="_blank" href="/topic/19577143/followers">
													<span class="value">840</span>
													<span class="key">关注者</span>
												</a>
											</div>
											<div class="operation">
												<button data-follow="t:button" data-id="8978" class="zg-btn zg-btn-follow zm-rich-follow-btn">关注</button>
											</div>
										</div>
									</div>
								</div>
								<div class="arrow"></div>
								<div class="arrow2"></div>
							</div>
						</li>
						<li class="clearfix third">
							<a target="_blank" class="avatar-link" href="/topic/20002447" data-tip="t$t$20002447">
								<img src="images/470280f6b_m.jpg" alt="阿里巴巴 IPO 案" class="avatar 40"/>
							</a>
							<div class="content">
								<a href="/topic/20002447" target="_blank" data-tip="t$b$20002447">阿里巴巴 IPO 案</a>
								<div class="meta">
										<span>3311 人关注</span>
								</div>
							</div>
							<div class="bottom">
								<a class="question_link" target="_blank" href="/question/25454853">如何评价「阿里上市是中国的悲哀，因为阿里最大股东是日本软银」的论调？</a>
							</div>
							<div id="third" class="goog-hovercard popover bottom">
								<div class="popover-content no-hovercard">
									<div class="zh-profile-card topic">
										<div class="upper">
											<a class="avatar-link" href="/topic/19577143">
												<span class="name">阿里巴巴 IPO 案</span>
												<img class="avatar" src="images/470280f6b_m.jpg"/>
											</a>
											<br/>
											<div class="tagline">阿里上市是中国的悲哀，因为阿里最大股东是日本软银…</div>
										</div>
										<div class="lower clearfix">
											<div class="meta">
												<a class="item" target="_blank" href="/topic/19577143/questions">
													<span class="value">75</span>
													<span class="key">问题</span>
												</a>
												<a class="item" target="_blank" href="/topic/19577143/top-answers">
													<span class="value">21</span>
													<span class="key">精华</span>
												</a>
												<a class="item" target="_blank" href="/topic/19577143/followers">
													<span class="value">800</span>
													<span class="key">关注者</span>
												</a>
											</div>
											<div class="operation">
												<button data-follow="t:button" data-id="8978" class="zg-btn zg-btn-follow zm-rich-follow-btn">关注</button>
											</div>
										</div>
									</div>
								</div>
								<div class="arrow"></div>
								<div class="arrow2"></div>
							</div>
						</li>
					</ul>
				</div>
			</div>
			<div id="zh-footer" class="zh-footer">
				<div class="zg-wrap clearfix">
					<ul>
						<li><a href="/question/19581624" target="_blank">知乎指南</a></li>
						<li><a href="javascript:;" id="js-feedback-button">建议反馈</a></li>

						<li><a href="/app" target="_blank">移动应用</a></li>
						<li><a href="/read">知乎阅读</a></li>
						<li><a href="/jobs">加入知乎</a></li>
						<li><a href="/terms" target="_blank">知乎协议</a></li>
						<li><a href="mailto:bd@zhihu.com">商务合作</a></li>
					</ul>
					<span class="copy">© 2014 知乎</span>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
