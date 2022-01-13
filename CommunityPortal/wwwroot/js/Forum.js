const createContainer = $('#CreateNewForumContainer');

function ToggleCreateContainer(){
    if (createContainer.is('[hidden]')){
        createContainer.removeAttr('hidden');
    } else {
        createContainer.attr('hidden', '');
    }
}