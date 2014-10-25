$(function () {
    //点击“账号-修改”
    clickbtn1();

    clickli();

    var userid = $(".hquserid").html();
    $(".xiugaimz").click(function () {
        var xing = $("#zqyxing").val();
        var ming = $("#zqyming").val();
        var name = xing + ming;
        if (name=="") {
            $(".bcxinxi").html("姓名不能为空！");
            $(".baocuntip").show();
        }
        if (name != "") {
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WS.asmx/updataName",
                data: "{userid:'" + userid + "',name:'" + name + "'}",
                dataType: 'json',
                success: function (result) {
                    $(".bcxinxi").html("姓名修改成功！");
                    $(".baocuntip").show();
                    $("#zqyxing").val("");
                    $("#zqyming").val("");
                }
            });
        }
    });



    $(".baocunmima").click(function () {
        var yuanmima = $(".hquserpwd").html();
        var dangqianmima = $(".dqmima").val();
        var xindemima = $(".xdmima").val();
        var querenmima = $(".qrmima").val();
        
 
        //if (yuanmima != dangqianmima) {
        //    $(".bcxinxi").html("原密码输入不正确，请正确输入！");
        //    $(".baocuntip").show();
        //}
        if (xindemima != querenmima) {
            $(".bcxinxi").html("两次输入密码不一致，请重新输入！");
            $(".baocuntip").show();
        }
        if (dangqianmima !="" && xindemima == querenmima) {
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WSZQY.asmx/updataPwd",
                data: "{userid:'" + userid + "',userpwd:'" + xindemima + "',shurumima:'" + dangqianmima + "',yuanlaimima:'" + yuanmima + "'}",
                dataType: 'json',
                success: function (result) {
                    if (result.d == "no") {
                        $(".bcxinxi").html("原密码输入不密码，请重新输入！");
                        $(".baocuntip").show();
                    } else {
                        $(".bcxinxi").html("密码修改成功！");
                        $(".baocuntip").show();
                        $(".dqmima").val("");
                        $(".xdmima").val("");
                        $(".qrmima").val("");
                    }
                   
                }
            });
        }
      
    });


    $(".queding").click(function () {
        $(".baocuntip").hide();
    });
});


//点击“账号-修改”

function clickbtn1() {

    $(".zu-edit-button").click(function () {
       // alert("d");
        $(this).next().show();

    });


}
//点击表单选项时

function clickli() {

    $(".tn1").click(function () {

        //alert("d");
        $(".f1").removeClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");

        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn2").click(function () {

        //alert("d");
        $(".f2").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn1").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn3").click(function () {

        //alert("d");
        $(".f3").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });


    $(".tn4").click(function () {

        //alert("d");
        $(".f4").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn5").click(function () {

        //alert("d");
        $(".f5").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn6").click(function () {

        //alert("d");
        $(".f6").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn7").click(function () {

        //alert("d");
        $(".f7").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");



        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });





}