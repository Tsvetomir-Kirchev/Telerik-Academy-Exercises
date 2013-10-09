document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnShowName").addEventListener("click", sortDescending);
}

function sortDescending() {
	var digit = parseInt(document.getElementById("digit").value);
	
	switch(digit) {
		case 0:
			showMessage("Zero");
			break;
		case 1:
			showMessage("One");
			break;
		case 2:
			showMessage("Two");
			break;
		case 3:
			showMessage("Three");
			break;
		case 4:
			showMessage("Four");
			break;
		case 5:
			showMessage("Five");
			break;
		case 6:
			showMessage("Six");
			break;
		case 7:
			showMessage("Seven");
			break;
		case 8:
			showMessage("Eight");
			break;
		case 9:
			showMessage("Nine");
			break;
		default:
			showMessage("Please enter a digit");
			break;
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}