$(document).ready(function () {

    jQuery.data(document.body, "ConteudoImagem", $('#Images').html());

    $('.summernote').summernote({
        height: 300,                 // set editor height
        minHeight: 100,             // set minimum height of editor
        maxHeight: null,             // set maximum height of editor
        focus: true,                  // set focus to editable area after initializing summernote
        callbacks: {
            onImageUpload: function (files, editor, welEditable) {
                sendFile(files[0], editor, welEditable, this);
            }
        }
    });

    function sendFile(file, editor, welEditable, component) {

        var formData = new FormData();
        formData.append("file", file);
        formData.append("TipoTabela", $('#IdTipoTabela').val());
        formData.append("CodTabela", $('#ID').val());


        $.ajax({
            data: formData,
            type: 'POST',
            url: '/LogicalMindsDoc/Cadastro/UploadFile',
            cache: false,
            contentType: false,
            processData: false,
            success: function (url) {
                UpdateImagensUpload();
                console.log('URLImage', url);
                $(component).summernote('editor.insertImage', url);
            },
            error: function (xhr, textStatus, error) {
                console.log('Não foi possível receber a imagem.');
            }
        });
    }

    $('.img-upload').click(function () {
        $('.modal-dialog').find('.close').click();
        $('.summernote').summernote('editor.insertImage', $(this).attr('src'));
    });
});

function UpdateImagensUpload() {

    var formData = new FormData();
    formData.append("TipoTabela", $('#IdTipoTabela').val());
    formData.append("CodTabela", $('#ID').val());

    $.ajax({
        data: formData,
        type: 'POST',
        url: '/LogicalMindsDoc/Cadastro/GetImagens',
        cache: false,
        contentType: false,
        processData: false,
        success: function (data) {
            console.log('UpdateImagensUpload', data);

            $('#ImagensUpload').html('')

            $.each(data, function (index, value) {

                var html = '<div class="col-xs-3 col-sm-2 col-md-1 col-lg-2">' +
                '    <a href="#" class="thumbnail">' +
                '        <img src="' + value + '" class="img-responsive img-upload">' +
                '    </a>' +
                '</div>';

                $('#ImagensUpload').append(html);
            });

            //Antes de exibir o modal de fotos, deve atualizar o modal.
            jQuery.data(document.body, "ConteudoImagem", $('#Images').html());
        },
        error: function (xhr, textStatus, error) {
            console.log('Não foi possível receber a imagem.');
        }
    });
}

function showalert(message, alerttype) {

    $('#alert_placeholder').append('<div id="alertdiv" class="alert ' + alerttype + '"><a class="close" data-dismiss="alert">×</a><span>' + message + '</span></div>')

    setTimeout(function () { // this will automatically close the alert and remove this if the users doesnt close it in 5 secs
        $("#alertdiv").fadeOut("slow", function () {
            $("#alertdiv").remove();
        });
    }, 1500);
}