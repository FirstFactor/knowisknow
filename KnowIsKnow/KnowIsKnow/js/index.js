$(function () {
    $(".zqydenglu").hover(function () {
        $(this).css("right", "-5px");
    }, function () {
        $(this).css("right", "0px");
    });


    $(".ludeng").click(function () {
        $(".zqysignup").hide();
        $(".zqysignin").show();
        /*$(".zqysignup").animate({"margin-left":"158px"},300);
		setTimeout('$(".zqysignup").hide()',300);
		setTimeout('$(".zqysignin").show()',300);
		$(".zqysignin").animate({"margin-left":"138px"},1000);*/
        $(".zqyzhucefailure").hide();
        //$(".zqysignmail").val("");
        //$(".zqysignmima").val("");
    });
    $(".cezhu").click(function () {
        $(".zqysignup").show();
        $(".zqysignin").hide();
        $(".zqydenglufailure").hide();
    });

    /*注册*/
    $(".zqyzhucesign").click(function () {

        //$(".zqyzhucefailure").css("background-color","rgba(0,0,0,0.1)");

        $(".zqyzhucefailure").html("");
        $(".zqyzhucefailure").hide();
        var xing = $(".zqyfirst").val();
        var ming = $(".zqylast").val();
        var email = $(".zqymail").val();
        var mima = $(".zqymima").val();
        var checkmail = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-])+/;

        //setInterval('setfaulthide()', 5000);
        if (xing == "") {

            var xinghtml = "<div class='failtip'><i class='icon_sign'></i>姓氏未填写</div>";
            $(".zqyzhucefailure").append(xinghtml);
            $(".zqyzhucefailure").show();

        };
        if (ming == "") {
            var xinghtml = "<div class='failtip'><i class='icon_sign'></i>名字未填写</div>";
            $(".zqyzhucefailure").append(xinghtml);
            $(".zqyzhucefailure").show();
        };

        if (email == "") {
            var emailhtml = "<div class='failtip'><i class='icon_sign'></i>邮箱未填写</div>";
            $(".zqyzhucefailure").append(emailhtml);
            $(".zqyzhucefailure").show();
        } else {

            if (!checkmail.test(email)) {
                var emailhtml = "<div class='failtip'><i class='icon_sign'></i>邮箱格式不对</div>";
                $(".zqyzhucefailure").append(emailhtml);
                $(".zqyzhucefailure").show();
            };
        };

        if (mima == "") {
            var mimahtml = "<div class='failtip'><i class='icon_sign'></i>密码未填写</div>";
            $(".zqyzhucefailure").append(mimahtml);
            $(".zqyzhucefailure").show();
        };

        if (xing != "" && ming != "" && checkmail.test(email) && email != "" && mima != "") {
            //$(".zqywrapper").hide();
            //$(".mengban").show();
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "WSZQY.asmx/zhuce",
                data: "{xing:'" + xing + "',ming:'" + ming + "',email:'" + email + "',mima:'" + mima + "'}",
                dataType: 'json',
                success: function (res) {
                    if (res.d == "yes") {
                        window.location.href = "SelectTopic.aspx?backurl=" + window.location.href;
                    } else {
                        var mimahtml = "<div class='failtip'><i class='icon_sign'></i>该邮箱已注册，请直接登录</div>";
                        $(".zqyzhucefailure").html(mimahtml);
                        $(".zqyzhucefailure").show();
                    }
                }
            });
        }
    });


    /*登陆*/
    var shu = 0;
    $(".zqydenglusign").click(function () {
        shu = shu + 1;
        $(".zqydenglufailure").html("");
        $(".zqydenglufailure").hide();
        var signmail = $(".zqysignmail").val();
        var signmima = $(".zqysignmima").val();
        var checkmaildl = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-])+/;
        if (signmail == "") {
            var xinghtml = "<div class='failtip'><i class='icon_sign'></i>邮箱未填写</div>";
            $(".zqydenglufailure").append(xinghtml);
            $(".zqydenglufailure").show();
        } else {
            //safsa@abc.ccom.cn
            var checkmaildl = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-])+/;
            if (!checkmaildl.test(signmail)) {
                var emailhtml = "<div class='failtip'><i class='icon_sign'></i>邮箱格式不对</div>";
                $(".zqydenglufailure").append(emailhtml);
                $(".zqydenglufailure").show();
            }
        }

        if (signmima == "") {
            var xinghtml = "<div class='failtip'><i class='icon_sign'></i>密码未填写</div>";
            $(".zqydenglufailure").append(xinghtml);
            $(".zqydenglufailure").show();
        };

        if (shu < 3) {
            if (checkmaildl.test(signmail) && signmima != "") {
                $.ajax({
                    type: "POST",
                    contentType: "application/json",
                    url: "WSZQY.asmx/denglu",
                    data: "{useremail:'" + signmail + "',userpwd:'" + signmima + "'}",
                    dataType: 'json',
                    success: function (res) {
                        if (res.d == 0) {
                            var xinghtml = "<div class='failtip'><i class='icon_sign'></i>帐号和密码不匹配！</div>";
                            $(".zqydenglufailure").html(xinghtml);
                            $(".zqydenglufailure").show();
                            //$(".zqysignmail").val("");
                            //$(".zqysignmima").val("");
                        } else {
                            window.location.href = "home.aspx?backurl=" + window.location.href;
                        }
                    }
                });
            }
        }


        if (shu > 3) {
            $(".shuruyanzheng").show();
            $(".yanzhengma").show();
            if (checkmaildl.test(signmail) && signmima != "") {
                $.ajax({
                    type: "POST",
                    contentType: "application/json",
                    url: "WSZQY.asmx/denglu",
                    data: "{useremail:'" + signmail + "',userpwd:'" + signmima + "'}",
                    dataType: 'json',
                    success: function (res) {
                        if (res.d == 0) {
                            var xinghtml = "<div class='failtip'><i class='icon_sign'></i>帐号和密码不匹配！</div>";
                            $(".zqydenglufailure").html(xinghtml);
                            $(".zqydenglufailure").show();
                            //$(".zqysignmail").val("");
                            //$(".zqysignmima").val("");
                        } else {
                            window.location.href = "home.aspx?backurl=" + window.location.href;
                        }
                    }
                });
            }
        }

    });


    $(".zqymail").click(function () {
        $(".emailspan").hide();


    });
    $(".emailspan").click(function () {
        $(".emailspan").hide();
    });


    $(".zqymima").click(function () {
        $(".pwdspan").hide();


    });

    $(".pwdspan").click(function () {
        $(".pwdspan").hide();

    });

    $(".inputmail").click(function () {
        $(this).find(".signemailspan").hide();
        $(this).find(".zqysignmail").css({ "width": "185px", "margin-left": "10px" });
    });

    $(".inputsignmima").click(function () {
        $(this).find(".signpwdspan").hide();
        $(this).find(".zqysignmima").css({ "width": "185px", "margin-left": "10px" });
    });
    //setInterval('ddd()',300);

    $(".xmleft").click(function () {
        $(".emailfirst").hide();
        $(".zqyfirst").css({ "width": "80px", "margin-left": "10px" });
    });
    $(".zqyfirst").blur(function () {
        var xing = $(this).val();
        if (xing == "") {
            $(".emailfirst").show();
            $(".zqyfirst").css({ "width": "61px", "margin-left": "0px" });
        };
    });

    $(".xmright").click(function () {
        $(".emaillast").hide();
        $(".zqylast").css({ "width": "80px", "margin-left": "10px" });
    });


    $(".zqylast").blur(function () {
        var ming = $(this).val();
        if (ming == "") {
            $(".emaillast").show();
            $(".zqylast").css({ "width": "61px", "margin-left": "0px" });
        };
    });

    $(".zqymail").blur(function () {
        var mail = $(this).val();
        if (mail == "") {
            $(".emailspan").show();
        };
    });

    $(".zqymima").blur(function () {
        var mima = $(this).val();
        if (mima == "") {
            $(".pwdspan").show();
        };
    });

    $(".zqysignmail").blur(function () {
        var signmail = $(this).val();
        if (signmail == "") {
            $(".signemailspan").show();
            $(".zqysignmail").css({ "width": "155px", "margin-left": "0px" });
        };

    });


    $(".zqysignmima").blur(function () {
        var signmima = $(".zqysignmima").val();
        if (signmima == "") {
            $(".signpwdspan").show();
            $(".zqysignmima").css({ "width": "155px", "margin-left": "0px" });
        };
    });




    /*登录页面下方*/
    $(".zqyuserimg").mouseover(function () {
        $(".zqyuserimg").removeClass("zqyuserspec");
        $(this).addClass("zqyuserspec");

        var phsrc = $(this).attr("src");

        var shuoshuo = $(this).attr("shuoshuo");

        var mingzi = $(this).attr("mingzi");

        var html = "";
        html += ' 					<div class="zqytopic">';
        html += '						<img src="' + phsrc + '" class="story_avatar">';
        html += '						<div class="story_title">';
        html += '							<div>';
        html += '								<a href="#" class="story_jies mingzi">' + mingzi + '</a>';
        html += '								<span>' + shuoshuo + '</span>';
        html += '							</div>';
        html += '							<div class="story_jies">68743 人关注该话题，1000 个精华回答</div>';
        html += '						</div>';
        html += '						<div class="sep"></div>';
        html += '						<div class="story_content">';
        html += '							<div class="story_content_answer">';
        html += '								<span class="vote">2222</span>';


        html += '								<p>';
        html += '									<a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Do not Make Me Think」原则？</a>';
        html += '								</p>';
        html += '							</div>';
        html += '							<div class="story_content_answer">';
        html += '								<span class="vote">2222</span>';
        html += '								<p>';
        html += '									<a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Do not Make Me Think」原则？</a>';
        html += '								</p>';
        html += '							</div>';
        html += '							<div class="story_content_answer">';
        html += '								<span class="vote">2222</span>';
        html += '								<p>';
        html += '									<a href="#" class="answer_jies">Chrome 浏览器的哪些设计符合「Do not Make Me Think」原则？</a>';
        html += '								</p>';
        html += '							</div>';
        html += '						</div>';
        html += '						<div class="sep"></div>';
        html += '						<div class="story_end">';
        html += '							Cat Chen在<a href="#" class="huati"> Facebook</a>、<a href="#" class="huati">政治</a>、<a href="#" class="huati">历史</a>等话题下获得了 <span>11024</span> 个赞同';
        html += '						</div>';
        html += '					</div>';

        $(".zqyuserstory").html(html);
    });




    $(".kaishi").click(function () {
        $(".view").hide();
        $(".followtopic").show();
    });




})


function ddd() {
    var hehe = $(".zqymail").val();
    if (hehe != "") {
        $(".zqyplaspan").hide();

    };

}


function setfaulthide() {
    $(".zqyzhucefailure").hide();
}
