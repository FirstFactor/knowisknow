 var ue;
$(function () {
    ue = UE.getEditor('container', {

    });
 

    $("#wkreply").click(function () {

        questionid = $(this).attr("quesid");
        uid=$("#getuserid").attr("uid");
        content = ue.getContent();

        replyofreplyid = 0;
        $.ajax({
            data: "{ 'replyquestionID':'" + questionid + "','replyofuid':'" + uid + "','replycontent':'"+content+"','replyofreplyid':'"+replyofreplyid+"'}",
            dataType: "json",
            url: "ws.asmx/Reply",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                if (res.d == "ok") {
                    location.reload();
                }
            }

        });
    });
    $(".toggle-comment").click(function () {
        var isopen = $(this).attr("isOpen");
        if (isopen == 1) {
            $(this).parent().next().show();
            $(this).attr("isOpen", "0");
        }
        else {
            $(this).parent().next().hide();
            $(this).attr("isOpen", "1");
        }
        replyofreplyid = 10;
        questionid = $(this).attr("quesid");
        uid = $("#getuserid").attr("uid");
        $.ajax({
            data: "{ 'replyquestionID':'" + questionid + "','replyofuid':'" + uid + "','replycontent':'" + content + "','replyofreplyid':'" + replyofreplyid + "'}",
            dataType: "json",
            url: "ws.asmx/Reply",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                if (res.d == "ok") {
                    location.reload();
                }
            }

        });
    })

});