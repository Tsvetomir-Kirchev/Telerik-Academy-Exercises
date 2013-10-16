document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("fontColor").addEventListener("input", changeFontColor);
	document.getElementById("backgroundColor").addEventListener("input", changeBackgroundColor);
}

function changeFontColor() {
	var area = document.getElementById("txtArea");
	var color = document.getElementById("fontColor").value;
	area.style.color = color;
}

function changeBackgroundColor(e) {
	var area = document.getElementById("txtArea");
	var color = document.getElementById("backgroundColor").value;
	area.style.backgroundColor = color;
}