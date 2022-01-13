let errorBoxContainer = $("#ErrorBoxContainer");
let errorBox = $("#ErrorBox");

function DisplayErrorMessage(errorMessage){
    // Show container visibility
    if (errorBoxContainer.is('[hidden]')){
        errorBoxContainer.removeAttr('hidden');
    }
    
    errorBox.html(errorMessage);
}