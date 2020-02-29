
ajaxObjects =
    {
        sendPost: function (action, formData, async, loader) {
            try {
                var _action = action;
                var _async = async;
                var _dataserialize = $(formData).serialize();

                $.ajax
                    ({
                        url: _action,
                        data: _dataserialize,
                        method: 'POST',
                        dataType: 'json',
                        context: document.all,
                        async: _async,
                        crossOrigin: false,
                        beforeSend: function () {
                            $(loader).after('<img src=\'../../images/commons/ajax-loader.gif\' alt=\'loader\' id=\'imgLoader\' style=\'width:3%;height:3%;margin-left:2%\'  />');
                        },
                        success: function (response) {

                            if (response.Data === 'NoK')
                                $.toaster({ priority: 'info', title: 'Informação', message: 'Verifique todos os campos do formulário!' });
                            if (response.Data === 'NoCaptcha')
                                $.toaster({ priority: 'danger', title: 'Atenção', message: 'Inconsistência ao validar a segurança!' });
                            else if (response.Data === 'Ok') {
                                $.toaster({ priority: 'success', title: 'Confirmação', message: 'Dados enviados com sucesso!' });
                                global.clearForm(formData);
                            }

                        },
                        error: function (xhr, status, error) {
                            var _error = 'Error  : ' + error + '\r\n';
                            _error += 'Status : ' + status + '\r\n';
                            _error += 'Xhr : ' + xhr.responseText + '\r\n';
                            console.log(_error);
                        },
                        complete: function (response) {
                            $('#imgLoader').remove();
                            grecaptcha.reset();

                        }
                    });
            }
            catch (err) {
                console.log('Err in method  sendPost :' + err.message);
            }
        }

    };