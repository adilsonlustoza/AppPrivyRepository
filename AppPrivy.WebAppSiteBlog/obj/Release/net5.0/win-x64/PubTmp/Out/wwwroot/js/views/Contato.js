
var url = window.location.href;

$('.btn.btn-outline-primary').on('click', function () {
    ajaxObjects.sendPost(url, 'form', true, '.btn.btn-primary');
});


$("#Telefone")
    .mask("(99) 9999-9999?9")
    .focusout(function (event) {
        var target, phone, element;
        target = (event.currentTarget) ? event.currentTarget : event.srcElement;
        phone = target.value.replace(/\D/g, '');
        element = $(target);
        element.unmask();
        if (phone.length > 10) {
            element.mask("(99) 99999-999?9");
        } else {
            element.mask("(99) 9999-9999?9");
        }
    });

    $('input,textarea').on('keyup blur change click submit',function()
    {  
       if( $(this).attr('aria-invalid')==='true')    
           $(this).removeClass('is-valid').addClass('is-invalid');
      else if( $(this).attr('aria-invalid')==='false')    
           $(this).removeClass('is-invalid').addClass('is-valid');
    });