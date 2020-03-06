



function GenerateCards(data) {
    for (let i = 0; i < data.length; i++) {
        var $cardObject = $("<div class='card col-lg-3 col-md-4 col-sm-6'></div>"),
            cardHeader = $("<div class='card-header text-muted'>" + data[i].name + "</div > "),
            cardImage = $("<img class='card-image'/>"),
            overallRating = $("<div class='card-footer text-muted'>" + "Rating: " + data[i].overallRating + "</div>");
        //debugger;
        $(cardImage).attr({ src: data[i].imageLocation, alt: data[i].id });
        $cardObject.attr({ clan: data[i].clan, side: data[i].side, type: data[i].cardType })
        $cardObject.append(cardHeader, cardImage, overallRating);
        $(".card-container").append($cardObject);
    }
}
