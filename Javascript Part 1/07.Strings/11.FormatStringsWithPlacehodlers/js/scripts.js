document.addEventListener("DOMContentLoaded", init);

function init() {
	var text = "Hello {0}, How are you. This is {1}. Thanks {0}.";
	showMessage("Not formatted text: " + text);
	var formattedText = formatText(text, "Tsvetomir", "fun");
	showMessage("Formatted: " + formattedText);
}

function formatText(text) {
	var args = arguments;

	return text.replace(/\{(\d+)\}/g, function(match, p1) {
		return args[+p1 + 1]
	});
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}