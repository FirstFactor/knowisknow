

$(function () {
    var um = UE.getEditor('txtQuestionContent', {
        toolbars: [[        
            'bold', 'italic', 'underline', 'fontborder', 'strikethrough', 'superscript', 'subscript', '|', 'forecolor', 'insertorderedlist', 'insertunorderedlist', '|',          
            'fontfamily', 'fontsize', '|',        
            'justifyleft', 'justifycenter', 'justifyright', 'justifyjustify', '|', 
            'link', 'unlink', '|', 'imagenone', 'imageleft', 'imageright', 'imagecenter', '|',
            'simpleupload', 'insertimage', 'emotion',  'insertvideo',  'attachment', '|',
            'horizontal', 'spechars', '|',
            'inserttable'
           
        ]]
    });
    //um.setHeight(50);
    $(document).on("click", ".wtzu-top-add-question", function () {
        $(".zqq-menban").show();
        $(".zqq-tiwen-search").show();
    });

    //私信
    var receiveid ;
    var senderid;
    $(document).on("click", ".zqq-messageButtonArea" ,function () {
        var usernickname = $(this).attr("usernickname");
        receiveid = $(this).attr("userid");
        senderid = $(".knowIsknowID").attr("knowisknowid");
        $(".zqq-modal-dialog").show();
        $(".zqq-menban").show();
        $(".zqq-sixin-who").html(usernickname);

    });
    $(".zqq-zg-btn-blue").click(function () {
        var senderContent = $(".zqq-zg-editor-input").val();
        $.ajax({
            data: "{ senderid:'" + senderid + "', receiveid:' " + receiveid + "',senderContent:'" + senderContent + "' }",
            dataType: "json",
            url: "ws.asmx/senderMessage",
            type: "post",
            contentType: "application/json",
            success: function (res) {
                if (res.d != "") {
                    window.location.href = "MessageDetail.aspx?MsgsID="+res.d;
                }
            }
        });
        $(".zqq-modal-dialog").hide();
        $(".zqq-menban").hide();
        $(".zqq-sixin-who").html("");
        $(".zqq-zg-editor-input").val("");

    });
    $(".zqq-modal-dialog-title-close").click(function () {

        $(".zqq-modal-dialog").hide();
        $(".zqq-menban").hide();
        $(".zqq-sixin-who").html("");
        $(".zqq-zg-editor-input").val("");
    });

    //提问前搜索框拖动
    $(".zqq-tiwen-search").draggable({
        handle: ".zqq-tiwen-menban-title",
        containment: "parent"
    });
    //提问框拖动
    $(".zqq-tiwen-inner").draggable({
        handle: ".zqq-tiwen-menban-title",
        containment: "parent"
    });
    //举报框拖动
    $(".zqq-jubao-inner").draggable({
        handle: ".zqq-tiwen-menban-title",
        containment: "parent"
    });
    //关闭按钮通用
    $(".zqq-tiwen-menban-close").click(function () {
        $(".zqq-tiwen-search").hide();
        $(".zqq-tiwen-inner").hide();
        $(".zqq-jubao-inner").hide();
        $(".zqq-jubao-otherReason").hide();
        $(".zqq-jubao-chose-main li label input").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(".zqq-menban").hide();
        $(".zqq-search-area").val("");
        $(".zqq-jubao-otherReason").val("");
    });

    $(document).on("click", ".zqq-search-area", function () {
        //setInterval("checkSearch()", 100);

    });

    /*母板页搜索*/
    $(".wtzu-top-search-input").keyup(function () {
        var searchcontent = $(this).val();
        $(".zqq-Fsearch-listaa").html("");
        if (searchcontent != "") {
            
            $.ajax({
                data: "{searchcontent:'" + searchcontent + "'}",
                dataType: "json",
                url: "ws.asmx/selectQuestionInfo",
                type: "post",
                contentType: "application/json",
                success: function (result) {
                    $(result.d).each(function () {
                        var html = "";
                        html += '     <li class="zqq-Fquestion-row">';
                        html += '         <a href="QuestionDetail.aspx?QuesID=' + this.questionID + '" class="zqq-FquestionTitle">' + this.questionTitle + '</a>';
                        html += '         <div class="zqq-Fsearch-questionid" questionid="' + this.questionID + '" ></div>'
                        html += '     </li>';
                        $(".zqq-Fsearch-listaa").append(html);
                    })
                }
            });
            $(".zqq-Fsearch-list").show();
        }

    });
    /*提问先搜索*/
    $(".zqq-search-area").keyup(function () {
        var searchcontent = $(this).val();
        $(".zqq-search-lista").html("");
        if (searchcontent != "") {
            $.ajax({
                data: "{searchcontent:'" + searchcontent + "'}",
                dataType: "json",
                url: "ws.asmx/selectQuestionInfo",
                type: "post",
                contentType: "application/json",
                success: function (result) {
                    $(result.d).each(function () {
                        var html = "";
                        html += '     <li class="zqq-question-row">';
                        html += '         <a href="QuestionDetail.aspx?QuesID=' + this.questionID + '" class="zqq-questionTitle">' + this.questionTitle + '</a>';
                        html += '         <div class="zqq-search-questionid" questionid="' + this.questionID + '" ></div>'
                        html += '     </li>';
                        $(".zqq-search-lista").append(html);
                    })
                }
            });
            $(".zqq-search-listArea").show();
            $(".zqq-search-list-last").show();
        }
        else {
            $(".zqq-search-list-last").hide();
        }
        
        
    });


    $(document).on("click", ".zqq-search-list-last", function () {
        $(".zqq-tiwen-search").hide();
        $(".zqq-tiwen-inner").show();

        var searchWord = $(".zqq-search-area").val();
        $(".zqq-publish-input-title").html(searchWord);
    });
    $(".zqq-publish-input-topic").keyup(function () {
        var topiccontent = $(this).val();
        $(".zqq-renderer").html(" ");
        if (topiccontent != "") {
            $.ajax({
                data: "{topiccontent:'" + topiccontent + "'}",
                dataType: "json",
                url: "ws.asmx/selectTopicInfo",
                type: "post",
                contentType: "application/json",
                success: function (result) {
                    $(result.d).each(function () {
                        var html = "";
                        html += '     <div class="zqq-row">';
                        html += '         <img class="zqq-item-img-avatar zqq-left" src="' + this.topicPicUrl + '"/>';
                        html += '         <span class="zqq-autocomplete-row-name">' + this.topicTitle + '</span>';
                        html += '         <span class="zqq-gray-normal zqq-autocomplete-row-description">' + this.topicDes + '</span>';
                        html += '         <div class="zqq-topicid" zqqtopicid="' + this.topicID + '" ></div>'
                        html += '     </div>';
                        $(".zqq-renderer").append(html);
                    })
                }
            });
            $(".zqq-renderer").show();

            $(".zqq-row").hover(function () {

                $(this).addClass("zqq-active");
            }, function () {
                $(this).removeClass("zqq-active");
            })
        }
        
    });
    $(document).on("click", ".zqq-row", function () {

        var topicTitle = $(this).find(".zqq-autocomplete-row-name").text();
        var topicid = $(this).find(".zqq-topicid").attr("zqqtopicid");

        $(".zqq-publish-input-topic").val(topicTitle);
        $(".zqq-publish-input-topic").attr("zqqtopicid", topicid);
        $(".zqq-renderer").hide();
    });

    /*提问*/
    $(".zqq-btn-publish").click(function () {
        //var userHeadImage = $(".zqq-head-face").attr("src");
        //var userNickName = $(".zqq-question-info").val();
        //var questionid = $(".zqq-question-title").attr("questionid");

        var questionTitle = $(".zqq-publish-input-title").val();
        var questionContent = um.getContent();
        var questionTopicID = $(".zqq-publish-input-topic").attr("zqqtopicid");
        var userid = $(".knowIsknowID").attr("knowisknowid");
        
        if (questionTitle == "") {
            alert("请输入提问标题");
            return ;
        }
        if (questionContent == "") {
            alert("请输入提问内容");
            return ;
        }
         if (questionTopicID == "") {
            alert("请至少选择一个已存在的话题");
            return ;
        }
            var quid;
           // addQuestion(questionTitle, questionContent, userid, userHeadImage, userNickName, questionid);
            $.ajax({
                async: false,
                data: "{ questiontilte:'" + questionTitle + "', questioncontent:' " + questionContent + "',questionproviderid:'" + userid + "' }",
                dataType: "json",
                url: "ws.asmx/PubQuestion",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    quid = res.d;
                    if (res.d != "") {
                        window.location.href="MyQuestion.aspx";
                    }
                }
            });
            $.ajax({
                data: "{quid:'"+ quid + "' ,questionTopicID:'" + questionTopicID + "' }",
                dataType: "json",
                url: "ws.asmx/PubTopic",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    if (res.d == "ok") {
                        window.location.href = "MyQuestion.aspx";
                    }
                }
            });

        $(".zqq-search-area").val("");

        $(".zqq-tiwen-inner").hide();
        $(".zqq-menban").hide();
    });

    /*举报通用*/
    $(".zqq-jubao-checked1").click(function () {
        var value = $(this).attr("value");
        $(".zqq-jubao-submit").attr("zhi", value);
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked2").click(function () {
        var value = $(this).attr("value");
        $(".zqq-jubao-submit").attr("zhi", value);
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked3").click(function () {
        var value = $(this).attr("value");
        $(".zqq-jubao-submit").attr("zhi", value);
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked4").click(function () {
        var value = $(this).attr("value");
        $(".zqq-jubao-submit").attr("zhi", value);
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked5").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-checked5").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").hide();
    });
    $(".zqq-jubao-checked5").click(function () {
        var value = $(this).attr("value");
        $(".zqq-jubao-submit").attr("zhi", value);
        $(this).attr("mark", 1);
        $(".zqq-jubao-checked2").attr("mark", 0);
        $(".zqq-jubao-checked3").attr("mark", 0);
        $(".zqq-jubao-checked4").attr("mark", 0);
        $(".zqq-jubao-checked1").attr("mark", 0);
        $(".zqq-jubao-checked2").attr("checked", false);
        $(".zqq-jubao-checked3").attr("checked", false);
        $(".zqq-jubao-checked4").attr("checked", false);
        $(".zqq-jubao-checked1").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(this).parent().parent().addClass("checked");
        $(".zqq-jubao-otherReason").show();
    });

    $(".zqq-jubao-submit").click(function () {
        var checked5 = $(".zqq-jubao-checked5").attr("mark");
        var checked4 = $(".zqq-jubao-checked4").attr("mark");
        var checked3 = $(".zqq-jubao-checked3").attr("mark");
        var checked2 = $(".zqq-jubao-checked2").attr("mark");
        var checked1 = $(".zqq-jubao-checked1").attr("mark");
        if (checked1 == 0 && checked2 == 0 && checked3 == 0 && checked4 == 0 && checked5 == 0) {
            alert("请选择举报原因！");
            return false;
        }
        else if (checked5 == 1) {
            var juaboReason = $(".zqq-jubao-otherReason").val();
            if (juaboReason == "") {
                alert("请输入举报原因!");
                return false;
            }
            else {
                var questionid = $(this).attr("questionid");
                var userid = $(".userid").attr("userid");
                var reportType = $(this).attr("zhi");
                var otherReason = $(".zqq-jubao-otherReason").val();
                $.ajax({
                    data: "{ questionid:'" + questionid + "', userid:' " + userid + "', reportType:'" + reportType + "',otherReason:'" + otherReason + "'}",
                    dataType: "json",
                    url: "ws.asmx/reportQuestion",
                    type: "post",
                    contentType: "application/json",
                    success: function (res) {
                        alert(res.d);
                    }
                });
            }
        }
        else {
            var questionid = $(this).attr("questionid");
            var userid = $(".knowIsknowID").attr("knowisknowid");
            var reportType = $(this).attr("zhi");
            $.ajax({
                data: "{ questionid:'" + questionid + "', userid:' " + userid + "', reportType:'" + reportType + "'}",
                dataType: "json",
                url: "ws.asmx/reportQuestion",
                type: "post",
                contentType: "application/json",
                success: function (res) {
                    alert(res.d);
                }
            });
        }
        $(".zqq-menban").hide();
        $(".zqq-jubao-inner").hide();
        $(".zqq-jubao-otherReason").hide();
        $(".zqq-jubao-chose-main li label input").attr("checked", false);
        $(".zqq-jubao-chose-list").removeClass("checked");
        $(".zqq-jubao-otherReason").val("");
    });

    






    $("#wtwho").hover(function () {
        $(".top-nav-dropdown").show();
    }, function () {
        $(".top-nav-dropdown").hide();
    })
    $(".lhovercolor").hover(function () {

        $("hovercolor").css("background-color", "#0267cc");
    }, function () { })
});

