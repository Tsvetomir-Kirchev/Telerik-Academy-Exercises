document.addEventListener("DOMContentLoaded", init);

function init() {
	var arr = [2, 43, 12, 1, 2, 32, -5, 21];
	showMessage("Unsorted: " + arr.join(", "));
	selectionSort(arr);
	showMessage("Sorted: " + arr.join(", "));
}

function selectionSort(arr) {
	for(var i = 0; i < arr.length; i++) {
		var smallest = arr[i];
		var index = i;
		for(var j = i; j < arr.length; j++) {
			if(arr[j] < smallest) {
				smallest = arr[j];
				index = j;
			}
		}
		var temp = arr[index];
		arr[index] = arr[i];
		arr[i] = temp;		
	}
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}