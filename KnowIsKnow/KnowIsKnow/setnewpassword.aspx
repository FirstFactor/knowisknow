<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resetpassword.aspx.cs" Inherits="KnowIsKnow.resetpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>密码重置-知为知</title>
    <link rel="stylesheet" type="text/css" href="css/resetpassword.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="rpmain">
            <h1 style="color: #EEE; text-align: center; font-size: 50px; line-height: 40px;">知为知</h1>
            <span style="color: #DDD; text-align: center; display: block; font-weight: bold;">知之为知之，不知为不知，是知也</span>
            <div class="fasong" runat="server" id="qingkong"> 
                <div class="wrap_input">
                    <input type="email" name="name" value=" " class="inputyouxiang" placeholder="密码" runat="server" id="rspemail" />
                </div>
                <div class="wrap_input">
                    <input type="email" name="name" value=" " class="inputyouxiang" placeholder="确认密码" runat="server" id="Email1" />
                </div>
                <asp:Button Text="重设密码" runat="server" ID="resetpwd" OnClick="resetpwd_Click" class="btnmima" />
            </div>
        </div>
    </form>
</body>
</html>
