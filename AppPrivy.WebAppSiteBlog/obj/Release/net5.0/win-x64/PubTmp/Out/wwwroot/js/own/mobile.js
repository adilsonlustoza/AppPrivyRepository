$(document).ready(function ()
{


    var _jr3DCarousel = $('.jR3DCarouselGallery').jR3DCarousel({
        width: 200,			/* largest allowed width */
        height: 350,			/* largest allowed height */
        slideClass: 'mySlide', 		/* array of images source, optional in case of custom template  */
        slideLayout: 'fill', 		/* "contain"-fit as per to aspect ratio | "fill"-stretches to fill |
					   "cover"-overflows but maintains ratio */
        perspective: 2000,			/* perspective - default is dynamic, perpendicular */
        animation: 'slide3D', 		/* slide | slide3D | scroll | scroll3D | fade */
        animationCurve: 'ease',		/* ease | ease-in | ease-out | ease-in-out | linear | bezier */
        animationDuration: 700,		/* duration of animation transition in milliseconds */
        animationInterval: 2000,	/* interval between transitions or per slide show time in milliseconds */
        autoplay: true,			/* start playing Carousel continuously, pauses when slide is hovered  */
        controls: true,			/* control buttons */
        //  slideClass: 'jR3DCarouselSlide',/* name of the class of slides in custom template */
        navigation: '',		/* circles | squares | '' */
        rotationDirection: 'rtl',	/* rtl - right to left | ltr - left to right */
        onSlideShow: function () { }	/* callback when slide show event occurs */
    });




   

});

$(window).resize(function () {
    alterClass();
});

var alterClass = function () {
    var ww = document.body.clientWidth;
    if (ww >= 767 && ww < 1199) {
        $('div.col-md-4.float-left.media-992').removeClass('col-md-4');
    } else if (ww>1199) {
        $('div.float-left.media-992').addClass('col-md-4');
    }
};