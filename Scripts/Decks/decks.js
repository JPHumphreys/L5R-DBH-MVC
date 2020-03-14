
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