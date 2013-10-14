document.addEventListener("DOMContentLoaded", init);

function init() {
	var text = "We are living in an yellow submarine. We don't have anything else." + 
		" Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
	var target = "in";
	var count = getCount(text, target);
	showMessage("Text: " + text);
	showMessage("occurrences of \"" + target + "\" case insensitive: " + count);
}

function getCount(text, target) {
	var count = 0;
	var index = -1;
	while (true) {
		index++;
		index = text.toUpperCase().indexOf(target.toUpperCase(), index);
		if (index == -1) {
			break;
		}
		count++;
	}
	return count;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}