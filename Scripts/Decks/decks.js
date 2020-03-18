
const deckRenderLocation = document.getElementById("deck-render-location");

function BuildDeck(deckName, primary, secondary, role, element) {

    let deck = document.createElement("div");
    deck.classList.add("col-sm-6", "col-md-4", "col-lg-3", "deck");
    //add the deckname here
    let name = document.createElement("h3");
    name.classList.add("deckname");
    name.innerText = deckName;

    CreateSecondary(secondary);
    CreateElement(element);

    deck.appendChild(name, CreateTopContainer(primary, role), CreateDeckButtons());

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

    buttonRow.appendChild(copy, remove);

    return buttonRow;
}

function CreateTopContainer(primaryName, roleName) {

    let container = document.createElement("div");
    container.classList.add("row", "deck-top-container");

    container.appendChild(CreatePrimary(primaryName), CreateRole(roleName));

    return container;
}

function CreatePrimary(name) {

    let primary = document.createElement("div");
    primary.classList.add("col-8", "primary");

    let text = document.createElement("h4");
    text.innerText = name;

    primary.appendChild(text);

    return primary;

}

function CreateRole(name) {

    let role = document.createElement("div");
    role.classList.add("col-3", "role");

    let image = document.createElement("img");
    image.setAttribute("src", "/Content/Media/" + name + "_colour.jpg");
    image.setAttribute("alt", name);

    role.appendChild(image);

    return role;
}


function CreateBottomContainer(secondaryName, elementName) {

}

function CreateSecondary(name) {

}


function CreateElement(name) {

}

function LoadUserDecks() {

    console.log("loading user decks...");

    //get the number of decks by the user
    //and store details within an array

    //for loop and create decks via the loop
    //by calling buildDeck(...);
}