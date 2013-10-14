document.addEventListener("DOMContentLoaded", init);

function init() {
	var text = "    some    text here";
	showMessage(text + "\n");
	var replacedText = replaceSpaces(text);
	showMessage(replacedText);
}

function replaceSpaces(text) {
	var replaced = "";
	for(var i = 0; i < text.length; i++) {
		if(text[i] == " ") {
			replaced += "&nbsp;";
		} else {
			replaced += text[i];
		}
	}
	return replaced;
}

function showMessage(msg) {
	document.getElementById("result").innerText += msg;
}