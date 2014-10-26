<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resetpassword.aspx.cs" Inherits="KnowIsKnow.resetpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/resetpassword.css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/resetpassword.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="rpmain">
            <h1 style="color: #EEE; text-align: center; font-size: 50px; line-height: 40px;">知为知</h1>
            <span style="color: #DDD; text-align: center; display: block; font-weight: bold;">知之为知之，不知为不知，是知也</span>
            <div class="fasong" runat="server" id="qingkong"> 
                <div class="wrap_input">
                    <input type="email" name="name" value=" " class="inputyouxiang" placeholder="邮箱" runat="server" id="rspemail" />
                </div>
                <asp:Button Text="重设密码" runat="server" ID="resetpwd" OnClick="resetpwd_Click" class="btnmima" />
                <a href="index.aspx" style="display: block; color: #FFF; margin: 15px 0 0 200px; text-decoration: none;">返回登录</a>
            </div>
            <%--<div class="chenggong">
                密码重设的链接已发送至<br />
                <span class="fsyouxiang" style="display:none;margin-top:10px;" runat="server" id="faemail"></span>
            </div>--%>
        </div>
    </form>
</body>
</html>
