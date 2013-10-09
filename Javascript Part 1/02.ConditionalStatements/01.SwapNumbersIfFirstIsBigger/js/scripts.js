document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnCheck").addEventListener("click", swapValues);
}

function swapValues() {
	var firstNumber = parseInt(document.getElementById("firstNumber").value);
	var secondNumber = parseInt(document.getElementById("secondNumber").value);
	if((firstNumber == Number(firstNumber)) && (secondNumber == Number(secondNumber))) {
		if(firstNumber > secondNumber) {
			var temp = firstNumber;
			firstNumber = secondNumber;
			secondNumber = temp;
			showMessage("First Number: " + firstNumber + ", Second Number: " + secondNumber);
		} else {
			showMessage("First Number: " + firstNumber + ", Second Number: " + secondNumber);
		}
	} else {
		showMessage("Please enter a numbers");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}