$(function () {
    $(".kaishi").click(function () {
        $(".view").hide();
        $(".followtopic").show();
    });

    $(".box").hover(function () {
      
        $(this).find(".extra_info").hide();
        $(this).find(".follow_tip").show();
    }, function () {
        $(this).find(".extra_info").show();
        $(this).find(".follow_tip").hide();
    });


    $(".box").click(function () {
        var state = $(this).find(".zhuangtai").attr("state");
        if (state==0) {
            $(this).find(".zhuangtai").html("已关注");
            $(this).find(".zhuangtai").attr("state", 1);
        } else {
            $(this).find(".zhuangtai").html("关注");
            $(this).find(".zhuangtai").attr("state", 0);
        }
    });
})