document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnPrintDigit").addEventListener("click", printLastDigit);
}

function printLastDigit() {
	var number = parseInt(document.getElementById("number").value);
	if(number == Number(number)) {
		number = number.toString();
		var digit = number[number.length - 1];
		showMessage(getDigitText(digit));
	} else {
		showMessage("Please enter a number");
	}
}

function getDigitText(digit) {
	switch(digit) {
		case "0":
			return "Zero";
			break;
		case "1":
			return "One";
			break;
		case "2":
			return "Two";
			break;
		case "3":
			return "Three";
			break;
		case "4":
			return "Four";
			break;
		case "5":
			return "Five";
			break;
		case "6":
			return "Six";
			break;
		case "7":
			return "Seven";
			break;
		case "8":
			return "Eight";
			break;
		case "9":
			return "Nine";
			break;
		default:
			return "Last digit is not a number";
			break;
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}