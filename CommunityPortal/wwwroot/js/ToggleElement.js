function ToggleElement(elementId){
    let targetElement = $('#'+elementId);
    if (targetElement.is('[hidden]')){
        targetElement.removeAttr('hidden');
    } else {
        targetElement.attr('hidden', '');
    }
}

function ToggleElements(elementIdList){
    elementIdList.forEach(ToggleElement);
}