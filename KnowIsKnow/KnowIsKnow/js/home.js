$(function () {
    $(".zqq-question-detail").hover(function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").show();
    }, function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").hide();
    });
});