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
							<input placeholder="姓" class="zqyfirst"/>
							<input placeholder="名" class="zqylast"/>
						</div>

						<div class="zqyinput">
							<input placeholder="邮箱" class="normalinput zqymail" type="email"/>
						</div>

						<div class="zqyinput">
							<input placeholder="密码" class="normalinput zqymima" type="password"/>
						</div>
						<div class="zqyzhucefailure">
							
						</div>

						<div class="zqyinput">
							<button type="button"  class="zqyzhuceordenglu zqyzhucesign">注册知乎</button>
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

						<div class="zqyinput">
							<input placeholder="知乎注册邮箱" class="normalinput zqysignmail" type="email">
						</div>

						<div class="zqyinput">
							<input placeholder="密码" class="normalinput zqysignmima" type="password">
						</div>
						<div class="zqydenglufailure">
							<ul>
								<li>
								
								</li>
							</ul>
						</div>

						<div class="zqyinput">
							<button type="submit"  class="zqyzhuceordenglu  zqydenglusign">登陆</button>
						</div>



					</div>
				</div>
				<br style="clear:both;" />
			</div>
		</div>
		<div class="zqybottom"></div>
		<div class="zqyfooter"></div>
	</div> 
    </div>
    </form>
</body>
</html>
