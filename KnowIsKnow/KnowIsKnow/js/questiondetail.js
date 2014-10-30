 var ue;
$(function () {
    ue = UE.getEditor('container', {

    });
    //名片
    $(".zm-item-link-avatar").hover(function () {
        checkcareperson();
        $(this).find(".zqq-goog-hovercard").show();
    }, function () {
        $(this).find(".zqq-goog-hovercard").hide();
    });
    //关注person
    $(".zqq-zg-btn-follow").click(function () {
        var questionprovider = $(this).attr("questionprovider");
        var userid = $(".knowIsknowID").attr("knowisknowid");
        var checkcareperson = $(this).attr("checkcareperson");
        if (checkcareperson == "nofollow") {
            $.ajax({
                data: "{ questionprovider:'" + questionprovider + "', userid:' " + userid + "' }",
                dataType: "json",
                url: "ws.asmx/followPerson",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });

            $(this).html("关注");
            $(this).attr("checkcareperson", "follow");
            $(this).css({
                "background": "#8ab923", "background-color": "#9dcc4a", "color": "#3e5e00",
                "border": "1px solid #6d8f29"
            });
        }
        else if (checkcareperson == "follow") {
            $.ajax({
                data: "{ questionprovider:'" + questionprovider + "', userid:' " + userid + "' }",
                dataType: "json",
                url: "ws.asmx/noFollowPerson",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });
            $(this).html("取消关注");
            $(this).attr("checkcareperson", "nofollow");
            $(this).css({
                "background": "#eee", "color": "#888",
                "border": "1px solid #ddd"
            });
        }
    });


   
    $("#wkreply").click(function () {

        questionid = $(this).attr("quesid");
        uid=$("#getuserid").attr("uid");
        content = ue.getContent();

        replyofreplyid = 0;
        $.ajax({
            data: "{ 'replyquestionID':'" + questionid + "','replyofuid':'" + uid + "','replycontent':'"+content+"','replyofreplyid':'"+replyofreplyid+"'}",
            dataType: "json",
            url: "ws.asmx/Reply",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                if (res.d == "ok") {
                    location.reload();
                }
            }

        });
    });
  
    $(".toggle-comment").click(function () {
        var isopen = $(this).attr("isOpen");
        replyofreplyid = $(this).attr("wkreplyofreplyid");
        var nextclass = $(this).attr("nextclass");
        var tthis = $(this);
        if (isopen == 1) {
       
            $.ajax({
                data: "{replyquestionId:'" + replyofreplyid + "'}",
                dataType: "json",
                url: "WSWang.asmx/selectRely",
                type: "post",
                contentType: "application/json",
                success: function (result) {
                    tthis.parent().next().find(".zm-comment-list").html("");
                    $(result.d).each(function () {
                       
                        var html = '';
                        html += '     <div class="zm-item-comment">';
                        html += '         <a class="zm-item-link-avatar">';
                        html += '           <img src="' + this.userHeadImage + '" class="zm-item-img-avatar" />';
                        html += '         </a>';
                        html += '         <div class="zm-comment-content-wrap">';
                        html += '           <div class="zm-comment-hd">';
                        html += '               <a class="zg-link">' + this.userNickName + '</a>';
                        html += '           </div>';
                        html += '           <div class="zm-comment-content">';
                        html += '               ' + this.replyContent + '';
                        html += '           </div>';
                        html += '           <div class="zm-comment-ft">';
                        html += '               <span class="date">2014-10-11</span>';
                        html += '               <a class="reply zm-comment-op-link" wkhuiname="' + this.userNickName + '" wkhuiid="' + this.replyofUID + '" wkhuiquid="'+this.ReplyID+'">';
                        html += '                   <i class="zg-icon zg-icon-comment-reply"></i>回复';
                        html += '               </a> ';
                        html += '               <a class="like zm-comment-op-link ">';
                        html += '                   <i class="zg-icon zg-icon-comment-like"></i>赞';
                        html += '               </a>';
                        html += '               <a class="report zm-comment-op-link needsfocus">';
                        html += '                   <i class="zg-icon z-icon-no-help"></i>举报';
                        html += '               </a>';
                        html += '            </div>';
                        html += '           </div>';
                        html += '      </div>';

                        tthis.parent().next().find(".zm-comment-list").append(html);
                       
                        
                    });
                }

            });
            
            $(this).parent().next().show();
          
            $(this).attr("isOpen", "0");
        }
        else {
            $(this).parent().next().hide();
            $(this).attr("isOpen", "1");
        }
        
    })
    $(document).on("click", ".reply", function () {
        var huiname = $(this).attr("wkhuiname");
        var huiid = $(this).attr("wkhuiid");
        var huiquid = $(this).attr("wkhuiquid");
        $(this).parent().parent().parent().parent().parent().find(".zm-comment-editable").val("@" + huiname+":");
        //$(this).parent().parent().parent().parent().parent().find(".wkpinglun").attr("wkreplyofreplyid", huiquid);
    });
    $(".wkpinglun").click(function () {
        var 
        replyofreplyid = $(this).attr("wkreplyofreplyid");
        questionid = $(this).attr("quesid");
        uid = $("#getuserid").attr("uid");
        wkname = $("#wtname").find("span").html();
        tthis = $(this);
        content = $(this).parent().parent().find(".zm-comment-editable").val();
        
        $.ajax({
            data: "{ 'replyquestionID':'" + questionid + "','replyofuid':'" + uid + "','replycontent':'" + content + "','replyofreplyid':'" + replyofreplyid + "'}",
            dataType: "json",
            url: "WSWang.asmx/Reply",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                var html = '';
                html += '     <div class="zm-item-comment">';
                html += '         <a class="zm-item-link-avatar">';
                html += '           <img src="#" />';
                html += '         </a>';
                html += '         <div class="zm-comment-content-wrap">';
                html += '           <div class="zm-comment-hd">';
                html += '               <a class="zg-link">' + wkname + '</a>';
                html += '           </div>';
                html += '           <div class="zm-comment-content">';
                html += '               ' + content + '';
                html += '           </div>';
                html += '           <div class="zm-comment-ft">';
                html += '               <span class="date">2014-10-11</span>';
                html += '               <a class="reply zm-comment-op-link" wkhuiname="' + wkname + '" wkhuiid="' + uid + '">';
                html += '                   <i class="zg-icon zg-icon-comment-reply"></i>回复';
                html += '               </a> ';
                html += '               <a class="like zm-comment-op-link ">';
                html += '                   <i class="zg-icon zg-icon-comment-like"></i>赞';
                html += '               </a>';
                html += '               <a class="report zm-comment-op-link needsfocus">';
                html += '                   <i class="zg-icon z-icon-no-help"></i>举报';
                html += '               </a>';
                html += '            </div>';
                html += '           </div>';
                html += '      </div>';
                tthis.parent().parent().parent().find(".zm-comment-list").append(html);
            }

        });
        
        $(this).parent().parent().find(".zm-comment-editable").val("");

    })
});

function checkcareperson() {
    $.each($(".zqq-zg-btn-follow "), function () {
        if ($(this).attr("checkcareperson") == "follow") {
            $(this).html("取消关注");
            $(this).css({
                "background": "#eee", "color": "#888",
                "border": "1px solid #ddd"
            });
        }
        else if ($(this).attr("checkcareperson") == "myself") {
            $(this).hide();
            $(this).next().hide();
        }
    });
}