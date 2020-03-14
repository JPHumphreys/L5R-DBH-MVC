
const deckRenderLocation = document.getElementById("deck-render-location");

function BuildDeck(deckName, primary, secondary, role, element) {

    let deck;
    //add the deckname here


    CreatePrimary(primary);
    CreateSecondary(secondary);
    CreateRole(role);
    CreateElement(element);
    CreateDeckButtons();


    deckRenderLocation.appendChild(deck);
}

function CreateDeckButtons() {

}


function CreatePrimary(primary) {

}

function CreateSecondary(secondary) {

}

function CreateRole(role) {

}

function CreateElement(element) {

}

function LoadUserDecks() {

    console.log("loading user decks...");

    //get the number of decks by the user
    //and store details within an array

    //for loop and create decks via the loop
    //by calling buildDeck(...);
}