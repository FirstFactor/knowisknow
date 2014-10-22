var imgurl;
var adimg;
$(function () {
    //alert("ok");
    $("#mengban").css('opacity', 0.3);



    upload();
    $("#upAreaClose").click(function () {
        $("#mengban").hide();
        $("#uploadArea").hide();

    });

    $(".adComboxImg").click(function () {
        $("#mengban").show();
        $("#uploadArea").show();
        adimg = $(this);
    });









    $(".submit").css("display", "none");
    $(".adTopicTitleInput").keypress(function (e) {
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

    $(".spanshow").show();
    $(".spanshow").next().hide();
    $(".adNavOperation li").click(function () {
        //选项卡选中后样式
        $(".adNavOperation li").removeClass("adNavActive");
        $(this).addClass("adNavActive");

        //显示对应选项卡内容
        var linkclass = $(this).find("span").attr("linkclass");
        $(".adOperaDetail").hide();
        $("." + linkclass).show();
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
    //修改操作
    $(".adxiugai").click(function () {



        $(this).parent().find(".adTopicTitleInput").val($(this).parent().find(".spanTitle").html());

        $(this).parent().find(".adTopicDesInput").val($(this).parent().find(".spanContent").html());


        $(this).parent().find(".spanshow").hide();
        $(this).parent().find(".spanshow").next().show();

        $(this).hide();//隐藏修改按钮
        $(this).next().show();//显示确认按钮
    });

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


    //假删操作
    $(".adshanchu").click(function () {
        var val = 'deleted';
        $(this).parent().find(".adComboxInput").prev().html(val);
        $(this).parent().find(".adComboxInput").next().html(val);
        $(this).html("已删除");
    });


    $(".report").click(function () {
        $(".report").removeClass("reportactive");
        $(this).addClass("reportactive");

        var showID = $(this).attr("showID");
        $(".reportlist").hide();
        $("." + showID).show();
    });


    $(".reportOperation1").click(function () {


        $(".reportOperation1").css("z-index", "");
        $(this).css("z-index", "99");

        if ($(this).find("dd").css("display") == "block") {
            $(this).find("dd").hide();
        } else {
            $(this).find("dd").show();
        }

    });
    $(".op").click(function () {
        $(this).parent().find("dt").html("已" + $(this).html());
        $(this).parent().find("dd").remove();
    });



});


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