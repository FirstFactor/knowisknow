<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectTopic.aspx.cs" Inherits="KnowIsKnow.SelectTopic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>知为知——知之为知之，不知为不知,是知也</title>
    <link rel="stylesheet" type="text/css" href="css/SelectTopic.css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/SelectTopic.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="mengban">
            <div class="view">
                <div class="wrapup">
                    <p runat="server" id="mila">

                    </p>
                    <p>
                        欢迎你来到知为知。 这是一个能真正体现你价值的地方。<br />
                        我们相信，娱乐至上的中国互联网，需要一个与众不同的新世界。     
                    </p>

                    <p>
                        在这里，认真、求知、信任与相互尊重，比肤浅的趣味更有意义；<br />


                        在这里，真正有价值的信息是绝对的稀缺品，远未得到有效的挖掘和利用；<br />


                        在这里，人与人之间，可以通过言之有物的分享，建立起真诚而友善的关系。
                    </p>

                    <p>
                        建立这个新世界并不容易，但你会发现，这也不难，只需要你和我们一样：

                    </p>
                    <ul style="padding: 0px;">
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
                   <%-- <a class="tiaoguo">跳过</a>--%>
                    <p style="line-height: 33px;">有哪些你擅长的领域，可以与我们分享？有哪些你感兴趣的领域，想要探索更多？</p>
                   
                </div>
                <div class="topics">
                    <ul style="padding: 0px;">
                        <asp:Repeater runat="server" id="topiclist">
                            <ItemTemplate>
                                 <li>
                            <a class="box">
                                <img src="css/images/user1.jpg " width="50" height="50"  style="float:left;border-radius:50%;"/>
                                <div class="boxright" >
                                    <strong style="color:#444;" runat="server" id="guanzhutopic"><%# Eval("topicTitle") %></strong>
                                    <div class="extra_info">
                                        <div>
                                        <strong runat="server" id="guanzhucount"><%# Eval("topicAttention") %></strong>
                                         人关注
                                        </div>
                                        <div runat="server" id="miaosu">
                                            
                                         
                                        </div>
                                    </div>
                                    <div class="follow_tip">
                                        <i class="clickguanzhu"></i>
                                        <span class="zhuangtai" state="0">  关注</span>
                                    </div>
                                </div>
                            </a>
                        </li>
                            </ItemTemplate>
                        </asp:Repeater>
                       
                       
                    </ul>
                </div>
                <div class="command">
                    <a class="tiaoguo" href="Home.aspx">进入知乎</a>
                </div>
            </div>
            

        </div>
    </form>
</body>
</html>
