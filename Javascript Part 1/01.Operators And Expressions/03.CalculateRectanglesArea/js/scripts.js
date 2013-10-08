document.addEventListener("DOMContentLoaded", init);

function init() {
	var calculateButton = document.getElementById("calculate");
	calculateButton.addEventListener("click", claculateArea);
}

function claculateArea() {
	var width = parseFloat(document.getElementById("width").value);
	var height = parseFloat(document.getElementById("height").value);
	
	if(width == Number(width) && height == Number(height)) {
		var area = width * height;
		document.getElementById("area").innerText = area;
	} else {
		document.getElementById("area").innerText = "Please enter numbers for width and height";
	}
}