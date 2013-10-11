document.addEventListener("DOMContentLoaded", init);

function init() {
	findMaximalSequence();
}

function findMaximalSequence() {
	var maximalSequence = 0;
	var firstIndex = 0;
	var lastIndex = 0;
	var counter = 0;
	
	var arr = [1, 2, 3, 5, 3, 4, 5, 6, 5, 6];
	
	for (var i = 0; i < arr.length - 1; i++) {
		if((arr[i] + 1) == arr[i + 1]) {
			counter++;
			if (counter > maximalSequence) {
				maximalSequence = counter;
				lastIndex = i + 1;
			}
		}
		if ((counter == maximalSequence) && (arr[i] + 1 != arr[i + 1])) {
			lastIndex = i;
			counter = 0;
		}
	}

	firstIndex = lastIndex - maximalSequence;

	var maxSequence = new Array();
	for (var i = firstIndex; i <= lastIndex; i++) {
		maxSequence.push(arr[i]);
	}
	showMessage("Array: " + arr.join(", "));
	showMessage("Maximal sequence of increasing elements: " + maxSequence.join(", "));
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}