//function addQuestion(questionTitle, questionContent, userid, userHeadImage, userNickName, questionid) {
//    var shtml = '';
//    shtml += '<div class="zqq-small-question">';
//    shtml += '	<div class="zqq-head-photo">';
//    shtml += '		<img class="zqq-head-face" src=' + userHeadImage + ' />';
//    shtml += '	</div>';
//    shtml += '	<div class="zqq-question-detail">';
//    shtml += '		<div class="zqq-question-info">' + userNickName + ' 提出了问题 </div>';
//    shtml += '		<a href="QuestionDetail.aspx?QuesID=' + questionid + '" class="zqq-question-title" questionid=' + questionid + ' >' + questionTitle + '</a>';
//    shtml += '		<div class="zqq-question-content">';
//    shtml += '			<div class="zqq-content-word">' + questionContent + '</div>';
//    shtml += '			<img class="zqq-content-pic" src=""> ';
//    shtml += '		</div>';
//    shtml += '		<div class="zqq-question-ft">';
//    shtml += '			<div class="zqq-follow-topic">';
//    shtml += '              <a class="zqq-follow-topic-button">关注问题</a>';
//    shtml += '              <a class="zqq-display zqq-noFollow-topic-button">取消关注</a>';
//    shtml += '          </div>';
//    shtml += '			<div class="zqq-jubao" questionid=' + questionid + '>举报</div>';
//    shtml += '		</div>';
//    shtml += '	</div>';
//    shtml += '</div>';
//    var ssnHtml = $(".zqq-newQuestion").html();
//    $(".zqq-newQuestion").html(shtml + ssnHtml);
//}

function checkSearch() {
    var searchWord = $(".zqq-search-area").val();
    if (searchWord != "") {
        $(".zqq-search-list-last").show();
    }
    else {
        $(".zqq-search-list-last").hide();
    }
}
