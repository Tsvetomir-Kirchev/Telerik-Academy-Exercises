document.addEventListener("DOMContentLoaded", init);

function init() {
	findProperties();
}

function findProperties() {
	showMessage("Lexicographically smallest document property: " + getLexicographicallySmallest(document));
	showMessage("Lexicographically largest document property: " + getLexicographicallyLargest(document));
	showMessage("Lexicographically smallest window property: " + getLexicographicallySmallest(window));
	showMessage("Lexicographically largest window property: " + getLexicographicallyLargest(window));
	showMessage("Lexicographically smallest navigator property: " + getLexicographicallySmallest(navigator));
	showMessage("Lexicographically largest navigator property: " + getLexicographicallyLargest(navigator));
}

function getLexicographicallySmallest(obj) {
	var smallest = null;;
	for(item in obj) {
		if(smallest == null) {
			smallest = item;
		}
		if(item < smallest) {
			smallest = item;
		}
	}
	return smallest;
}

function getLexicographicallyLargest(obj) {
	var largest = null;
	for(item in obj) {
		if(largest == null) {
			largest = item;
		}
		if(item > largest) {
			largest = item;
		}
	}
	return largest;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}