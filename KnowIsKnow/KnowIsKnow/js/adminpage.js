var imgurl;
var adimg;

var  startindex = 1;
var endindex = 5;
var page;

$(function () {

    ue = UE.getEditor('container', {

    });
    //alert("ok");
    $("#mengban").css('opacity', 0.3);


    Pages("topicState='normal'","topicID", startindex, endindex);
    //upload();
    $("#upAreaClose").click(function () {
        $("#mengban").hide();
        $("#uploadArea").hide();

    });



    ///********************/
    $(document).on("click", ".adComboxImg", function () {

        $("#mengban").show();
        $("#uploadArea").show();
        adimg = $(this);
    });

    $(".adComboxImg").click(function () {
        $("#mengban").show();
        $("#uploadArea").show();
        adimg = $(this);
    });




    ////********************//

    $(document).on("keypress", ".adTopicTitleInput", function (e) {
        if (e.keyCode == 13) {

            $(this).hide();
            $(this).prev().html($(this).val());
            $(this).prev().show();
            return false;
        }

        return false;
    });


 
    $(".adTopicTitleInput").keypress(function (e) {
        if (e.keyCode == 13) {

            $(this).hide();
            $(this).prev().html($(this).val());
            $(this).prev().show();
            return false;
        }

        return false;

    });

    //****************/

    $(document).on("keypress", ".adTopicDesInput", function (e) {
        if (e.keyCode == 13) {
            $(this).hide();
            $(this).prev().html($(this).val());
            $(this).prev().show();
            return false;
        }
        return false;
    });

    $(".adTopicDesInput").keypress(function (e) {
        if (e.keyCode == 13) {
            $(this).hide();
            $(this).prev().html($(this).val());
            $(this).prev().show();
            return false;
        }
        return false;
    });

    //$(".spanshow").show();
    // $(".spanshow").next().hide();


    //*********************/
    $(document).on("click", ".adNavOperation li", function () {

        //选项卡选中后样式
        $(".adNavOperation li").removeClass("adNavActive");
        $(this).addClass("adNavActive");

        //显示对应选项卡内容
        var linkclass = $(this).find("span").attr("linkclass");
        $(".adOperaDetail").hide();
        $("." + linkclass).show();
    });

    $(".adNavOperation li").click(function () {
        //选项卡选中后样式
        $(".adNavOperation li").removeClass("adNavActive");
        $(this).addClass("adNavActive");

        //显示对应选项卡内容
        var linkclass = $(this).find("span").attr("linkclass");
        $(".adOperaDetail").hide();
        $("." + linkclass).show();
    });


    /***********************/
    $(document).on("click", ".adCombox",function(){
        var IsOpen = $(this).attr("IsOpen");
        if (IsOpen == "false") {
            $(this).find(".adStateList").show();
            $(this).attr("IsOpen", "true");
        } else {
            $(this).find(".adStateList").hide();
            $(this).attr("IsOpen", "false");
        }
    });

    $(".adCombox").click(function () {
        var IsOpen = $(this).attr("IsOpen");
        if (IsOpen == "false") {
            $(this).find(".adStateList").show();
            $(this).attr("IsOpen", "true");
        } else {
            $(this).find(".adStateList").hide();
            $(this).attr("IsOpen", "false");
        }
    });

    $(document).on("click", ".adStateli", function () {
        var val = $(this).html();
        $(this).parent().parent().find(".adComboxSpan").html(val);
    })

    ///////*********************///
    $(document).on("click", ".adxiugai", function () {

        $(this).parent().find(".adTopicTitleInput").val($(this).parent().find(".spanTitle").html());

        $(this).parent().find(".adTopicDesInput").val($(this).parent().find(".spanContent").html());


        $(this).parent().find(".spanshow").hide();
        $(this).parent().find(".spanshow").next().show();

        $(this).hide();//隐藏修改按钮
        $(this).next().show();//显示确认按钮

    });
    //修改操作
    $(".adxiugai").click(function () {



        $(this).parent().find(".adTopicTitleInput").val($(this).parent().find(".spanTitle").html());

        $(this).parent().find(".adTopicDesInput").val($(this).parent().find(".spanContent").html());


        $(this).parent().find(".spanshow").hide();
        $(this).parent().find(".spanshow").next().show();

        $(this).hide();//隐藏修改按钮
        $(this).next().show();//显示确认按钮
    });


    //************************//
    $(document).on("click", ".submit", function () {


        $(this).hide();//隐藏确认按钮
        $(this).prev().show();//显示修改按钮

        $(this).parent().find(".spanTitle").html($(this).parent().find(".adTopicTitleInput").val());
        $(this).parent().find(".spanContent").html($(this).parent().find(".adTopicDesInput").val());
        $(this).parent().find(".topicstate").html($(this).parent().find(".selectedtopicstate").html());
        $(this).parent().find(".spanshow").show();
        $(this).parent().find(".spanshow").next().hide();

        thistopicid = $(this).parent().attr("topicinfoid");
        thistopicTitle = $(this).parent().find(".adTopicTitleInput").val();
        thistopicDesc = $(this).parent().find(".adTopicDesInput").val();
        thistopicPicUrl = $(this).parent().find(".logoimg").attr("src");
        thistopicAttention = $(this).parent().find(".topicAttention").html();
        thistopicState = $(this).parent().find(".selectedtopicstate").html();

       
        $.ajax({
            data: { "topicid": thistopicid, "topictitle": thistopicTitle, "topicdes": thistopicDesc, "topicpicurl": thistopicPicUrl, "topicattention": thistopicAttention, "topicstate": thistopicState },
            datatype: "json",
            url: "ws.asmx/UpdateTopicInfo",
            type: "post",
            contenttype: "application/json",///这里的东西不能东哪怕是大小写都不要动，不然图片路径传不上去
            success: function (res) {
              
            }

        });

    });

    /*
    $(".submit").click(function () {
        $(this).hide();//隐藏确认按钮
        $(this).prev().show();//显示修改按钮

        $(this).parent().find(".spanTitle").html($(this).parent().find(".adTopicTitleInput").val());
        $(this).parent().find(".spanContent").html($(this).parent().find(".adTopicDesInput").val());
        $(this).parent().find(".topicstate").html($(this).parent().find(".selectedtopicstate").html());
        $(this).parent().find(".spanshow").show();
        $(this).parent().find(".spanshow").next().hide();

        thistopicid = $(this).parent().attr("topicinfoid");
        thistopicTitle = $(this).parent().find(".adTopicTitleInput").val();
        thistopicDesc = $(this).parent().find(".adTopicDesInput").val();
        thistopicPicUrl = $(this).parent().find(".logoimg").attr("src");
        thistopicAttention = $(this).parent().find(".topicAttention").html();
        thistopicState = $(this).parent().find(".selectedtopicstate").html();

        $.ajax({
            data: { "topicid": thistopicid, "topictitle": thistopicTitle, "topicdes": thistopicDesc, "topicpicurl": thistopicPicUrl, "topicattention": thistopicAttention, "topicstate": thistopicState },
            dataType: "json",
            url: "ws.asmx/UpdateTopicInfo",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                alert(res.d);
            }

        });

    });
    */

    //*******************/
    $(document).on("click", ".adshanchu", function () {
        var val = 'deleted';
        $(this).parent().find(".adComboxInput").prev().html(val);
        $(this).parent().find(".adComboxInput").next().html(val);
        $(this).html("已删除");
    });
    //假删操作
    $(".adshanchu").click(function () {
        var val = 'deleted';
        $(this).parent().find(".adComboxInput").prev().html(val);
        $(this).parent().find(".adComboxInput").next().html(val);
        $(this).html("已删除");
    });

    /******************************/
    $(document).on("click", ".report", function () {
        $(".report").removeClass("reportactive");
        $(this).addClass("reportactive");

        var showID = $(this).attr("showID");
        $(".reportlist").hide();
        $("." + showID).show();
    });

    $(".report").click(function () {
        $(".report").removeClass("reportactive");
        $(this).addClass("reportactive");

        var showID = $(this).attr("showID");
        $(".reportlist").hide();
        $("." + showID).show();
    });

    /**************/
    $(document).on("click", ".reportOperation1", function () {

        $(".reportOperation1").css("z-index", "");
        $(this).css("z-index", "99");

        if ($(this).find("dd").css("display") == "block") {
            $(this).find("dd").hide();
        } else {
            $(this).find("dd").show();
        }
    });

    /*
    $(".reportOperation1").click(function () {


        $(".reportOperation1").css("z-index", "");
        $(this).css("z-index", "99");

        if ($(this).find("dd").css("display") == "block") {
            $(this).find("dd").hide();
        } else {
            $(this).find("dd").show();
        }

    });
    */


    /****************/
    $(document).on("click", ".op", function () {


        
        $(this).parent().find("dt").html("已" + $(this).html());
        $(this).parent().find("dd").remove();

        var reportID = $(this).attr("reportID");
        var state = $(this).attr("state");

        if (state == "delete") {
            $.ajax({
                data: "{'reportQuID':" + reportID + "}",
                dataType: "json",
                url: "WSQuan.asmx/DealQuestionReport",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }

            });
        }
        if (state == "deleteReportReply") {
            $.ajax({
                data: "{'reportReID':" + reportID + "}",
                dataType: "json",
                url: "WSQuan.asmx/DealReplyReport",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }

            });
        }

    });

    $(".op").click(function () {
       
        $(this).parent().find("dt").html("已" + $(this).html());
        $(this).parent().find("dd").remove();
        
        var reportID = $(this).attr("reportID");
        var state = $(this).attr("state");
       
        if (state == "delete")
        {
            $.ajax({
                data: "{'reportQuID':" + reportID + "}",
                dataType: "json",
                url: "WSQuan.asmx/DealQuestionReport",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }

            });
        }
        if (state == "deleteReportReply")
        {
            $.ajax({
                data: "{'reportReID':" + reportID + "}",
                dataType: "json",
                url: "WSQuan.asmx/DealReplyReport",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }

            });
        }
    });



    /*************翻页********************/




    $("#prevtopiclist").click(function () {
      
        var str;
        if ($(this).attr("str") == "normal") {

            str = "topicState='normal'";
        }
        if ($(this).attr("str")=="unnormal") {
           str = "topicState='unnormal'";
        }

        order = "topicID"

       
        startindex = startindex - 5;
        endindex = endindex - 5;
        if (startindex <= 0) {
            startindex = 1;
            endindex = 5;
            alert("已经到第一页了");
        }
        Pages(str, order, startindex, endindex);
        $("#pages").val( endindex / 5);

    });

    $("#nexttopiclist").click(function () {
      
        var str;
        if ($(this).attr("str") == "normal") {

            str = "topicState='normal'";
        }
        if ($(this).attr("str") == "unnormal") {
            str = "topicState='unnormal'";
        }

        var allpage;
        order = "topicID";
        $.ajax({
            async: false,
            type: "POST",
            contentType: "application/json",
            url: "WSQuan.asmx/CountPage",
            data: '{"str":"' + str + '","startindex":"' + startindex + '","endindex":"' + endindex + '"}',
            dataType: 'json',
            success: function (result) {
                allpage = result.d;
            }
        });

       
        startindex = startindex+5;
        endindex = startindex + 4;

        if (endindex / 5 >allpage) {
            endindex = allpage * 5;
            startindex = endindex - 5+1;
            alert("已经是最后一页了");
        }
        Pages(str, order, startindex, endindex);
        $("#pages").val(endindex / 5);
        alert(allpage);
    });

    /*************翻页********************/

    $("#first").attr("str", "normal");
    $("#prevtopiclist").attr("str", "normal");
    $("#nexttopiclist").attr("str", "normal");
    $("#last").attr("str", "normal");
    $("#pages").attr("str", "normal");



   
    $(".zhengchang").click(function () {
        biaoji = $(this);
        startindex = 1;
        endindex = 5;

        $("#nor").html("");
        $(".adTopicList").hide();
        $("#normallist").show();
        $("#first").attr("str", "normal");
        $("#prevtopiclist").attr("str", "normal");
        $("#nexttopiclist").attr("str", "normal");
        $("#last").attr("str", "normal");
        $("#pages").attr("str", "normal");
        Pages("topicState='normal'", "topicID", startindex, endindex);
        
    });
    $(".buzhengchang").click(function () {
        biaoji = $(this);
        startindex = 1;
        endindex = 5;
        $("#unnor").html("");
        $(".adTopicList").hide();
        $("#unnormallist").show();
        $("#first").attr("str", "unnormal");
        $("#prevtopiclist").attr("str", "unnormal");
        $("#nexttopiclist").attr("str", "unnormal");
        $("#last").attr("str", "unnormal");
        $("#pages").attr("str", "unnormal");
        Pages("topicState='unnormal'", "topicID", startindex, endindex);

       

    });


    $("#sendMessage").click(function () {
        content = ue.getContent();
        if (content == "") {
            return;
        }
        senderid = 0;
        receiverid = 0;//向所有人发送无法获得具体的id,暂用0代替
        $.ajax({
            async: false,
            type: "POST",
            contentType: "application/json",
            url: "WSQuan.asmx/sendSystemMessage",
            data: "{'senderid':'" + senderid + "','receiverid':'" + receiverid + "', 'content':'" + content + "'}",
            dataType: 'json',
            success: function (result) {
                alert(result.d);
            }
        });

        ue.setContent("");

    });



});

