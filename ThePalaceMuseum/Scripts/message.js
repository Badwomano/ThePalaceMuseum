//
$(".tab_item").mouseover(function() {
    var index = $(this).index()
    console.log(index);
    $(".tab").eq(index).addClass("on").siblings().removeClass("on");
});
$(".tab").mouseleave(function() {
    $(".tab").removeClass("on")
});