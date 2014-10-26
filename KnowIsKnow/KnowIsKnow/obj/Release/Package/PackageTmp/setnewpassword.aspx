<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="setnewpassword.aspx.cs" Inherits="KnowIsKnow.setnewpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>密码重置-知为知</title>
    <link href="css/setnewpassword.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/setnewpassword.js"></script>
</head>
<body style="background:#0078d8 url('images/light.png');width:100%;height:100%;">
    <form id="form1" runat="server">
        <div id="dddd" runat="server" style="display:none" class="yanzheng"></div>
        <div id="eeee" runat="server" style="display:none" class="uid"></div>
        <div class="rpmain" style="width:320px;height:400px;margin:auto;margin-top:100px;">
            <h1 style="color: #EEE; text-align: center; font-size: 50px; line-height: 40px;">知为知</h1>
            <span style="color: #DDD; text-align: center; display: block; font-weight: bold;">知之为知之，不知为不知，是知也</span>
            <input type="password" name="name" value=""   id="diyici" placeholder="密码" style="display:block;width:227px;height:18px;padding:8px 10px;border:1px solid #167289;border-radius:5px; margin:20px 0 0 30px;" />
            <input type="password" name="name" value=""   id="dierci" placeholder="确认密码"  style="display:block;width:227px;height:18px;padding:8px 10px;border:1px solid #167289;border-radius:5px;margin:20px 0 0 30px;"/>
            <input type="text" name="name" value="" placeholder="序列号"   id="xuliehao" style="display:block;width:227px;height:18px;padding:8px 10px;border:1px solid #167289;border-radius:5px;margin:20px 0 0 30px;" />

            <div class="fault" style="width:245px;background: rgba(0,0,0,.1);margin:20px 0 0 32px;display:none;">

            </div>
            <div class="czmima" style=" cursor:pointer; margin-left:32px;text-align:center;line-height:30px; color:#FFF;width:220px;height:30px;padding:8px 10px;border:1px solid #167289;border-radius:5px;background: -webkit-gradient(linear,left top,left bottom,from(#80c3f7),to(#6bbaf8));margin-top:30px; font-size:20px;">重置密码</div>

            
        </div>
        <div class="mengban" style="width:100%;height:100%;position:absolute;top:0px;left:0px;display:none;">
            <div style="width:240px;height:160px;margin: auto;margin-top:150px;background-color:#888;padding:30px;">
                <div style="height:30px;line-height:30px;font-size:18px;color:#FFF;">密码重置成功!</div>
                <a href="index.aspx" style="text-decoration:none;color:#0078d8;display:block; text-align:right;font-size:20px;line-height:40px;">这就去登录...</a>
                <div class="guanbi" style="color:#FFF;margin:40px 0 0 80px;cursor:pointer;">确定</div>
            </div>
        </div>
    </form>
</body>
</html>
