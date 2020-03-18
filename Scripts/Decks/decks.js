﻿
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

function CopyDeck(element) {
    console.log(element);
}

function DeleteDeck(element) {
    console.log(element);
}

function CreateDeckButtons() {

    let buttonRow = document.createElement("div");
    buttonRow.classList.add("row", "btn-group", "button-row");

    let copy = document.createElement("button");
    copy.classList.add("btn","btn-md", "btn-dark", "copy-button");
    copy.innerText = "Copy";
    copy.addEventListener("click", function(){
        CopyDeck(this);
    });

    let remove = document.createElement("button");
    remove.classList.add("btn","btn-md", "btn-dark", "delete-button");
    remove.innerText = "Delete";
    remove.addEventListener("click", function(){
        DeleteDeck(this);
    });

    return buttonRow;
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