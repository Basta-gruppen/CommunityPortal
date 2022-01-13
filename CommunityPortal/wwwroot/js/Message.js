 

function SendMessage() {
    messageId = document.getElementById("message").value
    $.post("/Conversation/CreateConversation", { id: messageId }, function (data) {
        console.log(data)
        $("#getMessage").html(data);
    });
}