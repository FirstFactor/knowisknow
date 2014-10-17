$(function () {
    $(".ghmiddlecontentleftcontentdivdivdivguanzhutitlea2").click(function () {
        $(this).parent().find(".ghmiddlecontentleftcontentdivdivdivguanzhutitlea2").addClass("guanzhuhuatispecial");
        $(this).parent().find(".ghmiddlecontentleftcontentdivdivdivguanzhutitlea2").show();
        $(this).removeClass("guanzhuhuatispecial");
        $(this).hide();
    });
    $("#ghmiddlecontentrightbottoma").hover(function () {

        $(this).find("#ghmiddlecontentrightbottomaspan").css({ "text-decoration": "underline", "color": "#259" });
        $(this).find("#ghmiddlecontentrightbottomap").css("background-position", "-234px -24px")
    }, function () {

        $(this).find("#ghmiddlecontentrightbottomaspan").css({ "text-decoration": "none", "color": "#666" });
        $(this).find("#ghmiddlecontentrightbottomap").css("background-position", "-234px -4px")
    });
    $(".ghmiddlecontentleftcontentdiv").hover(function () {
        $(this).find(".ghmiddlecontentleftcontentdivdiv").find(".ghmiddlecontentleftcontentdivdivdiv").find(".ghmiddlecontentleftcontentdivdivdivguanzhutitle").find(".guanzhuhuatispecial").show();
    }, function () {
        $(this).find(".ghmiddlecontentleftcontentdivdiv").find(".ghmiddlecontentleftcontentdivdivdiv").find(".ghmiddlecontentleftcontentdivdivdivguanzhutitle").find(".guanzhuhuatispecial").hide();
    });
    $(".ghgzchuangquhuati").hover(function () {

        $(this).find(".ghgzchuangquhuatidiv").find(".ghgzchuangquhuatidivcontent").find(".ghgzchuangquhuatidivcontentnumber").find(".ghycbuttom").css("visibility", "visible");
    }, function () {
        $(this).find(".ghgzchuangquhuatidiv").find(".ghgzchuangquhuatidivcontent").find(".ghgzchuangquhuatidivcontentnumber").find(".ghycbuttom").css("visibility", "hidden");

    });
    $(".bianjibuttom").click(function () {
        $(this).parent().parent().parent().parent().hide();
    });
    $(".quxiaoguanzhu").click(function () {
        $(this).parent().parent().parent().parent().hide();
    });


});