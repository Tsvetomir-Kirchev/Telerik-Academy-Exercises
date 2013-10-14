document.addEventListener("DOMContentLoaded", init);

function init() {
	var str = "Hello";
	showMessage("String: " + str);
	var reversedStr = reverseString(str);
	showMessage("Reversed String: " + reversedStr);
}

function reverseString(s) {
	return s.split("").reverse().join("");
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}