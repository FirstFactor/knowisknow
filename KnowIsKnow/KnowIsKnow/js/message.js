$(function () {
    $("#wk-pm").click(function () {
        $(".mengban").css("opacity", "0.6");
        $(".mengban").show();
        $(".modal-dialog").show();
        $(".modal-dialog-title-close").click(function () {
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
        $(".zm-command-cancel").click(function () {
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
    })
})