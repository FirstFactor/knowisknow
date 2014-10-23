$(function () {

    $(".zqq-follow-topic-button").click(function () {
        $(this).toggleClass("zqq-display");
        $(this).next().toggleClass("zqq-display");

        var questionid = $(this).parent().parent().parent().find(".zqq-question-title").attr("questionid");
        var userid = $(".userid").attr("userid");
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
    });
    $(".zqq-noFollow-topic-button").click(function () {
        $(this).toggleClass("zqq-display");
        $(this).prev().toggleClass("zqq-display");

        var questionid = $(this).parent().parent().parent().find(".zqq-question-title").attr("questionid");
        var userid = $(".userid").attr("userid");
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
    });

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

    
});