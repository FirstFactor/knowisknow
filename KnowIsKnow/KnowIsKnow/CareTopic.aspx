﻿<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="CareTopic.aspx.cs" Inherits="KnowIsKnow.CareTopic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/CareTopic.css?kmlj=ujhjh" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/caretopic.js"></script>
    
</asp:Content>
    
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ycid"><%=userID %></div>
    
    <div id="ghmiddlecontent">
		<div id="ghmiddlecontentleft">
			<div id="ghmiddlecontentlefttitle">
				<p id="ghmiddlecontentlefttitlepic"></p>
				<span>话题动态</span>
				<a href="ProCenter.aspx" id="ghmiddlecontentlefttitlea">共关注 <%= geshu %> 个话题</a>
			</div>
		<div id="ghmiddlecontentleftcontent">		

				<asp:Repeater runat="server" ID="rptquestionlist">
                    <ItemTemplate>
                        <div class="ghmiddlecontentleftcontentdiv">
					        <div class="ghmiddlecontentleftcontentdivdiv">
						        <a href="TopicSquare.aspx" class="ghmiddlecontentleftcontentdivdiva">
							        <img src="<%# Eval("topicPicUrl") %>" class="ghmiddlecontentleftcontentdivdivimg">
						        </a>
						        <div class="ghmiddlecontentleftcontentdivdivdiv">
							        <div class="ghmiddlecontentleftcontentdivdivdivguanzhutitle">
								        <a href="TopicSquare.aspx;" class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea1"><%# Eval(" topicTitle ") %></a>
								        <a class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2 a<%# Eval(" TopicID ") %>_<%=userID %>" tp="<%# Eval("topicPicUrl") %>" sp="a<%# Eval(" TopicID ") %>_<%=userID %>" teshu="<%# Check(Eval("topicID")) %>">
									        <i class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i" ></i>固定话题
								        </a> 
								        <a  href="javascript:;" class="ghmiddlecontentleftcontentdivdivdivguanzhutitlea3 guanzhuhuatispecial quxiaoguanzhu" tpid="<%# Eval("topicID")%>">取消关注</a>
							        </div>
							        <div class="ghmiddlecontentleftcontentdivdivdivguanzhucontent">
								        <div class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion">
									        <a href="TopicSquare.aspx" class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestiona"><%# Eval(" topicDes ") %></a>
									        <span class="ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan">关注人数：<%# Eval(" topicAttention ") %></span>
								        </div>								       
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
                <asp:Repeater runat="server" ID="sd">
                    <ItemTemplate>
                        <div class="ghgzchuangquhuati" id="a<%# Eval(" TopicID ") %>_<%=userID %>">
					        <div class="ghgzchuangquhuatidiv">
						        <a href="" class="ghgzchuangquhuatidivpic">
							        <img src="<%# Eval("topicPicUrl") %>" class="ghgzchuangquhuatidivpicimg">
						        </a>
						        <div class="ghgzchuangquhuatidivcontent">
							        <a href="" class="ghgzchuangquhuatidivcontentname"><%# Eval(" topicTitle ") %></a>
							        <div class="ghgzchuangquhuatidivcontentnumber">
								        <span class="zg-gray">关注人数</span>
								        <span class="bull">：</span>
								        <span class="zg-gray"><%# Eval(" topicAttention ") %></span>
                                        <a class="ghycbuttom bianjibuttom " mini="<%# Eval("TopicID")%>"></a>							                               
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
