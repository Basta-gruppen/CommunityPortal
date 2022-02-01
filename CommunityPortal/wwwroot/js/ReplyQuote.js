function SetReplyQuote(quoteId){
    $('#QuoteId').val(quoteId);
    let content = $(`#${quoteId}-content`).html();
    console.log(content)
    $('#QuoteContent').val(content);
}