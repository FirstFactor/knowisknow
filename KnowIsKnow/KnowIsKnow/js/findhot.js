$(function () {

    $(".zmxtab-nav").click(function () {
        $(".zmxtab-nav").removeClass("active");

        $(this).addClass("active");

    });
    $("#zmxtabpanelmou").css("display", "none");
    $(".zmxhot").click(function () {
        $(".zmxtab-panel").css("display", "block");
        $("#zmxtabpanelmou").css("display", "none");
    })
    $(".zmxmhot").click(function () {
        $(".zmxtab-panel").css("display", "none");
        $("#zmxtabpanelmou").css("display", "block");
    })
    $(".zmxpanel").hover(function () {
        $(".zmxpanel3").show();
        $(".zmxpanel4").show();
        $(".zmxpanel5").show();
        $(".zmxpanel6").show();
        $(".zmxdian").show();

    }, function () {
        $(".zmxpanel3").hide();
        $(".zmxpanel4").hide();
        $(".zmxpanel5").hide();
        $(".zmxpanel6").hide();
        $(".zmxdian").hide();
        $(".zmxpanel3give").hide();
    });
    $(".zmxex").click(function () {
        $(this).parent().next().css("display", "block");
        $(this).parent().next().next().css("display", "block");
        $(this).parent().next().next().next().css("display", "block");
        $(this).parent().css("display", "none");
    })
    $(".zmxcollapse").click(function () {
        $(".zmxshouqi").css("display", "none");
        $(".zmxhidecontent").css("display", "none");
        $(".zmxdate").css("display", "none");
        $(".zmxrich").css("display", "block");
    })
    $(".zmxpanel1").click(function () {
        $(".zmxpanel1").css("display", "none");
        $(".zmxpanel1give").show();
    })
    $(".zmxpanel1give").click(function () {
        $(".zmxpanel1").show();
        $(".zmxpanel1give").hide();
    })
    $(".zmxpanel3").click(function () {
        $(".zmxpanel3give").show();
        $(".zmxpanel3").hide();
    })
});