document.addEventListener("DOMContentLoaded", init);

function init() {
	var btn = document.getElementById("btnCheckNumber");
	btn.addEventListener("click", checkThirdNumber);
}

function checkThirdNumber() {
	var number = parseInt(document.getElementById("number").value);
	if(number == Number(number)) {
		number = number.toString();
		if(number.length >= 3) {
			var thirdNumber = getThirdNumber(number);
			if(thirdNumber == 7) {
				showMessage("Yes. The third number of " + number + " is 7");
			} else {
				showMessage("No. The third number of " + number + " is not 7. It is " + thirdNumber);
			}
		} else {
			showMessage("The number must be at least 3 digits long");
		}
	} else {
		showMessage("Please enter a number");
	}
}

function getThirdNumber(number) {
	var thirdNumber = number.charAt(2);
	return thirdNumber;
}

function showMessage(msg) {
	document.getElementById("answer").innerText = msg;
}