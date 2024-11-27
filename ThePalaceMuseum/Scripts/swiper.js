// 创建Swiper
var mySwiper = new Swiper(".swiper", {
    direction: "horizontal", // 左右切换
    loop: true, // 循环模式选项
    autoplay: true, // 自动切换
    grabCursor: true, // 鼠标指针

    // 如果需要分页器
    pagination: {
        el: ".swiper-pagination",
        clickable: true, // 点击控制切换
        bulletClass: "my-bullet", // 自定义样式
        bulletActiveClass: "my-bullet-active", // 自定义当前图片分页器样式
    },

    // 如果需要前进后退按钮
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
});

// 鼠标点击pagination控制swiper切换
for (i = 0; i < mySwiper.pagination.bullets.length; i++) {
    mySwiper.pagination.bullets[i].onclick = function() {
        this.click();
    };
}

// 如果你在swiper初始化后才决定使用clickable，可以这样设置
mySwiper.params.pagination.clickable = true;
// 此外还需要重新初始化pagination
mySwiper.pagination.destroy();
mySwiper.pagination.init();
mySwiper.pagination.bullets
    .eq(0)
    .addClass("swiper-pagination-bullet-active my-bullet-active");