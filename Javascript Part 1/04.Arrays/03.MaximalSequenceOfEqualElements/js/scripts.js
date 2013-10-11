document.addEventListener("DOMContentLoaded", init);

function init() {
	findMaximalSequence();
}

function findMaximalSequence() {
	var maximalSequence = 0;
	var firstIndex = 0;
	var lastIndex = 0;
	var counter = 0;
	
	var arr = [1, 32, 3, 5, 42, 5, 5, 4, 4, 4];
	
	for (var i = 0; i < arr.length - 1; i++) {
		if(arr[i] == arr[i + 1]) {
			counter++;
			if (counter > maximalSequence) {
				maximalSequence = counter;
				lastIndex = i + 1;
			}
		}
		if ((counter == maximalSequence) && (arr[i] != arr[i + 1])) {
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
	showMessage("Maximal sequence of equal elements: " + maxSequence.join(", "));
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}