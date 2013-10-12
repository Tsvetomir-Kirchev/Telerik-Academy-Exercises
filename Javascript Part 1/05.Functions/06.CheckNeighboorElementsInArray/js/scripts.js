document.addEventListener("DOMContentLoaded", init);

function init() {
	var arr = [2, 32, 3, 23, 4, 42, 3];
	var index = 3;
	var isBiggerThanNeighboors = isBigger(index, arr);
	if(isBiggerThanNeighboors) {
		showMessage("The element at index: " + " is bigger than its neighbours at the array: " + "[" + arr.join(", ") + "]");
	} else {
		showMessage("The element at index: " + " is not bigger than its neighbours at the array: " + "[" + arr.join(", ") + "]");
	}
}

function isBigger(index, arr) {
	var isBigger = false;
	if(index < 0 || index > arr.length) {
		showMessage("The index is out of range");
		return;
	}
	if(arr.length < 2) {
		showMessage("The element of index: " + index + " do not have 2 neighbours");
	} else {
		if((arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1])) {
			isBigger = true;
		}
	}
	return isBigger;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML = (msg + "<br />");
}