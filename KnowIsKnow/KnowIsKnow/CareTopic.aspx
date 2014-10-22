<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="CareTopic.aspx.cs" Inherits="KnowIsKnow.CareTopic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/CareTopic.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/caretopic.js"></script>
    
</asp:Content>
    
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ycid"><%=userID %></div>
    <div id="ghmiddlecontent">
		<div id="ghmiddlecontentleft">
			<div id="ghmiddlecontentlefttitle">
				<p id="ghmiddlecontentlefttitlepic"></p>
				<span>话题动态</span>
				<a href="" id="ghmiddlecontentlefttitlea">共关注 <%= geshu %> 个话题</a>
			</div>
			<div id="ghmiddlecontentleftcontent">
				<%--<div class="ghmiddlecontentleftcontentdiv">
					<div class="ghmiddlecontentleftcontentdivdiv">
						<a href="" class="ghmiddlecontentleftcontentdivdiva">
							<img src="images/1.jpg" class="ghmiddlecontentleftcontentdivdivimg">
						</a>
						<div class="ghmiddlecontentleftcontentdivdivdiv">
							<div class="ghmiddlecontentleftcontentdivdivdivguanzhutitle">
								<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea1">iOS 游戏</a>
								<a class="special ghmiddlecontentleftcontentdivdivdivguanzhutitlea2 guanzhuhuatispecial ">
									<i class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i"></i>固定话题
								</a>
								<a class=" special ghmiddlecontentleftcontentdivdivdivguanzhutitlea2 ">
									<i class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i"></i>取消固定
								</a>
								<a  class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea3 guanzhuhuatispecial quxiaoguanzhu">取消关注</a>
							</div>
							<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontent">
								<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion">
									<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">450万圣水，升三级龙还是六级野蛮人呢？</a>
									<span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">1 分钟前</span>
								</div>
								<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion">
									<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">国内哪些游戏已进入海外市场？</a>
									<span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">4 分钟前</span>
								</div>
								<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion1">
									<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">求一款耐玩的iPhone游戏！不要太贵，预算就100块?</a>
									<span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">1 小时前</span>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="ghmiddlecontentleftcontentdiv">
					<div class="ghmiddlecontentleftcontentdivdiv">
						<a href="" class="ghmiddlecontentleftcontentdivdiva">
							<img src="images/1.jpg" class="ghmiddlecontentleftcontentdivdivimg">
						</a>
						<div class="ghmiddlecontentleftcontentdivdivdiv">
							<div class="ghmiddlecontentleftcontentdivdivdivguanzhutitle">
								<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea1">iOS 游戏</a>
								<a class="special ghmiddlecontentleftcontentdivdivdivguanzhutitlea2 guanzhuhuatispecial ">
									<i class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i"></i>固定话题
								</a>
								<a class=" special ghmiddlecontentleftcontentdivdivdivguanzhutitlea2 ">
									<i class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i"></i>取消固定
								</a>
								<a  class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea3 guanzhuhuatispecial quxiaoguanzhu">取消关注</a>
							</div>
							<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontent">
								<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion">
									<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">450万圣水，升三级龙还是六级野蛮人呢？</a>
									<span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">1 分钟前</span>
								</div>
								<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion">
									<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">国内哪些游戏已进入海外市场？</a>
									<span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">4 分钟前</span>
								</div>
								<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion1">
									<a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">求一款耐玩的iPhone游戏！不要太贵，预算就100块?</a>
									<span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">1 小时前</span>
								</div>
							</div>
						</div>
					</div>
				</div>--%>

				<asp:Repeater runat="server" ID="rptquestionlist">
                    <ItemTemplate>
                        <div class="ghmiddlecontentleftcontentdiv">
					        <div class="ghmiddlecontentleftcontentdivdiv">
						        <a href="" class="ghmiddlecontentleftcontentdivdiva">
							        <img src="<%# Eval("topicPicUrl") %>" class="ghmiddlecontentleftcontentdivdivimg">
						        </a>
						        <div class="ghmiddlecontentleftcontentdivdivdiv">
							        <div class="ghmiddlecontentleftcontentdivdivdivguanzhutitle">
								        <a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea1"><%# Eval(" topicTitle ") %></a>
								        <a class="special ghmiddlecontentleftcontentdivdivdivguanzhutitlea2 guanzhuhuatispecial ">
									        <i class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i"></i>固定话题
								        </a>
								        <a class=" special ghmiddlecontentleftcontentdivdivdivguanzhutitlea2 ">
									        <i class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i"></i>取消固定
								        </a>
								        <a  class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea3 guanzhuhuatispecial quxiaoguanzhu" tpid="<%# Eval("topicID")%>">取消关注</a>
							        </div>
							        <div class="ghmiddlecontentleftcontentdivdivdivguanzhucontent">
								        <div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion">
									        <a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona"><%# Eval(" topicDes ") %></a>
									        <span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">1 分钟前</span>
								        </div>
								        <%--<div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion">
									        <a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">国内哪些游戏已进入海外市场？</a>
									        <span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">4 分钟前</span>
								        </div>
								        <div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion1">
									        <a href="" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona">求一款耐玩的iPhone游戏！不要太贵，预算就100块?</a>
									        <span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">1 小时前</span>
								        </div>--%>
							        </div>
						        </div>
					        </div>
				        </div>
                    </ItemTemplate>
                </asp:Repeater>
			</div>
		</div>
		<div id="ghmiddlecontentright">
			<div id="ghmiddlecontentrighttop">
				<span>常去话题</span>
			</div>
			<div id="ghmiddlecontentrightmiddle">
				<%--<div class="ghgzchuangquhuati">
					<div class="ghgzchuangquhuatidiv">
						<a href="" class="ghgzchuangquhuatidivpic">
							<img src="images/1.jpg" class="ghgzchuangquhuatidivpicimg">
						</a>
						<div class="ghgzchuangquhuatidivcontent">
							<a href="" class="ghgzchuangquhuatidivcontentname">单机游戏</a>
							<div class="ghgzchuangquhuatidivcontentnumber">
								<span class="zg-gray">40 个子话题</span>
								<span class="bull">?</span>
								<span class="zg-gray">28328 人关注</span>
                                <a class="ghycbuttom bianjibuttom "></a>
								<a href="" class="ghycbuttom bianjibuttom2 "></a>
                                
							</div>
						</div>
					</div>
				</div>--%>
                
                <asp:Repeater runat="server" ID="sd">
                    <ItemTemplate>
                        <div class="ghgzchuangquhuati">
					<div class="ghgzchuangquhuatidiv">
						<a href="" class="ghgzchuangquhuatidivpic">
							<img src="images/1.jpg" class="ghgzchuangquhuatidivpicimg">
						</a>
						<div class="ghgzchuangquhuatidivcontent">
							<a href="" class="ghgzchuangquhuatidivcontentname">单机游戏</a>
							<div class="ghgzchuangquhuatidivcontentnumber">
								<span class="zg-gray">40 个子话题</span>
								<span class="bull">?</span>
								<span class="zg-gray">28328 人关注</span>
                                <a class="ghycbuttom bianjibuttom "></a>
								<%--<a href="" class="ghycbuttom bianjibuttom2 "></a>--%>
                                
							</div>
						</div>
					</div>
				</div>
                    </ItemTemplate>
                </asp:Repeater>
			</div>
			<div id="ghmiddlecontentrightbottom">
				<a href="TopicSquare.aspx" id="ghmiddlecontentrightbottoma">
					<p id="ghmiddlecontentrightbottomap"></p>
					<span id="ghmiddlecontentrightbottomaspan">话题广场</span>
				</a>
			</div>
		</div>
	</div>
</asp:Content>
