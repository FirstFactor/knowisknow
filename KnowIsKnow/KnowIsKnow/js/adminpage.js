$(function () {
    //alert("ok");

    $(".submit").css("display", "none");
    $(".adTopicTitleInput").keypress(function (e) {
        if (e.keyCode == 13) {

            $(this).hide();
            $(this).prev().html($(this).val());
            $(this).prev().show();
            return false;
        }

         return false;
        
    });

    

    $(".adTopicDesInput").keypress(function (e) {
        if (e.keyCode == 13) {
            $(this).hide();
            $(this).prev().html($(this).val());
            $(this).prev().show();
            return false;
        }
        return false;
    });

    $(".spanshow").show();
    $(".spanshow").next().hide();
    $(".adNavOperation li").click(function () {
        //选项卡选中后样式
        $(".adNavOperation li").removeClass("adNavActive");
        $(this).addClass("adNavActive");

        //显示对应选项卡内容
        var linkclass = $(this).find("span").attr("linkclass");
        $(".adOperaDetail").hide();
        $("." + linkclass).show();
    });

    $(".adCombox").click(function () {
        var IsOpen = $(this).attr("IsOpen");
        if (IsOpen == "false") {
            $(this).find(".adStateList").show();
            $(this).attr("IsOpen", "true");
        } else {
            $(this).find(".adStateList").hide();
            $(this).attr("IsOpen", "false");
        }
    });
    $(document).on("click", ".adStateli", function () {
        var val = $(this).html();
        $(this).parent().parent().find(".adComboxSpan").html(val);
    })
    //修改操作
    $(".adxiugai").click(function () {

       

        $(this).parent().find(".adTopicTitleInput").val($(this).parent().find(".spanTitle").html());
        
        $(this).parent().find(".adTopicDesInput").val($(this).parent().find(".spanContent").html());


        $(this).parent().find(".spanshow").hide();
        $(this).parent().find(".spanshow").next().show();

        $(this).hide();//隐藏修改按钮
        $(this).next().show();//显示确认按钮
    });

    $(".submit").click(function () {
        $(this).hide();//隐藏确认按钮
        $(this).prev().show();//显示修改按钮
        
        $(this).parent().find(".spanTitle").html($(this).parent().find(".adTopicTitleInput").val());
        $(this).parent().find(".spanContent").html( $(this).parent().find(".adTopicDesInput").val());
        $(this).parent().find(".topicstate").html($(this).parent().find(".selectedtopicstate").html());
        $(this).parent().find(".spanshow").show();
        $(this).parent().find(".spanshow").next().hide();

        thistopicid = $(this).parent().attr("topicinfoid");
        thistopicTitle = $(this).parent().find(".adTopicTitleInput").val();
        thistopicDesc = $(this).parent().find(".adTopicDesInput").val();
        thistopicPicUrl = "1";
        thistopicAttention = $(this).parent().find(".topicAttention").html();
        thistopicState = $(this).parent().find(".selectedtopicstate").html();
       
        $.ajax({
            data: { "topicid": thistopicid, "topictitle": thistopicTitle, "topicdes": thistopicDesc, "topicpicurl": thistopicPicUrl, "topicattention": thistopicAttention, "topicstate": thistopicState },
            datatype: "json",
            url: "ws.asmx/UpdateTopicInfo",
            type: "post",
            contenttype: "application/json",
            success: function (res) {
                alert(res.d);
            }

        });
        
    });
        
    
    //假删操作
    $(".adshanchu").click(function () {
        var val = 'deleted';
        $(this).parent().find(".adComboxInput").prev().html(val);
        $(this).parent().find(".adComboxInput").next().html(val);
        $(this).html("已删除");
    });


    
});