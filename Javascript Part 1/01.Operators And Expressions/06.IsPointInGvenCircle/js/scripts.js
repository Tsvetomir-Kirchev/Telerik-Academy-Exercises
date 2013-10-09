document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnCheckPoint").addEventListener("click", checkPoint);
}

function checkPoint() {
	var x = parseInt(document.getElementById("x").value);
	var y = parseInt(document.getElementById("y").value);
	if((x == Number(x)) && (y == Number(y))) {
		if ((x > -1 && x < 5) && (y > -1 || y < 1))	{
			showMessage("The point [" + x + "," + y + "] is in the circle K(0,5)");
		} else {
			showMessage("The point [" + x + "," + y + "] is not in the circle K(0,5)");
		}
	} else {
		showMessage("Please enter a numbers for 'X' and 'Y'");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}