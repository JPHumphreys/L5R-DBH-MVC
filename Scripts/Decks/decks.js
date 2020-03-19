
function BuildDeck(deckName, primary, secondary, role, element) {

    let deck = document.createElement("div");
    deck.classList.add("col-sm-6", "col-md-4", "col-lg-3", "deck");
    //add the deckname here
    let name = document.createElement("h3");
    name.classList.add("deckname");
    name.innerText = deckName;

    //debugger;
    deck.appendChild(
        name,
        CreateTopContainer(primary, role),
        CreateBottomContainer(secondary, element),
        CreateDeckButtons());

    deckRenderLocation.appendChild(deck);
}

function CopyDeck(element) {
    console.log(element);
}

function DeleteDeck(element) {
    console.log(element);
}



function LoadUserDecks() {

    console.log("loading user decks...");

    //get the number of decks by the user
    //and store details within an array

    //for loop and create decks via the loop
    //by calling buildDeck(...);
}