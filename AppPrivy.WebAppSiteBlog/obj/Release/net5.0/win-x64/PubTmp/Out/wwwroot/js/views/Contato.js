
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

const validMark = (obj) => {

    try {

        let arrayFields = $(obj).serializeArray();

        if ($.isArray(arrayFields) && arrayFields.length > 0)
        {
            $.each(arrayFields, (_index, field) => {
                let _field = '#' + field["name"];
                if ($(_field).attr('aria-invalid') === 'true' || $(_field).val() === '')
                    $(_field).removeClass('is-valid').addClass('is-invalid');
                else if ($(_field).attr('aria-invalid') === 'false')
                    $(_field).removeClass('is-invalid').addClass('is-valid');
            });
        }
        else {
            if ($(obj).is('input') || $(obj).is('textarea')) {
                if ($(obj).attr('aria-invalid') === 'true' || $(obj).val() === '')
                    $(obj).removeClass('is-valid').addClass('is-invalid');
                else if ($(obj).attr('aria-invalid') === 'false')
                    $(obj).removeClass('is-invalid').addClass('is-valid');
            }
        }

    }
    catch (err) {
        console.error(err);
    }
}

$('input,textarea').on('keyup change blur', (e) => {
    validMark(e.target);
});


$('form').submit(function (e) {
    validMark(this);
});