const deckRenderLocation = document.getElementById("deck-render-location");

function CreatePrimary(name) {

    let primary = document.createElement("div");
    primary.classList.add("col-8", "primary");

    let text = document.createElement("h4");
    text.innerText = name;

    primary.appendChild(text);
    //debugger;

    return primary;

}

function CreateRole(name) {

    let role = document.createElement("div");
    role.classList.add("col-3", "role");

    let image = document.createElement("img");
    image.setAttribute("src", "/Content/Media/" + name + "_colour.jpg");
    image.setAttribute("alt", name);

    role.appendChild(image);
    //debugger;

    return role;
}

function CreateTopContainer(primaryName, roleName) {

    let container = document.createElement("div");
    container.classList.add("row", "deck-top-container");

    container.appendChild(CreatePrimary(primaryName));
    container.appendChild(CreateRole(roleName));

    return container;
}

function CreateBottomContainer(secondaryName, elementName) {

    let container = document.createElement("div");
    container.classList.add("row", "deck-bottom-container");

    container.appendChild(CreateSecondary(secondaryName));
    container.appendChild(CreateElement(elementName));

    return container;
}

function CreateSecondary(name) {

    let secondary = document.createElement("div");
    secondary.classList.add("col-8", "secondary");

    let text = document.createElement("h5");
    text.innerText = name;

    secondary.appendChild(text);
    //debugger;

    return secondary;
}


function CreateElement(name) {

    let element = document.createElement("div");
    element.classList.add("col-3", "element");

    let image = document.createElement("img");
    image.setAttribute("src", "/Content/Media/" + name + "_colour.jpg");
    image.setAttribute("alt", name);

    element.appendChild(image);
    //debugger;

    return element;
}

function CreateDeckButtons() {

    let buttonRow = document.createElement("div");
    buttonRow.classList.add("row", "btn-group", "button-row");

    let copy = document.createElement("button");
    copy.classList.add("btn", "btn-md", "btn-dark", "copy-button");
    copy.innerText = "Copy";
    copy.addEventListener("click", function () {
        CopyDeck(this);
    });

    let remove = document.createElement("button");
    remove.classList.add("btn", "btn-md", "btn-dark", "delete-button");
    remove.innerText = "Delete";
    remove.addEventListener("click", function () {
        DeleteDeck(this);
    });

    buttonRow.appendChild(copy, remove);

    return buttonRow;
}