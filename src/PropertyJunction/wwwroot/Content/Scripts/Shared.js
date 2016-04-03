var sliderTimer;

$(document).ready(function () {
    StartSlider();
    $('.slider-nav').on('click', ChangeSlide);
});

function ChangeSlide() {
    StopSlider();

    if ($(this).hasClass('prev')) {
        $('.slide-show > .slide.active')
         .fadeOut(2000).removeClass('active')
         .prev('.slide').fadeIn(2000).addClass('active')
         .end()
         .appendTo('.slide-show');
    }
    else {
        $('.slide-show > .slide.active')
        .fadeOut(2000).removeClass('active')
        .next('.slide').fadeIn(2000).addClass('active')
        .end()
        .appendTo('.slide-show');
    }

    StartSlider();
}

function StartSlider() {
    sliderTimer = setInterval(function () {
        $('.slide-show > .slide.active')
          .fadeOut(2000).removeClass('active')
          .next('.slide').fadeIn(2000).addClass('active')
          .end()
          .appendTo('.slide-show');
    }, 10000);
}

function StopSlider() {
    clearInterval(sliderTimer);
}