var biaoji;


function upload() {

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

}
var pagesize = 5;

function Pages(str, order,startindex,endindex) {

    $.ajax({
        type: "POST",
        contentType: "application/json",
        url: "WSQuan.asmx/Pages",
        data: '{"str":"' + str + '","order":"' + order + '","startindex":"' + startindex + '","endindex":"' + endindex + '"}',
        dataType: 'json',
        success: function (result) {
            
            if (result.d.length <=0) {
                             
                return;
            }
            $("#nor").html("");
            $(result.d).each(function () {
                var html = "";
                html += '<li class="adTopicli">';
                html += '    <ul topicinfoid="' + this["topicID"] + '">';
                html += '        <li class="adTopicImg">';
                html += '            <img class="spanshow logoimg" src="' + this["topicPicUrl"] + '" />';
                html += '            <span class="adComboxImg" imgurl="' + this["topicPicUrl"] + '">@</span>';
                html += '        </li>';
                html += '        <li class="adTopicTitle">';
                html += '            <span class="spanshow spanTitle">' + this["topicTitle"] + '</span>';
                html += '            <input type="text" id="addtopictitle" class="adTopicTitleInput" value="" /></li>';
                html += '        <li class="adTopicDes">';
                html += '            <span class="spanshow spanContent">' + this["topicDes"] + '</span>';
                html += '            <input type="text" class="adTopicDesInput" value="" />';
                html += '        </li>';
                html += '        <li class="adTopicAttention">';
                html += '            <span class="topicAttention">12</span>';
                html += '        </li>';
                html += '        <li class="adTopicState">';
                html += '            <span class="spanshow topicstate">normal</span>';
                html += '            <div class="adCombox adComboxInput" IsOpen="false">';
                html += '                <span class="adComboxSpan selectedtopicstate">normal</span>';
                html += '                <span class="adComboxImg">*</span>';
                html += '                 <ul class="adStateList">';
                html += '                     <li class="adStateli">normal</li>';
                html += '                     <li class="adStateli">deleted</li>';
                html += '                 </ul>';
                html += '             </div>';
                html += '        </li>';
                html += '        <li class="adTopicAlter adxiugai">修改';
                html += '        </li>';
                html += '        <li class="adTopicAlter submit">确认';
                html += '        </li>';
                html += '        <li class="adTopicAlter adshanchu">删除';
                html += '        </li>';
                html += '        <div class="clear"></div>';
                html += '    </ul>';
                html += '</li>';

                $("#nor").append(html);

            });              
            if (biaoji.attr("divid") == "unnormallist") {
                $("#unnor").html("");
               
                $(result.d).each(function () {
                    var html = "";
                    html += '<li class="adTopicli">';
                    html += '    <ul topicinfoid="' + this["topicID"] + '">';
                    html += '        <li class="adTopicImg">';
                    html += '            <img class="spanshow logoimg" src="' + this["topicPicUrl"] + '" />';
                    html += '            <span class="adComboxImg" imgurl="' + this["topicPicUrl"] + '">@</span>';
                    html += '        </li>';
                    html += '        <li class="adTopicTitle">';
                    html += '            <span class="spanshow spanTitle">' + this["topicTitle"] + '</span>';
                    html += '            <input type="text" id="addtopictitle" class="adTopicTitleInput" value="" /></li>';
                    html += '        <li class="adTopicDes">';
                    html += '            <span class="spanshow spanContent">' + this["topicDes"] + '</span>';
                    html += '            <input type="text" class="adTopicDesInput" value="" />';
                    html += '        </li>';
                    html += '        <li class="adTopicAttention">';
                    html += '            <span class="topicAttention">12</span>';
                    html += '        </li>';
                    html += '        <li class="adTopicState">';
                    html += '            <span class="spanshow topicstate">normal</span>';
                    html += '            <div class="adCombox adComboxInput" IsOpen="false">';
                    html += '                <span class="adComboxSpan selectedtopicstate">normal</span>';
                    html += '                <span class="adComboxImg">*</span>';
                    html += '                 <ul class="adStateList">';
                    html += '                     <li class="adStateli">normal</li>';
                    html += '                     <li class="adStateli">deleted</li>';
                    html += '                 </ul>';
                    html += '             </div>';
                    html += '        </li>';
                    html += '        <li class="adTopicAlter adxiugai">修改';
                    html += '        </li>';
                    html += '        <li class="adTopicAlter submit">确认';
                    html += '        </li>';
                    html += '        <li class="adTopicAlter adhuifu">恢复';
                    html += '        </li>';
                    html += '        <div class="clear"></div>';
                    html += '    </ul>';
                    html += '</li>';

                    $("#unnor").append(html);

                });
            }
           


        }
    });


}