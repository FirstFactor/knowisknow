$(function () {
    $.ajax({
        data: {},
        dataType:"json",
        url: "ws.asmx/HelloWorld",
        type: "post",
        contentType:"application/json",
        success: function (res) {
            alert(res.d);
        }
    });

	$(".zqydenglu").hover(function(){
		$(this).css("right","-5px")
	},function(){
		$(this).css("right","0px")
	});


	$(".ludeng").click(function(){
		$(".zqysignup").hide();		
		$(".zqysignin").show();
		$(".zqyzhucefailure").hide();
	});
	$(".cezhu").click(function(){
		$(".zqysignup").show();
		$(".zqysignin").hide();
		$(".zqydenglufailure").hide();
	});

/*注册*/
	$(".zqyzhucesign").click(function(){
		
		$(".zqyzhucefailure").html("");
		$(".zqyzhucefailure").hide();
		var xing = $(".zqyfirst").val();
		var ming =$(".zqylast").val();
		var email = $(".zqymail").val();
		var mima = $(".zqymima").val();

		if (xing == "") {
			
			var xinghtml="<div>姓氏未填写</div>";
			$(".zqyzhucefailure").prepend(xinghtml);
			$(".zqyzhucefailure").show();
			
		};
		if (ming == "") {
			var xinghtml="<div>名字未填写</div>";
			$(".zqyzhucefailure").prepend(xinghtml);
			$(".zqyzhucefailure").show();
		};

		if (email == "") {
			var emailhtml="<div>邮箱未填写</div>";
			$(".zqyzhucefailure").prepend(emailhtml);
			$(".zqyzhucefailure").show();
		}else{
			var checkmail=/^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-])+/;
			if (!checkmail.test(email)) {
				var emailhtml="<div>邮箱格式不对</div>";
				$(".zqyzhucefailure").prepend(emailhtml);
				$(".zqyzhucefailure").show();
			};
		};

		if (mima == "") {
			var mimahtml="<div>密码未填写</div>";
			$(".zqyzhucefailure").prepend(mimahtml);
			$(".zqyzhucefailure").show();
		};
	
	});


/*登陆*/

	$(".zqydenglusign").click(function(){

		$(".zqydenglufailure").html("");
		$(".zqydenglufailure").hide();
		var signmail =$(".zqysignmail").val();
		var signmima = $(".zqysignmima").val();
		if (signmail == "") {
			var xinghtml="<div>邮箱未填写</div>";
			$(".zqydenglufailure").prepend(xinghtml);
			$(".zqydenglufailure").show();
		}else{
			//safsa@abc.ccom.cn
			var checkmaildl=/^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-])+/;
			if (!checkmaildl.test(signmail)) {
				var emailhtml="<div>邮箱格式不对</div>";
				$(".zqydenglufailure").prepend(emailhtml);
				$(".zqydenglufailure").show();
			}
		}

		if (signmima == "") {
			var xinghtml="<div>密码未填写</div>";
			$(".zqydenglufailure").prepend(xinghtml);
			$(".zqydenglufailure").show();
		};


		
	});

})