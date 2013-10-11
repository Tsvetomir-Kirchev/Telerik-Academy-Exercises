document.addEventListener("DOMContentLoaded", init);

function init() {
	var arr1 = ["c", "d", "c", "a"];
	var arr2 = ["a", "b", "c", "d"];
	
	showMessage("First array: " + arr1.join(", "));
	showMessage("Second array: " + arr2.join(", "));
	for(var i = 0; i < arr1.length; i++) {
		if(arr1[i] > arr2[i]) {
			showMessage(arr1[i] + " > " + arr2[i]);
		} else if(arr1[i] < arr2[i]) {
			showMessage(arr1[i] + " < " + arr2[i]);
		} else {
			showMessage(arr1[0] + " = " + arr2[i]);
		}
	}
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}