

$(".on-grid").hover(
    function () {
        AddClass($(this));
    }, function () {
        RemoveClass($(this));
    }
);

function AddClass(gridItem) {
    gridItem.addClass(GetSpecific(gridItem));
}

function RemoveClass(gridItem) {
    gridItem.removeClass(GetSpecific(gridItem));
}

function GetSpecific(gridItem) {
    const id = gridItem.get(0).attributes["id"].value;
    const specificId = id.split('-');
    return specificId[1];
}
