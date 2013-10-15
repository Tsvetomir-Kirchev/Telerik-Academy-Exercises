document.addEventListener("DOMContentLoaded", init);

function init() {
	var text = "some@mail.com, hello, this is text and this is secon email: anothermail@coolmail.com";
	var emails = new Array();
	emails = extractEmails(text);
	for(var i = 0; i < emails.length; i++) {
		showMessage(emails[i]);
	}
}

function extractEmails(text) {
	var arr = text.match(/\w+@\w+\.\w+/g);
	return arr;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}