$(function () {
    $.ajax({
        data: {},
        dataType: "json",
        url: "ws.asmx/HelloWorld",
        type: "post",
        contentType: "application/json",
        success: function (res) {
            //alert(res.d);
        }
    });
    var userid = $(".eee").html();
    //alert(userid);
    $(".kaishi").click(function () {
        $(".view").hide();
        $(".followtopic").show();
    });

    $(".box").hover(function () {
       
      
        $(this).find(".extra_info").hide();
        $(this).find(".follow_tip").show();
    }, function () {
        var state = $(this).find(".zhuangtai").attr("state");
        if (state == 1) {
            return false;
        }
        $(this).find(".extra_info").show();
        $(this).find(".follow_tip").hide();
    });


    $(".box").click(function () {
        var state = $(this).find(".zhuangtai").attr("state");
        var topicid = $(this).find(".bbb").html();
       
        if (state == 0) {
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WS.asmx/AddCareTopic",
                data: "{topicid:'" + topicid + "',userid:'" + userid + "'}",
                dataType: 'json',
                success: function (result) {
                   
                }
            });
            
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WS.asmx/updatatopicinfo",
                data: "{topicID:'" + topicid + "'}",
                dataType: 'json',
                success: function (result) {
                    //alert(result.d);
                }
            });
            
            $(this).find(".zhuangtai").html("已关注");
            $(this).find(".zhuangtai").attr("state", 1);
        } else {
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WS.asmx/DeleteCareTopic",
                data: "{topicid:'" + topicid + "',userid:'" + userid + "'}",
                dataType: 'json',
                success: function (result) {
                    
                }
            });

            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WS.asmx/deltopicAttention",
                data: "{topicID:'" + topicid + "'}",
                dataType: 'json',
                success: function (result) {
                     
                }
            });

            $(this).find(".zhuangtai").html("关注");
            $(this).find(".zhuangtai").attr("state", 0);
        }
    });
})