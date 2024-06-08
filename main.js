$(document).ready(function ($){
    "use strict";

    jQuery(".menu-toggle").click(function () {
        jQuery(".main-navigation").toggleClass("toggled");
    });

    jQuery(".header-menu ul li a").click(function () {
        jQuery(".main-navigation").removeClass("toggled");
    });

    gsap.registerPlugin(ScroolTrigger);

    var elementFirst = document.querySelector('.site-header');
    ScroolTrigger.creat({
        trigger : "body",
        start : "30px top",
        end : "bottom bottom",

        onEnter : () => myFunction(),
        onLeaveback : () => myFunction(),
    });

    function myFunction(){
        elementFirst.classList.toggle('sticky_head');
    }
})

