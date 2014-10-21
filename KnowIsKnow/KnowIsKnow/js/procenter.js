$(function () {

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

    /********全峻佚修改上传头像*********/

    upload();
    $("#mengban").css({'opacity': 0.3,'height':$(window).height()});


    $("#upAreaClose").click(function () {
        $("#mengban").hide();
        $("#uploadArea").hide();

    });
    $(".wtzm-profile-header-img").click(function () {
        $("#mengban").show();
        $("#uploadArea").show();

    });


    /********全峻佚修改上传头像*********/
});



/******全峻佚 修改上传头像*********/
function upload() {

    $("#uploadify").uploadify({
        'uploader': 'js/uploadify.swf',
        'script': 'Upload.aspx',
        'cancelImg': 'js/cancel.png',
        'folder': 'images/headimages',
        'queueID': 'fileQueue',
        'auto': false,
        'multi': true,
        'onComplete': function (file, data, response, i, o) { //上传成功回调方法
            if (i ==1) {
                alert("请选择png,jpg,gif,bmp格式的图片");
                return;
            }
            var uid=$(".wtellipsis").attr("uid");
            $.ajax({
                data: "{headimg:'" + i + "',userid:'"+uid+"'}",           
                dataType: "json",
                url: "ws.asmx/updateUserHeadimg",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    if(res.d=="True")
                    {
                        alert("传输完成！");
                    }
                }

            });

           
        }
    });

}
/******全峻佚 修改上传头像*********/