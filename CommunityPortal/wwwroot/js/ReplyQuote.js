function SetReplyQuote(quoteId){
    $('#QuoteId').val(quoteId);
    let content = $(`#${quoteId}-content`).html();
    $('#QuoteContent').val(content);
}