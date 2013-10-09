document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnSort").addEventListener("click", sortDescending);
}

function sortDescending() {
	var firstNumber = parseInt(document.getElementById("firstNumber").value);
	var secondNumber = parseInt(document.getElementById("secondNumber").value);
	var thirdNumber = parseInt(document.getElementById("thirdNumber").value);
	if((firstNumber == Number(firstNumber)) && (secondNumber == Number(secondNumber)) && (thirdNumber == Number(thirdNumber))) {
		var highNumber;
		var middleNumber;
		var lowNumber;

		if(firstNumber > secondNumber && firstNumber > thirdNumber) {
			highNumber = firstNumber;
		} else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
			highNumber = secondNumber;
		} else {
			highNumber = thirdNumber;
		}

		if((firstNumber < secondNumber && firstNumber > thirdNumber) ||
			(firstNumber > secondNumber && firstNumber < thirdNumber)) {
			middleNumber = firstNumber;
		} else if ((secondNumber < firstNumber && secondNumber > thirdNumber) ||
			(secondNumber > firstNumber && secondNumber < thirdNumber)) {
			middleNumber = secondNumber;
		} else
		{
			middleNumber = thirdNumber;
		}

		if(firstNumber < secondNumber && firstNumber < thirdNumber) {
			lowNumber = firstNumber;
		} else if (secondNumber < firstNumber && secondNumber < thirdNumber) {
			lowNumber = secondNumber;
		} else {
			lowNumber = thirdNumber;
		}

		firstNumber = highNumber;
		secondNumber = middleNumber;
		thirdNumber = lowNumber;
		
		showMessage(firstNumber + ", " + secondNumber + ", " + thirdNumber);
	} else {
		showMessage("Please enter a numbers");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}