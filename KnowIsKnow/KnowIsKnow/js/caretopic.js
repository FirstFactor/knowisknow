$(function () {
    $(".ghmiddlecontentleftcontentdivdivdivguanzhutitlea2").click(function () {
        var abc = $(this).attr("teshu");
        var ddid1 = $(this).attr("sp");
        if (abc == "false") {
            $(this).html("<i class='ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i'></i>取消固定");
            var userid1 = $("#ycid").html();
            
            var topicid1 = $(this).parent().find(".quxiaoguanzhu").attr("tpid");
            
            var topid = $(this).prev().html();
            var gzsm = $(this).parent().next().find(".ghmiddlecontentleftcontentdivdivdivguanzhucontentquestion").find(".ghmiddlecontentleftcontentdivdivdivguanzhucontentquestionspan").html();
            var chatHtml = '';
            chatHtml += '<div class="ghgzchuangquhuati" id=' + ddid1 + '>';
            chatHtml += '    <div class="ghgzchuangquhuatidiv">';
            chatHtml += '        <a href="" class="ghgzchuangquhuatidivpic">';
            chatHtml += '            <img src="images/1.jpg" class="ghgzchuangquhuatidivpicimg">';
            chatHtml += '        </a>';
            chatHtml += '        <div class="ghgzchuangquhuatidivcontent">';
            chatHtml += '           <a href="" class="ghgzchuangquhuatidivcontentname">' + topid + '</a>';
            chatHtml += '           <div class="ghgzchuangquhuatidivcontentnumber">';
            chatHtml += '               <span class="zg-gray">' + gzsm + '</span>';
            chatHtml += '               <a class="ghycbuttom bianjibuttom " mini=' + topicid1 + '></a>';
            chatHtml += '           </div>';
            chatHtml += '        </div>';
            chatHtml += '    </div>';
            chatHtml += '</div>';
            $("#ghmiddlecontentrightmiddle").append(chatHtml);
            $.ajax({
                data: "{ topicid:'" + topicid1 + "', userid:' " + userid1 + "',careTopicState:'normal' }",
                dataType: "json",
                url: "ws2.asmx/gdhuati",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    
                }
            });


            $(this).attr("teshu", "true");

        }
        else {
            $(this).html("<i class='ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i'></i>固定话题");
            var userid2 = $("#ycid").html();
            var ddid = $(this).attr("sp");
            var topicid2 = $(this).parent().find(".quxiaoguanzhu").attr("tpid");
            
            //$(this).parent().parent().parent().parent().parent().parent().find("#ghmiddlecontentrightmiddle").location.reload();
            $("#" + ddid).remove();
            //$("#ghmiddlecontentrightmiddle").location.reload();
            $.ajax({
                data: "{ topicid:'" + topicid2 + "', userid:' " + userid2 + "',careTopicState:'special'  }",
                dataType: "json",
                url: "ws2.asmx/quxiaogd",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    
                }
            });
            $(this).attr("teshu", "false");
        }
    });
    $(document).on('click', '.bianjibuttom', function () { 
        
        $(this).parent().parent().parent().parent().hide();
        
        var userid5 = $("#ycid").html();
        
        var ddid3 = $(this).parent().parent().parent().parent().attr("id");
        
        var topicid5 = $(this).attr("mini");
        
        $.ajax({
            data: "{ topicid:'" + topicid5 + "', userid:' " + userid5 + "',careTopicState:'special'  }",
            dataType: "json",
            url: "ws2.asmx/quxiaogd",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                
            }
        });
        $("." + ddid3).attr("teshu", "false");
        $("." + ddid3).html("<i class='ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i'></i>固定话题");
    });

    $("#ghmiddlecontentrightbottoma").hover(function () {

        $(this).find("#ghmiddlecontentrightbottomaspan").css({ "text-decoration": "underline", "color": "#259" });
        $(this).find("#ghmiddlecontentrightbottomap").css("background-position", "-234px -24px")
    }, function () {

        $(this).find("#ghmiddlecontentrightbottomaspan").css({ "text-decoration": "none", "color": "#666" });
        $(this).find("#ghmiddlecontentrightbottomap").css("background-position", "-234px -4px")
    });
    $(".ghmiddlecontentleftcontentdiv").hover(function () {
        $(this).find(".ghmiddlecontentleftcontentdivdiv").find(".ghmiddlecontentleftcontentdivdivdiv").find(".ghmiddlecontentleftcontentdivdivdivguanzhutitle").find(".guanzhuhuatispecial").show();
    }, function () {
        $(this).find(".ghmiddlecontentleftcontentdivdiv").find(".ghmiddlecontentleftcontentdivdivdiv").find(".ghmiddlecontentleftcontentdivdivdivguanzhutitle").find(".guanzhuhuatispecial").hide();
    });

    $(document).on('mouseover', '.ghgzchuangquhuati', function () {
        $(this).find(".ghgzchuangquhuatidiv").find(".ghgzchuangquhuatidivcontent").find(".ghgzchuangquhuatidivcontentnumber").find(".ghycbuttom").css("visibility", "visible");
    });
    $(document).on('mouseout', '.ghgzchuangquhuati', function () {
        $(this).find(".ghgzchuangquhuatidiv").find(".ghgzchuangquhuatidivcontent").find(".ghgzchuangquhuatidivcontentnumber").find(".ghycbuttom").css("visibility", "hidden");
    });

   
    
    $(".quxiaoguanzhu").click(function () {
        var userid = $("#ycid").html();
        
        var topicid = $(this).attr("tpid");
        
        $(this).parent().parent().parent().parent().hide();

        $.ajax({
            data: "{ topicid:'"+topicid+"', userid:' "+userid+"' }",
            dataType: "json",
            url: "ws.asmx/DeleteCareTopic",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                
            }
        });

        $.ajax({
            data: "{ topicID:'" + topicid + "'}",
            dataType: "json",
            url: "ws.asmx/deltopicAttention",
            type: "post",
            contentType: "application/json",
            success: function (res) {

            }
        });
    });
    
    xianshi();

});
function xianshi() {
    $.each($(".ghmiddlecontentleftcontentdivdivdivguanzhutitlea2"), function () {
        if ($(this).attr("teshu") == "true") {
            $(this).html("<i class='ghmiddlecontentleftcontentdivdivdivguanzhutitlea2i'></i>取消固定");
        }
    });



}