document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnCheckFotPrime").addEventListener("click", checkForPrime);
}

function checkForPrime() {
	var number = parseInt(document.getElementById("number").value);
	if(number == Number(number)) {
		var prime = true;
		for (var i = 2; i < Math.sqrt(number); i++) {
			if (number % i == 0) {
				prime = false;
				break;
			}
		}
		if(prime) {
			showMessage("The number " + number + " is prime");
		} else {
			showMessage("The number " + number + " is not prime");
		}
	} else {
		showMessage("Please enter a number");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}