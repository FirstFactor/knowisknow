$(function () {
    $(".admininput").click(function () {
        $(this).val("");
    })

    $(".admininput").blur(function () {
        var email = $(this).val();
        if (email == "") {
            $(this).val("AdminEmail");
        }
    })



    $(".dianjijinru").hover(function () {
        $(this).css({ "background-color": "#FFF", "color": "#6c496f" });
    }, function () {
        $(this).css({ "background-color": "#6c496f", "color": "#FFF" });
    });
})