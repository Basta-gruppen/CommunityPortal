$("#AjaxForm").submit(function (e){
    e.preventDefault();

    let form = $(this);
    let actionUrl = form.attr('action');

    $.post(actionUrl, form.serialize(), null)
        .done(function (){
            //location.reload();
        })
        .fail(function (data){
            DisplayErrorMessage(data.statusText + ": " + data.responseText);
        });
});