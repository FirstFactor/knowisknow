$(function () {
    panduan();

    $(".zqq-follow-topic-button").click(function () {
        //$(this).toggleClass("zqq-display");
        //$(this).next().toggleClass("zqq-display");

        var questionid = $(this).attr("questionid");
        var userid = $(".userid").attr("userid");
        var panduan = $(this).attr("panduan");
        if (panduan == "false") {
            $.ajax({
                data: "{ questionid:'" + questionid + "', userid:' " + userid + "' }",
                dataType: "json",
                url: "ws.asmx/followQuestion",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });

            $(this).html("取消关注");
            $(this).attr("panduan", "true");
        }
        else {
            $.ajax({
                data: "{ questionid:'" + questionid + "', userid:' " + userid + "' }",
                dataType: "json",
                url: "ws.asmx/nFollowQuestion",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });
            $(this).html("关注问题");
            $(this).attr("panduan", "false");
        }
        
    });
    //$(".zqq-noFollow-topic-button").click(function () {
    //    $(this).toggleClass("zqq-display");
    //    $(this).prev().toggleClass("zqq-display");

    //    var questionid = $(this).parent().parent().parent().find(".zqq-question-title").attr("questionid");
    //    var userid = $(".userid").attr("userid");
        
    //});

    $(".zqq-question-detail").hover(function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").show();
    }, function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").hide();
    });

    $(document).on("click", ".zqq-jubao", function () {
        $(".zqq-menban").show();
        $(".zqq-jubao-inner").show();

        var jubaoQuestionID = $(this).attr("questionid");
        $(".zqq-jubao-submit").attr("questionid", jubaoQuestionID);
    });

    $(".zqq-side-li1").hover(function () {
        $(".zqq-icon-caredQuestion").css("background-position","-183px -24px");
    }, function () {
        $(".zqq-icon-caredQuestion").css("background-position", "-183px -4px");
    });
    $(".zqq-side-li2").hover(function () {
        $(".zqq-icon-allQuestion").css("background-position", "-217px -24px");
    }, function () {
        $(".zqq-icon-allQuestion").css("background-position", "-217px -4px");
    });
    $(".zqq-side-li3").hover(function () {
        $(".zqq-icon-topicSquare").css("background-position", "-234px -24px");
    }, function () {
        $(".zqq-icon-topicSquare").css("background-position", "-234px -4px");
    });
    
});

function panduan() {
    $.each($(".zqq-follow-topic-button"), function () {
        if ($(this).attr("panduan") == "true") {
            $(this).html("取消关注");
        }
    });
}