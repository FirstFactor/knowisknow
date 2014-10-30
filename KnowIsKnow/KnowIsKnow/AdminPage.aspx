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

     

     <link rel="Stylesheet" href="js/uploadify.css" />

    <link href="css/AdminPage.css" rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome-ie7.min.css" />

    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
   
     <script type="text/javascript" src="js/jquery.Jcrop.js"></script>
    <script src="js/uploadify-v2.1.4/jquery.uploadify.v2.1.4.min.js" type="text/javascript"></script>
     <script src="js/uploadify-v2.1.4/swfobject.js" type="text/javascript"></script>
    <link href="css/jquery.Jcrop.css" rel="stylesheet" type="text/css" />
     <link href="css/Main.css" rel="stylesheet" type="text/css" />

   <%-- <script type="text/javascript" src="js/swfobject.js"></script>
    <script type="text/javascript" src="js/jquery.uploadify.min.js"></script>--%>
    
    <script type="text/javascript" src="js/adminpage.js"></script>


     <script src="ueditor/ueditor.config.js"></script>
    <script src="ueditor/ueditor.all.min.js"></script>

    <script type="text/javascript">
        var imageWidth = 50;
        var imageHeiht = 50;

        $(function () {
            $('#uploadify').uploadify({
                'uploader': '/js/uploadify-v2.1.4/uploadify.swf',
                'script': '/Handler/UploadAvatarHandler.ashx',
                'cancelImg': '/js/uploadify-v2.1.4/cancel.png',
                'folder': '/Temp',
                'queueID': 'fileQueue',
                'auto': true,
                'multi': false,
                'method': 'get',
                'fileExt': '*.jpg;*.png',
                'fileDesc': '请选择jpg , png文件...',
                'scriptData': null,
                'sizeLimit': 2097152,
                'onComplete': function (event, queueID, fileObj, response, data) {
                    if (response.indexOf('Temp') != -1) {

                        $("#bgDiv img").remove();                      //移除截图区里image标签
                        $("#btnSave").show();                          //保存按钮显示                    
                        var result = response.split('$');              //得返回参数

                        var maxVal = 0;
                        if (result[1] > result[2]) {
                            maxVal = result[2];
                        }
                        else {
                            maxVal = result[1];
                        }
                        $("#maxVal").val(100);                     //设置截图区大小

                        $("#hidImageUrl").val(result[0]);             //上传路径存入隐藏域


                        $("#imgCut").attr("src", result[0]);
                        //ShowImg(result[0],result[1],result[2]);       //在截图区显示
                        var jcrop_api, boundx, boundy;
                        var $preview = $('.preview-pane');
                        var $pcnt = $('.preview-pane .preview-container');
                        var $pimg = $('.preview-pane .preview-container img');
                        var xsize = $pcnt.width();
                        var ysize = $pcnt.height();

                        $("#target").attr("src", result[0]).Jcrop(
                                                            {
                                                                setSelect: [0, 0, 100, 100],
                                                                minSize: [100, 100],
                                                                aspectRatio: 1,
                                                                allowSelect: false,
                                                                onChange: updatePreview,
                                                                onSelect: updatePreview,
                                                            }, function () {
                                                                var bounds = this.getBounds();
                                                                boundx = bounds[0];
                                                                boundy = bounds[1];
                                                                // Store the API in the jcrop_api variable
                                                                jcrop_api = this;
                                                                // Move the preview into the jcrop container for css positioning
                                                                //$preview.appendTo(jcrop_api.ui.holder);
                                                            });


                        $("#uploadify").uploadifySettings('scriptData', { 'LastImgUrl': $('#hidImageUrl').val() }); 	  //更新参数

                        function setCoords(c) {
                            $("#x").val(c.x);
                            $("#y").val(c.y);
                            $("#maxVal").val(c.w);
                        }

                        function updatePreview(c) {
                            if (parseInt(c.w) > 0) {
                                var rx = xsize / c.w;
                                var ry = ysize / c.h;
                                setCoords(c);
                                $pimg.css({
                                    width: Math.round(rx * boundx) + 'px',
                                    height: Math.round(ry * boundy) + 'px',
                                    marginLeft: '-' + Math.round(rx * c.x) + 'px',
                                    marginTop: '-' + Math.round(ry * c.y) + 'px'
                                });
                            }
                        };
                    }
                    else {
                        alert(response);
                    }
                }
            });


            $("#btnSave").click(function () {
                $.ajax({
                    type: "POST",
                    url: "/Handler/CutAvatarHandler.ashx",
                    data: { imgUrl: $('#hidImageUrl').val(), pointX: $("#x").val(), pointY: $("#y").val(), maxVal: $("#maxVal").val(), lujing: "/images/headimg/final" },
                    success: function (msg) {
                        if (msg.indexOf('images/topicimg') != -1) {
                            $("#imgCut").attr("src", msg);
                            imgurl = msg;
                            $(adimg).prev().attr("src", imgurl);
                            alert("保存成功!");
                        }
                        else {
                            alert("error");
                        }
                    },
                    error: function (xhr, msg, e) {
                        alert("error");
                    }
                });
            });
        });



        function ShowImg(imagePath, imgWidth, imgHeight) {
            var imgPath = imagePath != "" ? imagePath : "images/ef_pic.jpg";
            var ic = new ImgCropper("bgDiv", "dragDiv", imgPath, imgWidth, imgHeight, null);
        }
    </script>


    <%--<script>
        $(document).ready(function () {
            $("#uploadify").uploadify({
                'uploader': 'js/uploadify.swf',
                'script': 'Upload.aspx',
                'cancelImg': 'js/cancel.png',
                'folder': 'images/topicImages',
                'queueID': 'fileQueue',
                'auto': false,
                'multi': true,
                'onComplete': function (file, data, response, i, o) { //上传成功回调方法
                    imgurl = i;
                    $(adimg).prev().attr("src", imgurl);
                }
            });
        });
    </script>--%>
