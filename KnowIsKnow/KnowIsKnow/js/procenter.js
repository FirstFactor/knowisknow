$(function () {
    $("#wtfanhuigerenzhuye").click(function () {
        $(".wtzu-main-content-inner").show();
        $(".wtzu-main-content-inner2").hide();
    });
    $("#wtbianjiwodeziliao").click(function () {
        $(".wtzu-main-content-inner").hide();
        $(".wtzu-main-content-inner2").show();
    });
    $(".wtlocation").click(function () {
        $(".wtinfo-wrap").hide();
        $(".wtedit-wrap").show();
    });
    $(".wtbtnblue1").click(function () {
        var ju = $(".wtzg-form-text-input").val();
        if (ju == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写居住地</a>';
            $(".wtlocation").html(html);
        }
        else {
            $(".wtlocation").html(ju);
        }
        var hangye = $(".wtbusiness-selection2").val();
        if (hangye == "") {
            var html = '<a class="zg-link-litblue-normal" name="edit">填写行业</a>';
            $(".wthangye").html(html);
        }
        else {
            $(".wthangye").html(hangye);
        }
        var nan = $(".male").attr("value");
        if (nan == 1) {
            $(".wticon-male").addClass("wticon-profile-male");
        }
        else {
            $(".wticon-male").removeClass("wticon-profile-male");
        }

        var nv = $(".female").attr("value");
        if (nv == 1) {
            $(".wticon-male").addClass("wticon-profile-female");
        }
        else {
            $(".wticon-male").removeClass("wticon-profile-female");
        }
        
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
        var ju = $(".wtzg-form-text-input2").val();
        if (ju == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写工作信息</a>';
            $(".wtinfo21").html(html);
        }
        else {
            $(".wtinfo21").html(ju);
        }
        var work = $(".wtzg-form-text-input3").val();
        if (work == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写职位</a>';
            $(".wtinfo22").html(html);
        }
        else {
            $(".wtinfo22").html(work);
        }
        if (ju == "" && work == "") {
            var html1 = '<a class="wtzg-link-litblue-normal">填写工作信息</a>';
            $(".wtinfo21").html(html1);
            var html2 = '<a class="wtzg-link-litblue-normal"></a>';
            $(".wtinfo22").html(html2);
        }

        $(".wtinfo2").show();
        $(".wtedit-wrap2").hide();
    });
    $(".wtinfo3").click(function () {
        $(".wtinfo3").hide();
        $(".wtedit-wrap3").show();
    });
    $(".wtbtnblue3").click(function () {
        var ju = $(".wtzg-form-text-input4").val();
        if (ju == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写学校信息</a>';
            $(".wtinfo31").html(html);
        }
        else {
            $(".wtinfo31").html(ju);
        }
        var work = $(".wtzg-form-text-input5").val();
        if (work == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写专业</a>';
            $(".wtinfo32").html(html);
        }
        else {
            $(".wtinfo32").html(work);
        }
        if (ju == "" && work == "") {
            var html1 = '<a class="wtzg-link-litblue-normal">填写教育信息</a>';
            $(".wtinfo31").html(html1);
            var html2 = '<a class="wtzg-link-litblue-normal"></a>';
            $(".wtinfo32").html(html2);
        }
        $(".wtinfo3").show();
        $(".wtedit-wrap3").hide();
    });
    $(".wtgerenjianjie").click(function () {
        $(".wtgerenjianjie").hide();
        $(".wtedit-wrap4").show();
    });
    $(".wtbtnblue").click(function () {
        var geren = $(".wtzm-editable-editor-input").val();
        if (geren == "") {
            var html="";
             html += '<a name="edit" class="wtzg-link-litblue-normal">';
             html += '	<i class="wtzg-icon wtzg-icon-edit-button-blue wticon"></i>';
             html += '   <span>填写个人简介</span>';
             html += '</a>';
            $(".wtgerenjianjie").html(html);
        }
        else {
            $(".wtgerenjianjie").html(geren);
        }

        $(".wtgerenjianjie").show();
        $(".wtedit-wrap4").hide();
    });

    $(".male").click(function () {
        $(".male").attr("value",1);
        $(".female").attr("value", 0);
    });
    $(".female").click(function () {
        $(".female").attr("value", 1);
        $(".male").attr("value", 0);
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