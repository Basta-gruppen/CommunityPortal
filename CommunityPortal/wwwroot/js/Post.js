$(document).ready(function(e) {
    $(".link-subscribe").click(function (e) {
        e.preventDefault();
        const $that = $(this);
        $.ajax({
            type: "POST",
            url: "/Category/"+$that.data("state")+"/"+$that.data("categoryid"),
            success: function (data) {
                let state = "Subscribe";
                if ($that.data("state") === "Subscribe") {
                    state = "Unsubscribe";
                }
                $that.data("state", state);
                $that.text(state)
            },
        });
    });
})