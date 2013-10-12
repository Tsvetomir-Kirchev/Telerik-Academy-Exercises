document.addEventListener("DOMContentLoaded", init);

function init() {
	var arr = [2, 32, 3, 2, 32, 2];
	var number = 2;
	var count = getCount(number, arr);
	
	showMessage("The number: " + number + " appear: " + count + " times in the array: " + "[" + arr.join(", ") + "]");
}

function getCount(number, arr) {
	var counter = 0;
	for(var i = 0; i < arr.length; i++) {
		if(arr[i] == number) {
			counter++;
		}
	}
	return counter;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML = (msg + "<br />");
}