document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnCheckPoint").addEventListener("click", checkPoint);
}

function checkPoint() {
	var x = parseInt(document.getElementById("x").value);
	var y = parseInt(document.getElementById("y").value);
	if((x == Number(x)) && (y == Number(y))) {
		if ((x > -1 && x < 3) && (y > -1 || y < 1))	{
			if((x >= -1 && x <= 6) && (y >= 1 && y <= 2))
			showMessage("The point [" + x + "," + y + "] is in the circle K(1,3) and inside the rectangle R((-1,1), (6, 2))");
		} else {
			showMessage("The point [" + x + "," + y + "] is not in the circle K(0,5) and outside the rectangle R((-1,1), (6, 2))");
		}
	} else {
		showMessage("Please enter a numbers for 'X' and 'Y'");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}