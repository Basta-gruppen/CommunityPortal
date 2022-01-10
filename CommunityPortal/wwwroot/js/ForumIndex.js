const createContainer = $('#CreateNewForumContainer');

function ToggleCreateContainer(){
    if (createContainer.is('[hidden]')){
        createContainer.removeAttr('hidden');
    } else {
        createContainer.attr('hidden', '');
    }
}

function CreateNewForum(){
    let nameInput = $('#NewForumName').val();
    
    $.post("/Forum/Create", { Name:nameInput });
}