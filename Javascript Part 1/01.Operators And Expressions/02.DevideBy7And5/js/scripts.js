document.addEventListener("DOMContentLoaded", init);

function init() {
	var button = document.getElementById("btnDevide");
	button.addEventListener("click", checkForReminder);
}

function checkForReminder() {
	var number = parseInt(document.getElementById("number").value);
	var result = "No";
	if(number == Number(number)) {
		if(number % 7 == 0 && number % 5 == 0) {
			result = "Yes";
		}
	} else {
		result = "Please enter a number";
	}
	document.getElementById("result").innerText = result;
}