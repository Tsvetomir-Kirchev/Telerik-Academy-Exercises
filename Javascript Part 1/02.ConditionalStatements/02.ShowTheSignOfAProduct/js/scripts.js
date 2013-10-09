document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnShowSign").addEventListener("click", showSign);
}

function showSign() {
	var a = parseInt(document.getElementById("firstNumber").value);
	var b = parseInt(document.getElementById("secondNumber").value);
	var c = parseInt(document.getElementById("thirdNumber").value);
	if((a == Number(a)) && (b == Number(b))) {
		if(a == 0 || b == 0 || c == 0) {
			showMessage("The product is 0");
			return;
		}
		if ((a < 0 && b < 0) && c > 0) {
			showMessage("+");
		} else if ((a < 0 && c < 0) && b > 0) {
			showMessage("+");
		} else if ((b < 0 && c < 0) && a > 0) {
			showMessage("+");
		} else if (a > 0 && b > 0 && c > 0) {
			showMessage("+");
		} else {
			showMessage("-");
		}
	} else {
		showMessage("Please enter a numbers");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}