document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnCalculateArea").addEventListener("click", calculateArea);
}

function calculateArea() {
	var a = parseFloat(document.getElementById("a").value);
	var b = parseFloat(document.getElementById("b").value);
	var h = parseFloat(document.getElementById("h").value);
	if(a == Number(a) && b == Number(b) && h == Number(h)) {
		var area = ((a + b) / 2) * h;
		showMessage("The area of the trapezoid is: " + area);
	} else {
		showMessage("Please enter numbers for 'a', 'b' and 'h'");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}