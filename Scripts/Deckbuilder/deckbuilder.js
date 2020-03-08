

$("#primary-crab").hover(
    function () {
        console.log("enter");
        $(this).addClass("crab");
    }, function () {
        console.log("leave");
        $(this).removeClass("crab");
    }
);
