document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnCalculate").addEventListener("click", findRoots);
}

function findRoots() {
	var a = parseInt(document.getElementById("a").value);
	var b = parseInt(document.getElementById("b").value);
	var c = parseInt(document.getElementById("c").value);

	if((a == Number(a)) && (b == Number(b)) && (c == Number(c))) {
		var D = (b * b) - (4 * a * c);
		if (D < 0) {
			showMessage("The quadratic equation do not have real roots.");
		} else if (D == 0) {
			var x = (-b) / (2 * a);
			showMessage("The quadratic equation has one real root: " + x);
		} else {
			var x1 = ((-b) + Math.sqrt(D)) / (2 * a);
			var x2 = ((-b) - Math.sqrt(D)) / (2 * a);

			showMessage("The quadratic equation has 2 real roots: x1 = " + x1 + ", x2 = " + x2);
		}
	} else {
		showMessage("Please enter a numbers");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}