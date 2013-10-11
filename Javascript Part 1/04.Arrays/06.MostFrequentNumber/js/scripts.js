document.addEventListener("DOMContentLoaded", init);

function init() {
	var arr = [1, 2, 43, 5, 32, 5, 6, 5, 46, 6, 5];
	getMostFrequentNumber(arr);
}

function getMostFrequentNumber(arr) {
	showMessage(arr.join(", "));
	arr.sort(function(a, b) {
		return a - b;
	});
	
	var counter = 1;
	var mostFrequentNumber = 0;
	var frequencyCount = 0;
	for (var i = 0; i < arr.length - 1; i++) {
		if (arr[i] == arr[i + 1]) {
			counter++;
			if (frequencyCount < counter) {
				mostFrequentNumber = arr[i];
				frequencyCount = counter;
			}
		} else {
			counter = 1;
		}
	}
	showMessage("The most frequent number is: " + mostFrequentNumber);
	showMessage("It appear: " + frequencyCount + " times");
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}