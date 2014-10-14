<%@ Page Title="" Language="C#" MasterPageFile="~/KnowIsKnow.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="KnowIsKnow.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Home.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript" src="js/home.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
			

		<%--<div class="zqq-tiwen">提问</div>--%>

		<!******首页内容**********>
		<div class="zqq-main">
			<div class="zqq-mini-main">
				<div class="zqq-mm-R">
					<div class="zqq-mm-R-L">
						<div class="zqq-question-area">
						<div class="zqq-newQuestion"></div>
						<div class="zqq-small-question">
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
									<div class="zqq-follow-topic">关注话题</div>
									<div class="zqq-jubao">举报</div>
								</div>
							</div>
							</div>
						</div>
					</div>
					<div class="zqq-mm-R-R"></div>
				</div>
			</div>
		</div>
		<div class="zqq-footer"></div>
</body>
</asp:Content>
