document.addEventListener("DOMContentLoaded", init);

function init() {
	var arr = [1, 23, 43, 2, 43, 54];
	arr.sort(function(a, b) {
		return a - b;
	});
	var el23 = binarySearch(arr, 23, 0, arr.length);
	showMessage(arr.join(", "));
	showMessage(arr[el23] + " is at index: " + el23);
	var el54 = binarySearch(arr, 54, 0, arr.length);
	showMessage(arr[el54] + " is at index: " + el54);
}

function binarySearch(array, element, min, max) {
	if(max < min) {
		return -1;
	}
	var middle = parseInt((min + max) / 2);

	if(array[middle] > element) {
		return binarySearch(array, element, min, middle - 1);
	} else if(array[middle] < element) {
		return binarySearch(array, element, middle + 1, max);
	} else {
		return middle;
	}
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}