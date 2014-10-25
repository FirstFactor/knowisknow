$(function () {
    $(".czmima").click(function () {
        var fmima = $("#diyici").val();
        var smima = $("#dierci").val();
       
        var userid = $(".uid").html();
        var xuliehao = $("#xuliehao").val();
        var sxuliehao = $(".yanzheng").html();
        $(".fault").html("");
        if (fmima =="" || smima == "") {
            var html = "<div style='color:#FFF;font-size:12px;padding:5px 8px;'>密码不能为空！</div>";
            $(".fault").append(html);
            $(".fault").show();
        }

        if (fmima != smima) {
            var html = "<div style='color:#FFF;font-size:12px;padding:5px 8px;'>两次密码输入不一致！</div>";
            $(".fault").append(html);
            $(".fault").show();
        };
        if (xuliehao == "") {
            var html = "<div style='color:#FFF;font-size:12px;padding:5px 8px;'>序列号不能为空！</div>";
            $(".fault").append(html);
            $(".fault").show();
            return false;
        }
        
        if (xuliehao != sxuliehao) {
            var html = "<div style='color:#FFF;font-size:12px;padding:5px 8px;'>序列号不正确！</div>";
            $(".fault").append(html);
            $(".fault").show();
        }

        if (fmima !="" && fmima==smima && xuliehao == sxuliehao) {
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WSZQY.asmx/chongzhimima",
                data: "{userid:'" + userid + "',userpwd:'" + fmima + "'}",
                dataType: 'json',
                success: function (result) {
                    $(".mengban").show();
                    $("#diyici").val("");
                    $("#dierci").val("");
                    $("#xuliehao").val("");
                }
            });
        }
    });


    $(".guanbi").click(function () {
        $(".mengban").hide();
    });
})