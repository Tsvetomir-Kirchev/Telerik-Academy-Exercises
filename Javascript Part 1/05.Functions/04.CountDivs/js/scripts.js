document.addEventListener("DOMContentLoaded", init);

function init() {
	countDivs();
}

function countDivs() {
	var divs = document.getElementsByTagName("div");
	document.getElementById("result").innerText = "There are " + divs.length + " divs";
}