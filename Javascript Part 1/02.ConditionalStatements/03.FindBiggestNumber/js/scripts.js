document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnFindBiggest").addEventListener("click", findBiggest);
}

function findBiggest() {
	var a = parseInt(document.getElementById("firstNumber").value);
	var b = parseInt(document.getElementById("secondNumber").value);
	var c = parseInt(document.getElementById("thirdNumber").value);
	if((a == Number(a)) && (b == Number(b)) && (c == Number(c))) {
		if(a > b) {
			if(a > c) {
				showMessage(a + " is the biggest number");
			} else if(a < c) {
				showMessage(c + " is the biggest number");
			}
			return;
		}
		if(b > a) {
			if(b > c) {
				showMessage(b + " is the biggest number");
			} else if(b < c) {
				showMessage(c + " is the biggest number");
			}
		}
	} else {
		showMessage("Please enter a numbers");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}