</head>
<body>
    
    <div id="mengban">


    </div>
     <div id="uploadArea">
        <div id="upAreaHeader"><div id="upAreaClose">X</div></div>
         <div class="wraper">
        <div class="fl avatarbg left-box">
            <img alt="[Jcrop Example]" id="target" src="" />
        </div>
        <div class="avatarthumb preview-pane right-box">
               <div class="preview-container"> 
                  <asp:Image ID="imgCut" class="jcrop-preview"  alt="Preview" ImageUrl="/images/blank_pic.jpg" runat="server" />
                </div>

        
        </div>
        <div class="clear"></div>
    </div>
    
    <br />
    <div class="uploadimg">
        <div class="upload">
            <div class="uploadswf">
                <input type="file" name="uploadify" id="uploadify" />
            </div>
            <br />
            <p id="fileQueue">
            </p>
        </div>
    </div>
    <input id="btnSave" type="button" value="保存" style="display: none;" />
    <input id="x" runat="server" type="hidden" value="0" />
    <input id="y" runat="server" type="hidden" value="0" /> 
    <input id="hidImageUrl" type="hidden" value="" />
    <input id="maxVal" runat="server" type="hidden" value="100" />
      
        <div id="fileQueue"></div>
    </div>
    

    <form id="form1" runat="server">
    <div id="adTop">
            <div id="adTopDetail">
                <p class="adTitle">知为知</p>
               
                <asp:Button ID="Button1" runat="server" Text="退出" style="float:right; margin-top:15px;border:0; " OnClick="Button1_Click"/>
                <a href="#" class="adPerson" style="margin-right:15px;"><%=userNickName %></a>
                
            </div>
        </div>
        <div id="adContentArea">
            <ul class="adNavOperation">
                <li class="adNavActive"><span linkclass="addTopic">添加话题</span></li>
                <li><span linkclass="alterTopic">修改/删除话题</span></li>
                <li><span linkclass="dealReport">处理举报</span></li>
                 <li><span linkclass="sendSystemMessage">发送系统消息</span></li>
            </ul>
            <ul class="adOperaDetail addTopic">
                <li class="adInput">
                    <span class="adSpanstyle">主题：</span>
                   <input type="text" name="name" id="txttopictitle" class="adTextstyle" value=" " />
                   
                </li>
                <li class="adInputSpecial">
                    <span class="adSpanstyle">详细说明：</span>
                     <input type="text"  id="txtDesc" class="adTextareastyle"  name="name" value=" " />
                    
                </li>
                <li class="adInput">
                    <span class="adSpanstyle">主题图片：</span>
                    <div class="adThemeImgstyle">
                         <img  runat="server" src="1" name="imglujing" id="imglujing" style="display:none" />
                        <input type="button" id="picupload" name="name" value="上传图片" />    
                    </div>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </li>
                <li class="adInput">
                    <span class="adSpanstyle">关注数：</span>
                    <input type="text" class="adCarestyle" value="0" />
                </li>
                 <li class="adInput">
                    <span class="adSpanstyle">话题状态：</span>
                     <div class="adCombox" style="display:block" IsOpen="false">                     
                        <span runat="server" id="topicState1" class="adComboxSpan">normal</span>
                        <%--<span class="adComboxImg fa fa-lightbulb-o"></span>--%>
                         <%--<ul class="adStateList">
                             <li class="adStateli">normal</li>
                             <li class="adStateli">deleted</li>
                         </ul>--%>
                     </div>
                </li>
                 <li class="adInput">
                    <input type="button" id="addbtn" class="adButtonstyle"  name="name" value="添加" />
                    
                </li>
            </ul>
            <div class="adOperaDetail alterTopic">
                <div class="adSearchArea">
                    <span class="adSearchSpan">查找：</span>
                    <div class="adSearch">
                        <input type="text" class="adSearchInput" />
                        <div class="adSearchImg fa fa-lightbulb-o">
                        </div>
                    </div>
                    <div class="checkTopicState" style="float:right"><div class="zhengchang" divid="normallist" style="float:left;cursor:pointer; margin-right:10px;">正常话题</div><div class="buzhengchang" href="#" divid="unnormallist" style="float:left;cursor:pointer;">已删话题</div><div class="clear"></div> </div>
                </div>
                <ul id="normallist" class="adTopicList">
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
                            <div class="clear"></div>
                        </ul>
                    </li>
                    <div id="nor">
                    <asp:Repeater runat="server" ID="rpttopic">
                        <ItemTemplate>
                            <li class="adTopicli">
                                <ul topicinfoid='<%# Eval("topicID") %>'>
                                    <li class="adTopicImg">
                                        <img class="spanshow logoimg" src="<%# Eval("topicPicUrl") %>" />
                                        <span class="adComboxImg" imgurl="<%# Eval("topicPicUrl") %>">d</span>
                                    </li>
                                    <li class="adTopicTitle">
                                        <span class="spanshow spanTitle"><%# Eval("topicTitle") %></span>
                                        <input type="text" id="addtopictitle" class="adTopicTitleInput" value="" /></li>
                                    <li class="adTopicDes">
                                        <span class="spanshow spanContent"><%# Eval("topicDes") %></span>
                                        <input type="text" class="adTopicDesInput" value="" />
                                    </li>
                                    <li class="adTopicAttention">
                                        <span class="topicAttention">12</span>
                                
                                    </li>
                                    <li class="adTopicState">
                                        <span class="spanshow topicstate">normal</span>
                                        <div class="adCombox adComboxInput" IsOpen="false">
                                            <span class="adComboxSpan selectedtopicstate">normal</span>
                                            <span class="adComboxImg">*</span>
                                             <ul class="adStateList">
                                                 <li class="adStateli">normal</li>
                                                 <li class="adStateli">deleted</li>
                                             </ul>
                                         </div>
                                    </li>
                                    <li class="adTopicAlter adxiugai">修改
                                    </li>
                                    <li class="adTopicAlter submit">确认
                                    </li>
                                    <li class="adTopicAlter adshanchu">删除
                                    </li>
                                    <div class="clear"></div>
                                </ul>
                             </li>
                        </ItemTemplate>
                    </asp:Repeater>
                    </div>
                    <%--<li class="adTopicli">
                        <ul>
                            <li class="adTopicImg">
                                <img class="spanshow" src="images/light-bulb-4.png" />
                                <span class="adComboxImg fa fa-lightbulb-o"></span>
                            </li>
                            <li class="adTopicTitle">
                                <span class="spanshow spanTitle">体育</span>
                                <input type="text" class="adTopicTitleInput" value="" /></li>
                            <li class="adTopicDes">
                                <span class="spanshow spanContent">体育体育体育体育体育体育体育体育体育体育</span>
                                <input type="text" class="adTopicDesInput" value="" />
                            </li>
                            <li class="adTopicAttention">
                                <span >12</span>
                                
                            </li>
                            <li class="adTopicState">
                                <span class="spanshow topicstate">normal</span>
                                <div class="adCombox adComboxInput" IsOpen="false">
                                    <span class="adComboxSpan selectedtopicstate">normal</span>
                                    <span class="adComboxImg fa fa-lightbulb-o"></span>
                                     <ul class="adStateList">
                                         <li class="adStateli">normal</li>
                                         <li class="adStateli">deleted</li>
                                     </ul>
                                 </div>
                            </li>
                            <li class="adTopicAlter adxiugai">修改
                            </li>
                            <li class="adTopicAlter submit">确认
                            </li>
                            <li class="adTopicAlter adshanchu">删除
                            </li>
                        </ul>
                    </li>--%>
                    
                </ul>
                <ul id="unnormallist" class="adTopicList" style="display:none">
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
                            <div class="clear"></div>
                        </ul>
                    </li>
                    <div id="unnor">

                    </div>

                </ul>
                <input type="button"id="first" str="" name="name" value="首页" /><input type="button"id="prevtopiclist" str="" name="name" value="上一页" /><input type="button" id="nexttopiclist" str="" name="name" value="下一页" /><input type="button"id="last" str="" name="name" value="尾页" /><input type="text" id="pages" str="" name="name" value="1" />
            </div>
            <div class="adOperaDetail dealReport">
                <ul class="reportul">
                    <li class="report reportactive" id="reportquestion" showID="reportques">
                        <span>处理举报提问</span>                      
                    </li>
                    <li class="report" id="reportreply" showID="reportrep">
                        <span>处理举报回答</span>                     
                    </li>
                </ul>
                <div class="reportlistArea">
                    <div class="reportlist reportques">
                        <ul>
                            <li ><span class="questionTitle">Title</span> <span class="reportReason">reason</span> <span class="reportOperation">operation1</span> <div class="clear"></div></li>

                            <asp:Repeater runat="server" ID="rptreportQeslist">
                                <ItemTemplate>
                                     <li ><span class="questionTitle"><a href="QuestionDetail.aspx?QuesID=<%#Eval("questionID")%>"><%# Eval("questionTitle") %></a></span> <span class="reportReason"><%#Eval("reportReasonContent") %><%#Eval("reportQuestionReason") %></span> <div class="reportOperationArea"><dl class="reportOperation1 repop"><dt class="selectop">处理</dt><dd class="op" state="delete" reportID="<%#Eval("reportQuID")%>">删除</dd><dd class="op" state="ignore">忽略</dd></dl></div> <div class="clear"></div></li>
                                </ItemTemplate>
                            </asp:Repeater>
                           <%-- <li ><span class="questionTitle"><a href="#">content</a></span> <span class="reportReason">reason</span> <div class="reportOperationArea"><dl class="reportOperation1 repop"><dt class="selectop">处理</dt><dd class="op">删除</dd><dd class="op">忽略</dd></dl></div></li>
                           <li ><span class="questionTitle"><a href="#">content</a></span> <span class="reportReason">reason</span> <div class="reportOperationArea"><dl class="reportOperation1 repop"><dt class="selectop">处理</dt><dd class="op">删除</dd><dd class="op">忽略</dd></dl></div></li>--%>
                        </ul>
                    </div>
                    <div class="reportlist reportrep">
                        <ul>
                            <li ><span class="questionTitle">Title</span> <span class="reportReason">reason</span> <span class="reportOperation">operation1</span></li>


                            <asp:Repeater runat="server" ID="rtpReportReply">
                                <ItemTemplate>
                                   <li ><span class="questionTitle"><a href="QuestionDetail.aspx?QuesID=<%# Eval("replyQuestionID")%>#mao<%# Eval("reportReplyID") %>"><%# Eval("replyContent") %></a></span> <span class="reportReason"><%#Eval("reportReasonContent") %><%#Eval("reportReplyReason") %></span> <div class="reportOperationArea"><dl class="reportOperation1 repop"><dt class="selectop">处理</dt><dd class="op"  state="deleteReportReply" reportID="<%#Eval("reportReID")%>">删除</dd><dd class="op" state="ignore">忽略</dd></dl></div></li>
                                </ItemTemplate>
                            </asp:Repeater>
                           
                        </ul>
                    </div>
                </div>
            </div>
            <div class="adOperaDetail sendSystemMessage">
                <div id="MessageArea">
                    <ul>
                        <li>发送给：<input type="text" id="receiver" name="name" value=" " /></li>
                        <br />
                        <li>
                            <div id="container" style="width:930px; height:300px; border:1px solid #ccc;"></div>

                        </li>
                        <br />
                        <li>
                            <input type="button" id="sendMessage" name="name" value=" 发送" style="float:right" />

                        </li>
                    </ul>
                </div>
            </div>
        </div>

        
        
    </form>
</body>
</html>

