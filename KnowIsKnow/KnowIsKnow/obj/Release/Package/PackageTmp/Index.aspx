<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="KnowIsKnow.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>知为知——知之为知之，不知为不知,是知也</title>
    <link rel="stylesheet" type="text/css" href="css/Index.css" />
    <link rel="SHORTCUT ICON" href="favicon.ico" />
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
                                        <input class="zqyfirst" id="inputxing" />
                                    </div>
                                    <div class="xmright">
                                        <span class="zqyplaspan emaillast">名</span>
                                        <input class="zqylast"  id="inputming" />
                                    </div>
                                </div>

                                <div class="zqyinput spec">
                                    <span class="zqyplaspan emailspan">邮箱</span>
                                    <input  id="inputyx" class="normalinput zqymail" type="email" />
                                </div>

                                <div class="zqyinput spec">
                                    <span class="zqyplaspan pwdspan">密码</span>
                                    <input  id="inputmm" class="normalinput zqymima" type="password" />

                                </div>

                                <div class="zqyzhucefailure">
                                </div>

                                <div class="zqyinput">
                                    <button type="button" runat="server" class="zqyzhuceordenglu zqyzhucesign" >注册知乎</button>
                                    <%--<asp:Button ID="btnzhuce" runat="server" Text="注册知乎" class="zqyzhuceordenglu zqyzhucesign" OnClick="btnzhuce_Click" />--%>
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
                                    <input class="normalinput zqysignmail" type="email"  id="inputsignyx" />
                                </div>

                                <div class="zqyinput spec inputsignmima">
                                    <span class="zqyplaspan signpwdspan">密码</span>
                                    <input class="normalinput zqysignmima" type="password" id="inputsignmm" />
                                </div>
                                <div class="zqydenglufailure">
                                </div>

                                <div class="zqyinput">
                                    <button type="button"  class="zqyzhuceordenglu  zqydenglusign">登陆</button>

                                   <%-- <asp:Button Text="登录" runat="server" class="zqyzhuceordenglu  zqydenglusign" ID="btndenglu" OnClick="btndenglu_Click" />--%>
                                </div>
                                <div class="zqyinput">
                                    <div style="float: left;width:80px;height:20px;">
                                        <input type="checkbox" name="name" value=" " />
                                        <span style="font-size: 12px;">记住我</span>
                                    </div>
                                    <a href="resetpassword.aspx" style="color: #FFF; display: block; float: right; font-size: 12px;width:80px;height:20px;line-height:20px;">忘记密码?</a>
                                </div>


                            </div>


                            <div runat="server" id="faultshow" class="showfault">
                            </div>
                        </div>
                        <br style="clear: both;" />
                    </div>
                </div>
                <div class="zqybottom">
                    <div class="bottomwrap">
                        <div class="zqyuserlist">

                            <asp:Repeater runat="server" ID="touph">
                                <ItemTemplate>
                                    <div class="zqyuserph">
                                        <img src="<%# Eval("userHeadImage") %>" class="zqyuserimg" shuoshuo="<%# Eval("userShuoShuo") %>" mingzi="<%# Eval("userNickName") %>" />
                                    </div>

                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="zqyuserstory">
                            <div class="zqytopic">
                                <img src="css/images/user1.jpg" class="story_avatar">
                                <div class="story_title">
                                    <div>
                                        <a href="#" class="story_jies mingzi">系统</a>
                                        <span>床前明月光</span>
                                    </div>
                                    <div class="story_jies">68743 人关注该话题，1000 个精华回答</div>
                                </div>
                                <div class="sep"></div>
                                <div class="story_content">
                                    <div class="story_content_answer">
                                        <span class="vote">2222
                                        </span>
                                        <p>
                                            <a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Don't Make Me Think」原则？</a>
                                        </p>
                                    </div>
                                    <div class="story_content_answer">
                                        <span class="vote">2222
                                        </span>
                                        <p>
                                            <a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Don't Make Me Think」原则？</a>
                                        </p>
                                    </div>
                                    <div class="story_content_answer">
                                        <span class="vote">2222
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
            <%--  <div class="mengban">
            <div class="view">
                <div class="wrapup">
                    <p>
                        欢迎你来到知为知。 这是一个能真正体现你价值的地方。<br /> 我们相信，娱乐至上的中国互联网，需要一个与众不同的新世界。     
                    </p>

                    <p>
                            在这里，认真、求知、信任与相互尊重，比肤浅的趣味更有意义；<br />
                       

                                在这里，真正有价值的信息是绝对的稀缺品，远未得到有效的挖掘和利用；<br />
                     
                        
                                在这里，人与人之间，可以通过言之有物的分享，建立起真诚而友善的关系。
                    </p>

                    <p> 
                            建立这个新世界并不容易，但你会发现，这也不难，只需要你和我们一样：

                    </p>
                    <ul  style="padding:0px;">
                        <li>
                            <b>认真</b>
                            、
                            <b>专业</b>
                            ：言之有物，不灌水，为自己的话负责
                        </li>
                        <li>
                            <b>友善</b>
                            、
                            <b>互助</b>
                            ：感谢每一个用心的回答，同时尊重与你观点不同的人
                        </li>
                    </ul>

                    <p>
                            独一无二的你，总有见解值得分享；世界那么大，也有等待着你的未知。 

                    </p>
                    <p> 
                            欢迎你加入我们，一起创造知乎，发现更大的世界。

                    </p>
                    <a class="kaishi">开始</a>
                </div>
            </div>
            <div class="followtopic">
                <div class="followtip">
                    <a class="tiaoguo">跳过</a>
                    <p style="line-height:33px;">有哪些你擅长的领域，可以与我们分享？有哪些你感兴趣的领域，想要探索更多？</p>
                </div>
                <div class="topics">
                    <ul style="padding:0px;">
                        <li >
                            <a class="box"></a>
                        </li>
                         <li >
                            <a class="box"></a>
                        </li>
                        <li >
                            <a class="box"></a>
                        </li>
                        <li >
                            <a class="box"></a>
                        </li>
                        <li >
                            <a class="box"></a>
                        </li>
                        <li >
                            <a class="box"></a>
                        </li>
                        <li >
                            <a class="box"></a>
                        </li>
                        <li >
                            <a class="box"></a>
                            <li >
                            <a class="box"></a>
                        </li>
                        </li>
                    </ul>
                </div>
                <div class="command">
                     <a class="tiaoguo">跳过</a>
                </div>
            </div>

            
        </div>--%>
        </div>
    </form>
</body>
</html>
