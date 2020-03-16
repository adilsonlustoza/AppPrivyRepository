$(window).on('load', function () {
    $('div.container-image').on('click', function () {

        var imgSource = $(this).find('img').first();

        if (imgSource !== null) {

            var urlImage = imgSource.data('image');
            var captionImage = imgSource.data('caption');

            var lightImage = $('div.lightbox-content').find('img').first();

            if (lightImage !== null) {

                lightImage
                    .attr({ 'src': urlImage });

                $('div.lightbox-caption')
                    .find('p')
                    .empty()
                    .html(captionImage)
                    .css({ 'text-align': 'justify', 'color': 'white' });

                var options = {
                    backdrop: false,
                    keyboard: true,
                    show: true,
                    resizeToFit: false
                };

                $('#divLightBox').lightbox(options);
            }
        }
    });
});