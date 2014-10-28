$(function () {
    $("#wk-pm").click(function () {
        $(".mengban").css("opacity", "0.6");
        $(".mengban").show();
        $(".modal-dialog").show();
        $(".modal-dialog-title-close").click(function () {
            $(".ac-renderer").html("");
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
        $(".zm-command-cancel").click(function () {
            $(".ac-renderer").html("");
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
    })
    $(".zm-pm-user-selector").keyup(function () {
        var thisusernickname = $(".zg-form-text-input").val();
        $(".ac-renderer").html(" ");

        $.ajax({
            data: "{usernickname:'" + thisusernickname + "'}",
            dataType: "json",
            url: "ws.asmx/selectUserInfo",
            type: "post",
            contentType: "application/json",
            success: function (result) {
                $(result.d).each(function () {
                    
                    var html = "";
                    html += '     <div class="ac-row">';
                    html += '         <img class="zm-item-img-avatar zg-left" src="'+this.userHeadImage+'"/>';
                    html += '         <span class="zu-autocomplete-row-name">' + this.userNickName + '</span>';
                    html += '         <span class="zg-gray-normal zu-autocomplete-row-description">呵呵</span>';
                    html += '         <div class="wkdeuserid" wk="'+this.userID+'" ></div>'
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
    });
   
    $(".huifusixin").click(function () {
        var chatname = $(this).attr("userNickName");
        var userid = $(this).attr("userid");
        $(".mengban").css("opacity", "0.6");
        $(".mengban").show();
        $(".modal-dialog").show();
        $(".modal-dialog").find(".zg-form-text-input").val(chatname);
        $(".zm-wkuserid").val(userid);
        $(".modal-dialog-title-close").click(function () {
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
        $(".zm-command-cancel").click(function () {
            $(".mengban").hide();
            $(".modal-dialog").hide();
        })
    });
    $(document).on("click", ".ac-row", function () {
       
        var nickname = $(this).find(".zu-autocomplete-row-name").text();
        var mail = $(this).find(".zu-autocomplete-row-description").text();
        var userid = $(this).find(".wkdeuserid").attr("wk");
        
        $(".zg-form-text-input").val(nickname + mail);
   
        $(".zm-wkuserid").val(userid);
        $(".ac-renderer").hide();
    });
    $(".zg-link-litblu").click(function () {
        var sendid = $(this).attr("wksendid");
        var receiverid = $(this).attr("wkreceiverid");
        var userid = $(this).attr("wkuserid");
        if (userid == sendid) {
            window.location.href = "MessageDetail.aspx?MsgsID=" + receiverid + "";
        }
        else {
            window.location.href = "MessageDetail.aspx?MsgsID=" + sendid + "";
        }
    });
})