document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnPrintNumbers").addEventListener("click", printNumbers);
}

function printNumbers() {
	var number = parseInt(document.getElementById("number").value);
	if(number == Number(number)) {
		var result = ""
		for(var i = 0; i <= number; i++) {
			result += (i + " ");
		}
		showMessage(result);
	} else {
		showMessage("PLease enter a number");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}