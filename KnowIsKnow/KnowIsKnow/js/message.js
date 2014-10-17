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
    $(".zm-pm-user-selector").keyup(function ()
    {
       
        $(".ac-renderer").show();
        $(".ac-row").hover(function () {

            $(this).addClass("ac-active");
        }, function () {
            $(this).removeClass("ac-active");
        })
        $(".ac-row").click(function () {
            var nickname = $(this).find(".zu-autocomplete-row-name").text();
            var mail = $(this).find(".zu-autocomplete-row-description").text();
            $(".zg-form-text-input").val(nickname + mail);
            $(".ac-renderer").hide();
        })
    })
})