function getUser(){
    $.get("/Conversation/UserIndex", function (data) {
        console.log(data)
        $("#UserList").html(data);
    });
}

function getConversation() {
    $.get("/Conversation/Conversation", function (data) {
        $("#UserList").html(data);
    });
}

function SendMessage() {
    messageId = document.getElementById("message").value
    content = document.getElementById("content").value
    $.post("/Message/Create", { content: content, id: messageId }, function (data) {
        console.log(data)
        $("#getMessage").html(data);
    });
}
