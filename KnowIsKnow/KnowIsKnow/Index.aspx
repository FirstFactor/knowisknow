<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="KnowIsKnow.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>知为知——知之为知之，不知为不知,是知也</title>
    <link rel="stylesheet" type="text/css" href="css/Index.css"/>
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
	<script type="text/javascript" src="js/index.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="zqywrapper">
		<div class="zqytop">
			<div class="zqytopContent">
				<div class="zqytcleft">
					<div class="zqylogo">
						<span class="zqylogotitle">知为知</span>
						<span class="zqylogocontent">知之为知之，不知为不知,是知也</span>
					</div>
				</div>
				<div class="zqytcright">
				<!-- 注册 -->
					<div class="zqysignup">
						<div class="zqytitle">
							<a class="zqyzhuce">注册帐号</a>
							<a class="zqydenglu ludeng">
								<span class="zqydengL">登录</span>
								<i class="zqyicon"></i>
							</a>
						</div>

						<div class="zqyinput">
							<div class="xmleft">
								<span class="zqyplaspan emailfirst">姓</span>
								<input  class="zqyfirst"  runat="server" id="inputxing"/>
							</div>
							<div class="xmright">
								<span class="zqyplaspan emaillast">名</span>
								<input  class="zqylast" runat="server" id="inputming" />
							</div>
							
						</div>

						<div class="zqyinput spec">
							<span class="zqyplaspan emailspan">邮箱</span>
							<input  class="normalinput zqymail" type="email" runat="server"  id="inputyx"/>
						</div>

						<div class="zqyinput spec">
							<span class="zqyplaspan pwdspan">密码</span>
							<input class="normalinput zqymima" type="password" runat="server" id="inputmm" />
						</div>
						<div class="zqyzhucefailure">
					
						</div>

						<div class="zqyinput">
							<button   class="zqyzhuceordenglu zqyzhucesign">注册知乎</button>
						</div>

					</div>


					<div class="zqysignin">
						<div class="zqytitle">
							<a class="zqyzhuce">登陆知乎</a>
							<a class="zqydenglu cezhu">
								<span class="zqydengL">注册</span>
								<i class="zqyicon"></i>
							</a>
						</div>

						<div class="zqyinput spec inputmail">
							<span class="zqyplaspan signemailspan">邮箱</span>
							<input  class="normalinput zqysignmail" type="email"  runat="server" id="inputsignyx"/>
						</div>

						<div class="zqyinput spec inputsignmima">
							<span class="zqyplaspan signpwdspan">密码</span>
							<input  class="normalinput zqysignmima" type="password"  runat="server"  id="inputsignmm"/>
						</div>
						<div class="zqydenglufailure">
							<ul>
								<li>
								
								</li>
							</ul>
						</div>

						<div class="zqyinput">
							<button  class="zqyzhuceordenglu  zqydenglusign">登陆</button>
						</div>



					</div>

                

				</div>

                 <div runat="server" id="faultshow" class="showfault">
				<br style="clear:both;" />
			</div>
		</div>
		<div class="zqybottom">
			<div class="bottomwrap">
				<div class="zqyuserlist">
					<div class="zqyuserph">
						<img src="css/images/user1.jpg" class="zqyuserimg zqyuserspec" phid="1" />
					</div>

					<div class="zqyuserph">
						<img src="css/images/user2.jpg" class="zqyuserimg" phid="2" />
					</div>

					<div class="zqyuserph">
						<img src="css/images/user3.jpg" class="zqyuserimg" phid="3" />
					</div>

					<div class="zqyuserph">
						<img src="css/images/user4.jpg" class="zqyuserimg" phid="4" />
					</div>

					<div class="zqyuserph">
						<img src="css/images/user5.jpg" class="zqyuserimg" phid="5" />
					</div>
				</div>
				<div class="zqyuserstory">
 					<div class="zqytopic">
						<img src="css/images/user1.jpg" class="story_avatar" />
						<div class="story_title">
							<div>
								<a href="#" class="story_jies mingzi">Cat Chen</a>
								<span>上知乎，求欢乐</span>
							</div>
							<div class="story_jies">68743 人关注该话题，1000 个精华回答</div>
						</div>
						<div class="sep"></div>
						<div class="story_content">
							<div class="story_content_answer">
								<span class="vote">
									2222
								</span>
								<p>
									<a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Don't Make Me Think」原则？</a>
								</p>
							</div>
							<div class="story_content_answer">
								<span class="vote">
									2222
								</span>
								<p>
									<a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Don't Make Me Think」原则？</a>
								</p>
							</div>
							<div class="story_content_answer">
								<span class="vote">
									2222
								</span>
								<p>
									<a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Don't Make Me Think」原则？</a>
								</p>
							</div>
						</div>

						<div class="sep"></div>
						<div class="story_end">
							Cat Chen在<a href="#" class="huati"> Facebook</a>、<a href="#" class="huati">政治</a>、<a href="#" class="huati">历史</a>等话题下获得了 <span>11024</span> 个赞同
						</div>
					</div>
				</div>
			</div>
		</div>
		<div class="zqyfooter"></div>
	</div> 
    </div>
    </form>
</body>
</html>
