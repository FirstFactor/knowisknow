$(function () {
    
    $(".first").hover(function () {
        $("#first").show();
    }, function () {
        $("#first").hide();
    });

    $(".second").hover(function () {
        $("#second").show();
    }, function () {
        $("#second").hide();
    });

    $(".third").hover(function () {
        $("#third").show();
    }, function () {
        $("#third").hide();
    });
    $(".zu-button-more").hover(function () {
        $("#item").show();
    });
    $(".zg-follow").click(function () {
        $(this).parent().find(".zg-special").show();
    });
    $(".meta-item").click(function () {
        
        var userid = $("#ymid").html();
        var topicid = $(this).attr("thid");
       
        var abc = $(this).attr("teshu");
        
        if (abc == "false") {
            $(this).html("取消关注");
            $.ajax({
                data: "{ topicid:'" + topicid + "', userid:' " + userid + "' }",
                dataType: "json",
                url: "ws.asmx/AddCareTopic",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });
            

            $(this).attr("teshu", "true");
            
        }
        else {
            $(this).html("<i class='z-icon-follow'></i>关注");
            $.ajax({
                data: "{ topicid:'" + topicid + "', userid:' " + userid + "' }",
                dataType: "json",
                url: "ws.asmx/DeleteCareTopic",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });
            $(this).attr("teshu", "false");
        } 
    });
    xianshi();
});

function xianshi() {
    $.each($(".meta-item"), function () {
        if ($(this).attr("teshu") == "true") {
            $(this).html("取消关注");
        }
    });
        
   

    }