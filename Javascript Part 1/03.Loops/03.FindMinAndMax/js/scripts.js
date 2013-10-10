document.addEventListener("DOMContentLoaded", init);

function init() {
	findMinAndMax();
}

function findMinAndMax() {
	var sequence = [43, 4324, 21, 0, -32, 32, 53];
	showMessage("Min: " + getMin(sequence));
	showMessage("Max: " + getMax(sequence));
}

function getMin(sequence) {
	var min = sequence[0];
	for(var i = 1; i < sequence.length; i++) {
		if(sequence[i] < min) {
			min = sequence[i];
		}
	}
	return min;
}

function getMax(sequence) {
	var max = sequence[0];
	for(var i = 1; i < sequence.length; i++) {
		if(sequence[i] > max) {
			max = sequence[i];
		}
	}
	return max;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}