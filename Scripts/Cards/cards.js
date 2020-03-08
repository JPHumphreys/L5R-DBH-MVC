

function SetRatings(card) {

    //sets the ratings on the right side to the values of the card.
    for (let i = 0; i < (ratingLocations.length / 2); i++) {
        const ratingLocation = document.getElementById(ratingLocations[i]);
        ratingLocation.innerHTML = card.currentTarget.attributes[ratingLocations[(i + 7)]].value;
    }

}

function LoadVoteModal(card) {

    //sets the image to the card image and sets the id to the alt for easy access.
    voteModalImageLocation.attributes.src.value = getImageOfCard(card);
    voteModalImageLocation.attributes.alt.value = getIdOfCard(card);

    $("#vote-modal").modal("toggle");

    //after the modal has spawned
    SetRatings(card);
}

function GenerateCards(data) {


    for (let i = 0; i < data.length; i++) {
        var $cardObject = $("<div class='card col-lg-3 col-md-4 col-sm-6'></div>"),
            cardHeader = $("<div class='card-header text-muted'>" + data[i].name + "</div > "),
            cardImage = $("<img class='card-image'/>"),
            overallRating = $("<div class='card-footer text-muted'>" + "Rating: " + data[i].overallRating + "</div>");

        $(cardImage).attr({ src: data[i].imageLocation, alt: data[i].id });

        $cardObject.attr({
            clan: data[i].clan,
            side: data[i].side,
            type: data[i].cardType,
            military: data[i].military,
            political: data[i].political,
            glory: data[i].glory,
            crabRating: data[i].crabRating,
            craneRating: data[i].craneRating,
            dragonRating: data[i].dragonRating,
            lionRating: data[i].lionRating,
            phoenixRating: data[i].phoenixRating,
            scorpionRating: data[i].scorpionRating,
            unicornRating: data[i].unicornRating
        })

        $cardObject.append(cardHeader, cardImage, overallRating);

        $(".card-container").append($cardObject);
    }
}

function SearchForCards() {

    let inputValue = document.getElementById("card-search").value;
    const cards = document.querySelectorAll(".card");

    for (let i = 0; i < cards.length; i++) {
        if (cards[i].childNodes[0].textContent.toLowerCase().includes(inputValue.toLowerCase())) {
            cards[i].hidden = false;
        }
        else {
            cards[i].hidden = true;
        }
    }
}

function FilterWithSideBar(filter) {

    $(filter).addClass("selected");

    const category = filter.currentTarget.attributes["category"].value;
    const individual = filter.currentTarget.attributes["individual"].value;
    const cards = document.querySelectorAll(".card");

    for (let i = 0; i < cards.length; i++) {
        if (cards[i].attributes[category].value == individual)
            cards[i].hidden = false;
        else {
            cards[i].hidden = true;
        }
    }
}

function getImageOfCard(card) {
    return card.target.currentSrc;
}

function getIdOfCard(card) {
    return card.target.alt;
}