var ue;
$(function () {
    ue = UM.getEditor('container', {

    });
    ue.setHeight(300);

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

});