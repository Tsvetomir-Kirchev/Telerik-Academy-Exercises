document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnRevrseDigits").addEventListener("click", reverseDigits);
}

function reverseDigits() {
	var number = parseInt(document.getElementById("number").value);
	if(number == Number(number)) {
		number = number.toString();
		var reversed = "";
		for(var i = number.length - 1; i >= 0; i--) {
			reversed += number[i];
		}
		showMessage("Reversed: " + reversed);
	} else {
		showMessage("Please enter a number");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}