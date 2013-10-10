document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnConvertNumber").addEventListener("click", convertNumberToText);
}

function convertNumberToText() {
	var number = parseInt(document.getElementById("number").value);
	if(number == Number(number)) {
		if(number == 0) {
			showMessage("zero");
		} else if(number < 10) {
			showMessage(convertUnitsToText(number));
		} else if(number >= 10 && number <= 19) {
			showMessage(convertTeensToText(number));
		} else if(number >= 20 && number <= 99) {
			showMessage(convertDecimalsToText(number.toString()));
		} else if(number >= 100 && number <= 999) {
			showMessage(convertHudredsToText(number.toString()));
		}
	} else {
		showMessage("Please enter a number");
	}
}

function convertUnitsToText(number) {
	var ones = [
		"", "one", "two", "three", "four", 
		"five", "six", "seven", "eight", "nine"
	];
	return ones[number];
}

function convertTeensToText(number) {
	var teens = [
		"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
		"sixteen", "seventeen", "eighteen", "nineteen"
	];
	return teens[number - 10];
}

function convertDecimalsToText(number) {
	var tens = [
		"", "", "twenty", "thirty", "forty", "fifty",
		"sixty", "seventy", "eighty", "ninety"
	];
	var units = parseInt(number[1]);
	var decimalNumber = parseInt(number[0]);
	return tens[decimalNumber] + " " + convertUnitsToText(units);
}

function convertHudredsToText(number) {
	var hundreds = [
		"", "one hundred ", "two hundred ", "three hundred ", "four hundred",
		"five hundred ", "six hundred ", "seven hundred ", "eight hundred ", "nine hundred "
	];
	var units = parseInt(number[2]);
	var decimals = parseInt(number[1] + number[2]);
	var hundredNumber = parseInt(number[0]);	
	var result = "";
	
	if(decimals == 0) {
		result = hundreds[hundredNumber];
	}
	else if(decimals <= 9) {
		result = hundreds[hundredNumber] + "and " + convertUnitsToText(units);
	} else if(decimals >= 10 && decimals <= 19) {
		result = hundreds[hundredNumber] + "and " + convertTeensToText(decimals.toString());
	} else if(decimals == 20 || decimals == 30 || decimals == 40
		|| decimals == 50 || decimals == 60 || decimals == 70 || decimals == 80 || decimals == 90) {
		result = hundreds[hundredNumber] + "and " + convertDecimalsToText(decimals.toString());
	} else {
		result = hundreds[hundredNumber] + convertDecimalsToText(decimals.toString());
	}
	return result;
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}