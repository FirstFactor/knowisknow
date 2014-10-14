$(function () {
    //alert("ok");
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
        $(this).parent().find(".spanshow").hide();
        $(this).parent().find(".spanshow").next().show();
    });
    //假删操作
    $(".adshanchu").click(function () {
        var val = 'deleted';
        $(this).parent().find(".adComboxInput").prev().html(val);
        $(this).parent().find(".adComboxInput").next().html(val);
        $(this).html("已删除");
    });
});