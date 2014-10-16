$(function () {
    $(".zqq-follow-topic-button").click(function () {
        $(this).toggleClass("zqq-display");
        $(".zqq-noFollow-topic-button").toggleClass("zqq-display");
    });
    $(".zqq-noFollow-topic-button").click(function () {
        $(this).toggleClass("zqq-display");
        $(".zqq-follow-topic-button").toggleClass("zqq-display");
    });

    $(".zqq-question-detail").hover(function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").show();
    }, function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").hide();
    });

    $(document).on("click", ".zqq-jubao", function () {
        $(".zqq-menban").show();
        $(".zqq-jubao-inner").show();
    });

    $(".zqq-jubao-checked1").click(function () {
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked2").click(function () {
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked3").click(function () {
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked4").click(function () {
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked5").click(function () {
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").show();
    });

    $(".zqq-jubao-submit").click(function () {
        var checked5 = $(".zqq-jubao-checked5").attr("mark");
        var checked4 = $(".zqq-jubao-checked4").attr("mark");
        var checked3 = $(".zqq-jubao-checked3").attr("mark");
        var checked2 = $(".zqq-jubao-checked2").attr("mark");
        var checked1 = $(".zqq-jubao-checked1").attr("mark");
        if (checked1==0 && checked2==0 && checked3==0 && checked4==0 && checked5==0 ) {
            alert("请选择举报原因！");
            return false;
        }
        if(checked5==1){
            var juaboReason =$(".zqq-jubao-otherReason").val();
            if(juaboReason==""){
                alert("请输入举报原因!");
                return false;
            }
        }
        $(".zqq-menban").hide();
        $(".zqq-jubao-inner").hide();
        $(".zqq-jubao-otherReason").hide();
        $(".zqq-jubao-chose-main li label input").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(".zqq-jubao-otherReason").val("");
    });

    //举报框拖动
    $(".zqq-jubao-inner").draggable({
        handle: ".zqq-tiwen-menban-title",
        containment: "parent"
    });
});