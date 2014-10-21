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
        var thisusernickname=$(".zg-form-text-input").val();
        $(".ac-renderer").html(" ");
     
        $.ajax({
            data: "{usernickname:'"+thisusernickname+"'}",
            dataType: "json",
            url: "ws.asmx/selectUserInfo",
            type: "post",
            contentType: "application/json",
            success: function (result) {
                $(result.d).each(function () {
                    var html = "";
                    html += '     <div class="ac-row">';
                    html += '         <img class="zm-item-img-avatar zg-left" src="Images/sprites.png"/>';
                    html += '         <span class="zu-autocomplete-row-name">' +this.userNickName+ '</span>';
                    html += '         <span class="zg-gray-normal zu-autocomplete-row-description">呵呵</span>';
                    html += '     </div>';
                    $(".ac-renderer").append(html);
                })
                
            }

        });
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
    $(".huifusixin").click(function () {
        var chatname = $(this).attr("userNickName");
        alert(chatname);
        $(".mengban").css("opacity", "0.6");
        $(".mengban").show();
        $(".modal-dialog").show();
        $(".modal-dialog").find(".zg-form-text-input").val(chatname);
        $(".modal-dialog-title-close").click(function () {
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
        $(".zm-command-cancel").click(function () {
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
    })
})