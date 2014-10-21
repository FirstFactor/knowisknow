$(function () {
    //点击“账号-修改”
    clickbtn1();

    clickli();

});


//点击“账号-修改”

function clickbtn1() {

    $(".zu-edit-button").click(function () {
        //alert("d");
        $(this).next().show();

    });


}
//点击表单选项时

function clickli() {

    $(".tn1").click(function () {

        //alert("d");
        $(".f1").removeClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");

        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn2").click(function () {

        //alert("d");
        $(".f2").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn1").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn3").click(function () {

        //alert("d");
        $(".f3").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });


    $(".tn4").click(function () {

        //alert("d");
        $(".f4").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn5").click(function () {

        //alert("d");
        $(".f5").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f6").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn6").click(function () {

        //alert("d");
        $(".f6").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f7").addClass("hidden");


        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        $(".tn7").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });

    $(".tn7").click(function () {

        //alert("d");
        $(".f7").removeClass("hidden");
        $(".f1").addClass("hidden");
        $(".f2").addClass("hidden");
        $(".f3").addClass("hidden");
        $(".f4").addClass("hidden");
        $(".f5").addClass("hidden");
        $(".f6").addClass("hidden");



        $(this).addClass("topnavActive");

        $(".tn2").removeClass("topnavActive");
        $(".tn3").removeClass("topnavActive");
        $(".tn4").removeClass("topnavActive");
        $(".tn5").removeClass("topnavActive");
        $(".tn6").removeClass("topnavActive");
        $(".tn1").removeClass("topnavActive");
        //$(".f2").removeClass("hidden");
        //$(".f1").addClass("hidden");
    });





}