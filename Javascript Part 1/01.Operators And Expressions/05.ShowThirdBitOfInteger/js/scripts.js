document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnShowBit").addEventListener("click", showThirdBit);
}

function showThirdBit() {
	var number = parseInt(document.getElementById("number").value);
	if(number == Number(number)) {
		var mask = 1 << 3;
		if((mask & number) > 0) {
			showMessage("Third bit is 1");
		} else {
			showMessage("Third bit is 0");
		}
	} else {
		showMessage("Please enter a number");
	}
}

function showMessage(msg) {
	document.getElementById("answer").innerText = msg;
}