<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="KnowIsKnow.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script language="javascript"> 
    function Check_FileType() 
    { 
        var str = document.getElementById("FileUpload1").value;
        if (str == "") {
            alert("请选择图片");
            return;
        }
        var pos=str.lastIndexOf("."); 
        var lastname = str.substring(pos, str.length);
        
        if(lastname.toLowerCase()!=".jpg"&&lastname.toLowerCase()!=".gif"&&lastname.toLowerCase()!=".png") 
        { 
            alert("您上传的文件类型为"+lastname+"，图片必须为.jpg,.gif,.png类型"); 
            return false; 
        } 
        else 
        { 
            return true; 
        }         
    } 
    </script> 
    <link href="css/AdminPage.css" rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome-ie7.min.css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/adminpage.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="adTop">
            <div id="adTopDetail">
                <p class="adTitle">知为知</p>
                <a href="#" class="adPerson">wangfang</a>
            </div>
        </div>
        <div id="adContentArea">
            <ul class="adNavOperation">
                <li class="adNavActive"><span linkclass="addTopic">添加话题</span></li>
                <li><span linkclass="alterTopic">修改/删除话题</span></li>
                <li><span linkclass="dealReport">处理举报</span></li>
            </ul>
            <ul class="adOperaDetail addTopic">
                <li class="adInput">
                    <span class="adSpanstyle">主题：</span>
                    <input type="text" class="adTextstyle" />
                </li>
                <li class="adInputSpecial">
                    <span class="adSpanstyle">详细说明：</span>
                    <textarea class="adTextareastyle"></textarea>
                </li>
                <li class="adInput">
                    <span class="adSpanstyle">主题图片：</span>
                    <div class="adThemeImgstyle">
                        <asp:FileUpload ID="FileUpload1" class="adThemeUrl" runat="server" Width="250px" />   
                        <asp:Button ID="UpLoadbtn1" class="adImgOpen" runat="server" Text="上传图片" OnClientClick="return Check_FileType()" OnClick="UpLoadbtn1_Click" />     
                        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>               
                    </div>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </li>
                <li class="adInput">
                    <span class="adSpanstyle">关注数：</span>
                    <input type="text" class="adCarestyle" value="0" />
                </li>
                 <li class="adInput">
                    <span class="adSpanstyle">话题状态：</span>
                     <div class="adCombox" IsOpen="false">
                        <span class="adComboxSpan">normal</span>
                        <span class="adComboxImg fa fa-lightbulb-o"></span>
                         <ul class="adStateList">
                             <li class="adStateli">normal</li>
                             <li class="adStateli">deleted</li>
                         </ul>
                     </div>
                </li>
                 <li class="adInput">
                    <input type="button" class="adButtonstyle" value="添加" />
                </li>
            </ul>
            <div class="adOperaDetail alterTopic">
                <div class="adSearchArea">
                    <span class="adSearchSpan">查找：</span>
                    <div class="adSearch">
                        <input type="text" class="adSearchInput" />
                        <div class="adSearchImg fa fa-lightbulb-o"></div>
                    </div>
                </div>
                <ul class="adTopicList">
                    <li class="adTopicli">
                        <ul>
                            <li class="adTopicImg">Logo
                            </li>
                            <li class="adTopicTitle">标题</li>
                            <li class="adTopicDes">详情</li>
                            <li class="adTopicAttention">关注数</li>
                            <li class="adTopicState">状态</li>
                            <li class="adTopicAlter">操作</li>
                            <li class="adTopicAlter">操作</li>
                        </ul>
                    </li>
                    <li class="adTopicli">
                        <ul>
                            <li class="adTopicImg">
                                <img class="spanshow" src="images/light-bulb-4.png" />
                                <span class="adComboxImg fa fa-lightbulb-o"></span>
                            </li>
                            <li class="adTopicTitle">
                                <span class="spanshow">体育</span>
                                <input type="text" class="adTopicTitleInput" value="体育" /></li>
                            <li class="adTopicDes">
                                <span class="spanshow">体育体育体育体育体育体育体育体育体育体育</span>
                                <input type="text" class="adTopicDesInput" value="体育体育体育体育体育体育体育体育体育体育" />
                            </li>
                            <li class="adTopicAttention">
                                <span class="spanshow">12</span>
                                <input type="text" class="adTopicAttentInput" value="12" />
                            </li>
                            <li class="adTopicState">
                                <span class="spanshow">normal</span>
                                <div class="adCombox adComboxInput" IsOpen="false">
                                    <span class="adComboxSpan">normal</span>
                                    <span class="adComboxImg fa fa-lightbulb-o"></span>
                                     <ul class="adStateList">
                                         <li class="adStateli">normal</li>
                                         <li class="adStateli">deleted</li>
                                     </ul>
                                 </div>
                            </li>
                            <li class="adTopicAlter adxiugai">修改
                            </li>
                            <li class="adTopicAlter adshanchu">删除
                            </li>
                        </ul>
                    </li>
                    <li class="adTopicli">
                        <ul>
                            <li class="adTopicImg">
                                <img class="spanshow" src="images/light-bulb-4.png" />
                                <span class="adComboxImg fa fa-lightbulb-o"></span>
                            </li>
                            <li class="adTopicTitle">
                                <span class="spanshow">体育</span>
                                <input type="text" class="adTopicTitleInput" value="体育" /></li>
                            <li class="adTopicDes">
                                <span class="spanshow">体育体育体育体育体育体育体育体育体育体育</span>
                                <input type="text" class="adTopicDesInput" value="体育体育体育体育体育体育体育体育体育体育" />
                            </li>
                            <li class="adTopicAttention">
                                <span class="spanshow">12</span>
                                <input type="text" class="adTopicAttentInput" value="12" />
                            </li>
                            <li class="adTopicState">
                                <span class="spanshow">normal</span>
                                <div class="adCombox adComboxInput" IsOpen="false">
                                    <span class="adComboxSpan">normal</span>
                                    <span class="adComboxImg fa fa-lightbulb-o"></span>
                                     <ul class="adStateList">
                                         <li class="adStateli">normal</li>
                                         <li class="adStateli">deleted</li>
                                     </ul>
                                 </div>
                            </li>
                            <li class="adTopicAlter adxiugai">修改
                            </li>
                            <li class="adTopicAlter adshanchu">删除
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class="adOperaDetail dealReport">3</div>
        </div>
    </form>
</body>
</html>

