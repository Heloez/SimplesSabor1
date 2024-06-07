$(document).ready(function ($){
    "use strict";

    WebGLSampler.registerPlugin(ScroolTrigger);

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