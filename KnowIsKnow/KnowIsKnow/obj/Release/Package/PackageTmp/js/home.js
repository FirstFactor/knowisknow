$(function () {
    panduan();
    CheckQusetionProvider();

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
    $(".zqq-noFollow-topic-button").click(function () {
        var questionid = $(this).attr("questionid");
        var userid = $(".userid").attr("userid");
        var panduan = $(this).attr("panduan");
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
        $(this).parent().parent().parent().parent().hide();

    });
    //$(".zqq-noFollow-topic-button").click(function () {
    //    $(this).toggleClass("zqq-display");
    //    $(this).prev().toggleClass("zqq-display");

    //    var questionid = $(this).parent().parent().parent().find(".zqq-question-title").attr("questionid");
    //    var userid = $(".userid").attr("userid");
        
    //});

    $(".zqq-small-question").hover(function () {
        $(this).find(".zqq-question-detail").find(".zqq-question-ft").find(".zqq-jubao").show();
        $(this).find(".zqq-question-detail").find(".zqq-question-ft").find(".zqq-myquestion-delect").show();
    }, function () {
        $(this).find(".zqq-question-detail").find(".zqq-question-ft").find(".zqq-jubao").hide();
        $(this).find(".zqq-question-detail").find(".zqq-question-ft").find(".zqq-myquestion-delect").hide();
    });

    $(document).on("click", ".zqq-myquestion-delect", function () {
        $(this).parent().parent().parent().hide();
        var questionid = $(this).attr("questionid");
        $.ajax({
            data: "{ questionid:'" + questionid + "' }",
            dataType: "json",
            url: "ws.asmx/delMyQuestion",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                alert(res.d);
            }
        });
    });

    $(document).on("click", ".zqq-jubao", function () {
        if ($(this).attr("CheckQusetionProvider") == "myQuestion") {
            $(this).parent().parent().parent().hide();
            var questionid = $(this).attr("questionid");
            $.ajax({
                data: "{ questionid:'" + questionid + "' }",
                dataType: "json",
                url: "ws.asmx/delMyQuestion",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });
        }
        else {
            $(".zqq-menban").show();
            $(".zqq-jubao-inner").show();

            var jubaoQuestionID = $(this).attr("questionid");
            $(".zqq-jubao-submit").attr("questionid", jubaoQuestionID);
        }
        
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
    $(".zqq-side-li4").hover(function () {
        $(".zqq-icon-myQuestion").css("background-position", "-152px -24px");
    }, function () {
        $(".zqq-icon-myQuestion").css("background-position", "-152px -4px");
    });


    $(window).scroll(function () {
        var top = $(this).scrollTop();
        if (top - 650 < 0) {
            $(".zqq-lm2").removeClass("fixed");
        }
        else {
            $(".zqq-lm2").addClass("fixed");


        }
    });

    $(".zqq-head-photo").hover(function () {
        checkcareperson();
        $(this).find(".zqq-goog-hovercard").show();
    }, function () {
        $(this).find(".zqq-goog-hovercard").hide();
    });

    
});

function panduan() {
    $.each($(".zqq-follow-topic-button"), function () {
        if ($(this).attr("panduan") == "true") {
            $(this).html("取消关注");
        }
    });
}

function CheckQusetionProvider() {
    $.each($(".zqq-jubao"), function () {
        if ($(this).attr("CheckQusetionProvider") == "myQuestion") {
            $(this).html("删除");
        }
    });
}

function checkcareperson() {
    $.each($(".zqq-zg-btn-follow "), function () {
        if ($(this).attr("checkcareperson") == "follow") {
            $(this).html("取消关注");
        }
        else if ($(this).attr("checkcareperson") == "myself") {
            $(this).hide();
            $(this).next().hide();
        }
    });
}