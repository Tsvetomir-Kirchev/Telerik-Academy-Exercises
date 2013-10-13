document.addEventListener("DOMContentLoaded", init);

function init() {
    var obj = {
        firstName: "Tsvetomir",
        lastName: "kirchev",
        age: 27
    };
    showMessage("obj: ");
    for (var p in obj) {
        showMessage(p + ": " + obj[p])
    }
    var containsFirstName = checkObjectForProperty(obj, "firstName");
    if (containsFirstName) {
        showMessage("obj contains property firstName");
    } else {
        showMessage("obj does not contain property firstName");
    }
    var strangePoroperty = checkObjectForProperty(obj, "strange");
    if (strangePoroperty) {
        showMessage("obj contains strange property");
    } else {
        showMessage("obj does not contain strange property");
    }
}

function checkObjectForProperty(obj, property) {
    if(obj.hasOwnProperty(property)) {
        return true;
    } else {
        return false;
    }
}

function showMessage(msg) {
    document.getElementById("result").innerHTML += (msg + "<br />");
}