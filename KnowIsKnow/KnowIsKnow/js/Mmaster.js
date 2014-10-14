$(function () {


    $(document).on("click", ".wtzu-top-add-question", function () {
        
        $(".zqq-menban").show();

        $(".zqq-tiwen-search").show();
       
        ////拖动
        //$(".zqq-tiwen-search").draggable({
        //    handle: ".zqq-tiwen-menban-title",
        //    containment: "parent"
        //});




    });
    $(".zqq-tiwen-menban-close").click(function () {
        $(".zqq-tiwen-search").hide();
        $(".zqq-menban").hide();
        $(".zqq-search-area").val("");
    });

    $(document).on("click", ".zqq-search-area", function () {
        setInterval("checkSearch()", 100);

    });

    $(document).on("click", ".zqq-search-list-last", function () {
        $(this).parent().parent().parent().hide();
        $(this).parent().parent().parent().parent().find(".zqq-tiwen-inner").show();

        var searchQuestion = $(this).parent().parent().find(".zqq-search-area").val();
        $(this).parent().parent().parent().parent().find(".zqq-tiwen-inner").find(".zqq-publish").find(".zqq-publish-input-title").val() = searchQuestion;
        //拖动
        $(".zqq-tiwen-inner").draggable({
            handle: ".zqq-tiwen-menban-title",
            containment: "parent"
        });

        $(".zqq-tiwen-menban-close").click(function () {
            $(this).parent().parent().hide();
            $(this).parent().parent().parent().find(".zqq-menban").hide();
            $(this).parent().parent().parent().find(".zqq-tiwen-search").find(".zqq-tiwen-search-bar").find(".zqq-search-area").val("");

        });
    })


   

    $(".zqq-publish-input").click(function () {
        $(this).next().find(".zqq-btn-publish").removeClass("btn-publish1");
        $(this).next().find(".zqq-btn-publish").addClass("btn-publish2");
    });
    $(".zqq-btn-publish").click(function () {
        var questionTitle = $(this).parent().parent().find(".zqq-publish-input-title").val();
        var questionContent = $(this).parent().parent().find(".zqq-publish-input-content").val();
        if (questionTitle == "") {
            alert("请输入提问标题");
            if (questionContent == "") {
                alert("请输入提问内容");
                return false;
            }
            return false;
        }
        else {
            addQuestion(questionTitle, questionContent);
        }
        $(this).parent().parent().find(".zqq-publish-input-title").val("");
        $(this).parent().parent().find(".zqq-publish-input-content").val("");
        $(this).parent().parent().parent().parent().find(".zqq-tiwen-search-bar").find(".zqq-search-area").val("");

        $(this).parent().parent().parent().hide();
        $(this).parent().parent().parent().parent().find(".zqq-menban").hide();
    });

});

function addQuestion(questionTitle, questionContent) {
    var shtml = '';
    shtml += '<div class="zqq-small-question">';
    shtml += '	<div class="zqq-head-photo">';
    shtml += '		<img class="zqq-head-face" src="image/mypic.jpg">';
    shtml += '	</div>';
    shtml += '	<div class="zqq-question-detail">';
    shtml += '		<div class="zqq-question-info">霸道总裁爱上市 提出了问题</div>';
    shtml += '		<div class="zqq-question-title">' + questionTitle + '</div>';
    shtml += '		<div class="zqq-question-content">';
    shtml += '			<div class="zqq-content-word">' + questionContent + '</div>';
    shtml += '			<img class="zqq-content-pic" src=""> ';
    shtml += '		</div>';
    shtml += '		<div class="zqq-question-ft">';
    shtml += '			<div class="zqq-follow-topic">关注话题</div>';
    shtml += '			<div class="zqq-jubao">举报</div>';
    shtml += '		</div>';
    shtml += '	</div>';
    shtml += '</div>';
    var ssnHtml = $(".zqq-newQuestion").html();
    $(".zqq-newQuestion").html(shtml + ssnHtml);

    $(".zqq-question-detail").hover(function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").show();
    }, function () {
        $(this).find(".zqq-question-ft").find(".zqq-jubao").hide();
    });
}

function checkSearch() {
    var searchWord = $(".zqq-search-area").val();
    if (searchWord != "") {
        $(".zqq-search-list-last").show();
    }
    else {
        $(".zqq-search-list-last").hide();
    }
}