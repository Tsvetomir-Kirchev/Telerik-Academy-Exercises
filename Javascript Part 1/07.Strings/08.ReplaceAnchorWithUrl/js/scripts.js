document.addEventListener("DOMContentLoaded", init);

function init() {
	var text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course." + 
	" Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
	var modifiedText = replaceAnchor(text);
	showMessage("Original text: ");
	showMessage(text);
	showMessage("Replaced text: ");
	showMessage(modifiedText);
}

function replaceAnchor(text) {
	return text.replace(/<a href="(.*?)">(.*?)<\/a>/g, "[URL=$1]$2[/URL]");
}

function showMessage(msg) {
	document.getElementById("result").innerText += (msg + "\n");
}