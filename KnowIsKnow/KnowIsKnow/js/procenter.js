var userid;
$(function () {

  
   
    $("#quanUpload").click(function () {
        $("#mengban").show();
        $("#uploadArea").show();
    });


     var gen = $("#wtsp").attr("xingbie");
    if (gen == "男") {
        $(".male").attr("checked","checked");
        $(".wticon-male").addClass("wticon-profile-male");
    }
    if (gen == "女") {
        $(".female").attr("checked", "checked");
        $(".wticon-male").addClass("wticon-profile-female");
    }
    $(".zqymale").click(function () {
        $(".wtlikebtn1").addClass("wtlikebtnselected");
        $(".wtlikebtn2").removeClass("wtlikebtnselected");
    });
    $(".zqyfemale").click(function () {
        $(".wtlikebtn2").addClass("wtlikebtnselected");
        $(".wtlikebtn1").removeClass("wtlikebtnselected");
    });



    $(".zqymale").click(function () {
        $(".ssss").attr("value","男");
    });
    $(".zqyfemale").click(function () {
        $(".ssss").attr("value", "女");
    });
    var xingbie = $("#xingbie11").attr("value");
    if (xingbie == "男")
    {
        $(".wtlikebtn1").addClass("wtlikebtnselected");
        $(".wtlikebtn2").removeClass("wtlikebtnselected");
    }
    if (xingbie == "女") {
        $(".wtlikebtn2").addClass("wtlikebtnselected");
        $(".wtlikebtn1").removeClass("wtlikebtnselected");
    };
    

    userid = $(".wtellipsis").attr("uid");

    var ju = $(".wtzg-form-text-input0").val();
    if (ju == "") {
        var html = '<a class="wtzg-link-litblue-normal">填写居住地</a>';
        $(".wtlocation").html(html);
    }
    else {
        $(".wtlocation").html(ju);
    }
    var hangye = $(".wtbusiness-selection2").val();
    if (hangye == "" || hangye == "选择行业") {
        var html = '<a class="wtzg-link-litblue-normal" name="edit">填写行业</a>';
        $(".wthangye").html(html);

    }
    else {
        $(".wthangye").html(hangye);

    }

    var gen2 = $("#wtsp").attr("xingbie");
    if (gen2 == "男") {
        $(".male").attr("checked","checked");
        $(".wticon-male").addClass("wticon-profile-male");
    }
    if (gen2 == "女") {
        $(".female").attr("checked", "checked");
        $(".wticon-male").addClass("wticon-profile-female");
    }

    
  
        
    var work = $(".wtzg-form-text-input2").val();
    if (work == "") {
        var html = '<a class="wtzg-link-litblue-normal">填写工作信息</a>';
        $(".wtinfo21").html(html);
    }
    else {
        $(".wtinfo21").html(work);
    }
    var po = $(".wtzg-form-text-input3").val();
   
    if (po == "") {
        var html = '<a class="wtzg-link-litblue-normal">填写职位</a>';
        $(".wtinfo22").html(html);
        
    }
    else {
        $(".wtinfo22").html(po);
    }
    if (work == "" && po == "") {
        var html1 = '<a class="wtzg-link-litblue-normal">填写工作信息</a>';
        $(".wtinfo21").html(html1);
        var html2 = '<a class="wtzg-link-litblue-normal"></a>';
        $(".wtinfo22").html(html2);
    }


    var school = $(".wtzg-form-text-input4").val();
    if (school == "") {
        var html = '<a class="wtzg-link-litblue-normal">填写学校信息</a>';
        $(".wtinfo31").html(html);
    }
    else {
        $(".wtinfo31").html(school);
    }
    var zhuanye = $(".wtzg-form-text-input5").val();
    if (zhuanye == "") {
        var html = '<a class="wtzg-link-litblue-normal">填写专业</a>';
        $(".wtinfo32").html(html);
    }
    else {
        $(".wtinfo32").html(zhuanye);
    }
    if (school == "" && zhuanye == "") {
        var html1 = '<a class="wtzg-link-litblue-normal">填写教育信息</a>';
        $(".wtinfo31").html(html1);
        var html2 = '<a class="wtzg-link-litblue-normal"></a>';
        $(".wtinfo32").html(html2);
    }
    
    var geren = $(".wtzm-editable-editor-input1").val();
    if (geren == "") {
        var html = "";
        html += '<a name="edit" class="wtzg-link-litblue-normal">';
        html += '	<i class="wtzg-icon wtzg-icon-edit-button-blue wticon"></i>';
        html += '   <span>填写个人简介</span>';
        html += '</a>';
        $(".wtgerenjianjie").html(html);
    }
    else {
        $(".wtgerenjianjie").html(geren);
    }



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
    $(".wthangye").click(function () {
        $(".wtinfo-wrap").hide();
        $(".wtedit-wrap").show();
    });
    $(".wtbtnblue1").click(function () {
        var ju = $(".wtzg-form-text-input0").val();
        if (ju == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写居住地</a>';
            $(".wtlocation").html(html);
        }
        else {
            $(".wtlocation").html(ju);
        }
        var hangye = $(".wtbusiness-selection2").val();
        if (hangye == "" || hangye == "选择行业") {
            var html = '<a class="wtzg-link-litblue-normal" name="edit">填写行业</a>';
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

        var address = $(".wtzg-form-text-input0").val();
        var job = $(".wtbusiness-selection2").val();
        var gender;
        if (nan == 1) {
            gender = '男';
        }
        if (nv == 1) {
            gender = '女';

        }
        
        $.ajax({
            data: "{'address':'" + address + "','job':'" + job + "','gender':'" + gender + "','userid':'" + userid + "' }",
            dataType: "json",
            url: "ws.asmx/updateUserAddressJobGender",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                
            }

        });
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
        var work = $(".wtzg-form-text-input2").val();
        if (work == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写工作信息</a>';
            $(".wtinfo21").html(html);
        }
        else {
            $(".wtinfo21").html(work);
        }
        var po = $(".wtzg-form-text-input3").val();
        if (po == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写职位</a>';
            $(".wtinfo22").html(html);
        }
        else {
            $(".wtinfo22").html(po);
        }
        if (work == "" && po == "") {
            var html1 = '<a class="wtzg-link-litblue-normal">填写工作信息</a>';
            $(".wtinfo21").html(html1);
            var html2 = '<a class="wtzg-link-litblue-normal"></a>';
            $(".wtinfo22").html(html2);
        }

        $(".wtinfo2").show();
        $(".wtedit-wrap2").hide();

        var company = $(".wtzg-form-text-input2").val();
        var position = $(".wtzg-form-text-input3").val();
       
        $.ajax({
            data: "{'company':'" + company + "','position':'" + position + "','userid':'" + userid + "'}",
            dataType: "json",
            url: "ws.asmx/updateUserCompanyPosition",
            type: "post",
            contentType: "application/json",
            success: function (res) {
              
            }

        });

    });
    $(".wtinfo3").click(function () {
        $(".wtinfo3").hide();
        $(".wtedit-wrap3").show();
    });
    $(".wtbtnblue3").click(function () {
        var school = $(".wtzg-form-text-input4").val();
        if (school == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写学校信息</a>';
            $(".wtinfo31").html(html);
        }
        else {
            $(".wtinfo31").html(school);
        }
        var zhuanye = $(".wtzg-form-text-input5").val();
        if (zhuanye == "") {
            var html = '<a class="wtzg-link-litblue-normal">填写专业</a>';
            $(".wtinfo32").html(html);
        }
        else {
            $(".wtinfo32").html(zhuanye);
        }
        if (school == "" && zhuanye == "" ) {
            var html1 = '<a class="wtzg-link-litblue-normal">填写教育信息</a>';
            $(".wtinfo31").html(html1);
            var html2 = '<a class="wtzg-link-litblue-normal"></a>';
            $(".wtinfo32").html(html2);
        }
        $(".wtinfo3").show();
        $(".wtedit-wrap3").hide();

        var academy = $(".wtzg-form-text-input4").val();
        var major = $(".wtzg-form-text-input5").val();
        
        $.ajax({
            data: "{'academy':'" + academy + "','major':'" + major + "','userid':'" + userid + "'}",
            dataType: "json",
            url: "ws.asmx/updateUserAcademyMajor",
            type: "post",
            contentType: "application/json",
            success: function (res) {
              
            }

        });
    });
    $(".wtgerenjianjie").click(function () {
        $(".wtgerenjianjie").hide();
        $(".wtedit-wrap4").show();
    });
    $(".wtbtnblue").click(function () {
        var geren = $(".wtzm-editable-editor-input1").val();
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

        var bio = $(".wtzm-editable-editor-input1").val();
    
        $.ajax({
            data: "{'bio':'" + bio + "','userid':'" + userid + "'}",
            dataType: "json",
            url: "ws.asmx/updateUserBio",
            type: "post",
            contentType: "application/json",
            success: function (res) {
           
            }

        });

    });

    $(".male").click(function () {
        $(".male").attr("value", 1);
        $(".female").removeAttr("checked");
        $(".male").attr("checked", "checked");
      
        $(".female").attr("value", 0);
    });
    $(".female").click(function () {
        $(".female").attr("value", 1);
        $(".male").removeAttr("checked");
        $(".female").attr("checked", "checked");
        $(".male").attr("value", 0);
    });


   
    /********全峻佚修改上传头像*********/

 
  
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

/******全峻佚 修改上传头像*********/