﻿ var ue;
$(function () {
    ue = UE.getEditor('container', {

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
                        alert(this.replyofUID);
                        var html = '';
                        html += '     <div class="zm-item-comment">';
                        html += '         <a class="zm-item-link-avatar">';
                        html += '           <img src="#" />';
                        html += '         </a>';
                        html += '         <div class="zm-comment-content-wrap">';
                        html += '           <div class="zm-comment-hd">';
                        html += '               <a class="zg-link">' + this.replyofUID + '</a>';
                        html += '           </div>';
                        html += '           <div class="zm-comment-content">';
                        html += '               ' + this.replyContent + '';
                        html += '           </div>';
                        html += '           <div class="zm-comment-ft">';
                        html += '               <span class="date">2014-10-11</span>';
                        html += '               <a class="reply zm-comment-op-link">';
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
    $(".wkpinglun").click(function () {
        replyofreplyid = $(this).attr("wkreplyofreplyid");
        questionid = $(this).attr("quesid");
        uid = $("#getuserid").attr("uid");
        content = $(this).parent().parent().find(".zm-comment-editable").val();
        
        $.ajax({
            data: "{ 'replyquestionID':'" + questionid + "','replyofuid':'" + uid + "','replycontent':'" + content + "','replyofreplyid':'" + replyofreplyid + "'}",
            dataType: "json",
            url: "ws.asmx/Reply",
            type: "post",
            contentType: "application/json",
            success: function (res) {
               
            }

        });

        $(this).parent().parent().find(".zm-comment-editable").val("");

    })
});