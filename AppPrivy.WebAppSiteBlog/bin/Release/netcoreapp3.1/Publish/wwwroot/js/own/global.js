$(window).on('resize load', function () {

    var padding = $('div.menu').height();
    var menumob = $('div.menu-hamburger').width();

    if (padding !== 0) {
        $('body').css('padding-top', padding);
    }

    if (menumob !== 0) {
        $('.mobile-hamburger nav ul li a').css('width', menumob);
    }

});


$(window).on('resize', function () {    
    var menumob = $('div.menu-hamburger').width();      
    if(menumob > 280)
        $('.mobile-hamburger nav').css('display', 'none');       

});


//$('div.menu').click(function () {
//    try {
//        var display = $('.mobile-hamburger nav').css('display');

//        if (display === 'block')
//            $('.mobile-hamburger nav').css('display', 'none');
//        else
//            $('.mobile-hamburger nav').css({ 'display': 'block', 'position': 'absolute', ' margin-top': '5.5' });
//    }
//    catch (err) {
//        console.log(`div.menu click error : ${err.message}`);
//    }
//});



//$('#banner1').css({ 'background-color': 'transparent', 'width': '24%', 'height': '10%', 'left': '55%', 'top': '66%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'Analista/Programador/SistemasWeb\'' });
//$('#banner2').css({ 'background-color': 'transparent', 'width': '15%', 'height': '10%', 'left': '70%', 'top': '73%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'Analista/Programador/EngenhariaDeSoftware\'' });
//$('#banner3').css({ 'background-color': 'transparent', 'width': '22%', 'height': '15%', 'left': '63%', 'top': '42%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'Analista/Programador/\'' });
//$('#banner4').css({ 'background-color': 'transparent', 'width': '18%', 'height': '10%', 'left': '25%', 'top': '63%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'Analista/Programador/Android\'' });
//$('#banner5').css({ 'background-color': 'transparent', 'width': '26%', 'height': '10%', 'left': '65%', 'top': '71%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'Analista/Programador/Contato\'' });



const Search = () =>
{
    try {
        var objFrm = $('#frmPesquisa');

        if (objFrm!==null)
            $(objFrm).submit();
        else
            console.log(``);
    }
    catch (err) {
        console.log(`Error in method Pesquisa ${err.message}`);
    }
}

const global =
    {
        clearForm: function (formData) {
            try {
                $(formData).find('input[type=\'text\'],textarea,input[type=\'email\']').val('');
                $(formData).find('input[name=\'Telefone\'],input[type=\'tel\']').val('');
                $(formData).find('input[type=\'checkbox\']').attr({ 'checked': 'true' });
                $(formData).find('input[type=\'radio\']').first().attr({ 'checked': 'true' });
                $(formData).find('select').val('0');
            }
            catch (err) {
                console.log('Erro na funcao clearform : ' + err.message);
            }
        }
    };

$(function () {
    $('[data-toggle="tooltip"]').tooltip();
});


$(document).ready(function () {

    var url = window.location.href;
    
    $(".menu nav ul li a").each(function () {     

        if (url === this.href) {
            if (url.indexOf('SistemasWeb')!==-1 || url.indexOf('EngenhariaDeSoftware')!==-1 || url.indexOf('Android')!== -1)
                $(".menu nav ul li a").eq(3).css('color', '#5bc0de');
            else
                $(this).css('color', '#5bc0de');
        }
       
        
    });


    $('div.menu').click(function () {
        try {
            var display = $('.mobile-hamburger nav').css('display');

            if (display === 'block')
                $('.mobile-hamburger nav').css('display', 'none');
            else
                $('.mobile-hamburger nav').css({ 'display': 'block', 'position': 'absolute', ' margin-top': '5.5' });
        }
        catch (err) {
            console.log(`div.menu click error : ${err.message}`);
        }
    });



    $('#banner1').css({ 'background-color': 'transparent', 'width': '24%', 'height': '10%', 'left': '55%', 'top': '66%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'/SistemasWeb\'' });
    $('#banner2').css({ 'background-color': 'transparent', 'width': '15%', 'height': '10%', 'left': '70%', 'top': '73%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'/EngenhariaDeSoftware\'' });
    $('#banner3').css({ 'background-color': 'transparent', 'width': '22%', 'height': '15%', 'left': '63%', 'top': '42%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'/Programador/\'' });
    $('#banner4').css({ 'background-color': 'transparent', 'width': '18%', 'height': '10%', 'left': '25%', 'top': '63%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'/Android\'' });
    $('#banner5').css({ 'background-color': 'transparent', 'width': '26%', 'height': '10%', 'left': '65%', 'top': '71%', 'cursor': 'pointer' }).attr({ 'onclick': 'javascript:window.location.href=\'/Contato\'' });


   
    
});