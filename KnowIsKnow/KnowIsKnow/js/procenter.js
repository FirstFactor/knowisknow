$(function () {
    alert("123456");
    $(".wtlocation").click(function () {
        $(".wtinfo-wrap").hide();
        $(".wtedit-wrap").show();
    });
    $(".wtbtnblue1").click(function () {
        $(".wtinfo-wrap").show();
        $(".wtedit-wrap").hide();
    });
    $(".wtit").hover(function () {
        $(".wtzubtn").addClass("wtzu-edit-button2");
    }, function () {
        $(".wtzubtn").removeClass("wtzu-edit-button2");
    });
    $(".wtzubtn").click(function () {
        $(".wtinfo-wrap").hide();
        $(".wtedit-wrap").show();
    });
    $(".wtinfo2").click(function () {
        $(".wtinfo2").hide();
        $(".wtedit-wrap2").show();
    });
    $(".wtbtnblue2").click(function () {
        $(".wtinfo2").show();
        $(".wtedit-wrap2").hide();
    });
    $(".wtinfo3").click(function () {
        $(".wtinfo3").hide();
        $(".wtedit-wrap3").show();
    });
    $(".wtbtnblue3").click(function () {
        $(".wtinfo3").show();
        $(".wtedit-wrap3").hide();
    });
    $(".wtgerenjianjie").click(function () {
        $(".wtgerenjianjie").hide();
        $(".wtedit-wrap4").show();
    });
    $(".wtbtnblue").click(function () {
        $(".wtgerenjianjie").show();
        $(".wtedit-wrap4").hide();
    });

  
});
