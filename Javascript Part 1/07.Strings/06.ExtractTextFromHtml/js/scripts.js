document.addEventListener("DOMContentLoaded", init);

function init() {
	var htmlText = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";
	var text = extractText(htmlText);
	showMessage(htmlText + "\n");
	showMessage("Extracted text: " + text);
}

function extractText(htmlText) {
	return htmlText.replace(/<(.*?)>/g, "");
}

function showMessage(msg) {
	document.getElementById("result").innerText += msg;
}