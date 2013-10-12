document.addEventListener("DOMContentLoaded", init);

function init() {
	var arr = [1, 32, 4, 43, 4, 5];
	var firstBigger = getFirstBigger(arr);
	if(firstBigger == -1) {
		showMessage("There is no element that is bigger than its neighbours in the array: " + "[" + arr.join(", ") + "]");
	} else {
		showMessage("Array: " + "[" + arr.join(", ") + "]");
		showMessage("The first element that is bigger than its neighbours is: " + arr[firstBigger]);
	}
}

function getFirstBigger(arr) {
	var index = -1;
	if(arr.length > 2) {
		for(var i = 1; i < arr.length -1; i++) {
			if((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1])) {
				index = i;
				break;
			}
		}
	}
	return index;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}