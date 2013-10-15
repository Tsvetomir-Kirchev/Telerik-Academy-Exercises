document.addEventListener("DOMContentLoaded", init);

function init() {
	var wrapper = document.getElementById("wrapper");
	for(var i = 0; i < 20; i++) {
		var div = createDiv();
		wrapper.appendChild(div);
	}
}

function createDiv() {
	var width = Math.floor(Math.random() * (100 - 20) + 20);
	var height = Math.floor(Math.random() * (100 - 20) + 20);
	var backgroundColor = getRandomRGBColor();
	var fontColor = getRandomRGBColor();
	var top = getTopPosition(height);
	var left = getLeftPosition(width);
	var div = document.createElement("div");
	div.style.width = Math.floor(Math.random() * (100 - 20) + 20) + "px";
	div.style.height = Math.floor(Math.random() * (100 - 20) + 20) + "px";
	div.style.backgroundColor = backgroundColor;
	div.style.color = fontColor;
	div.style.position = "absolute";
	div.style.top = top;
	div.style.left = left;
	var strong = createStrong();
	div.appendChild(strong);
	div.style.borderRadius = getRandomBorderRadius();
	div.style.border = getRandomBorder() + " solid " + getRandomRGBColor();
	return div;
}

function getRandomRGBColor() {
	return "rgb(" + Math.floor((Math.random() * (250 - 0) + 0)) + ", " +
		Math.floor((Math.random() * (2500 - 0) + 0)) + ", " + 
		Math.floor((Math.random() * (250 - 0) + 0)) + ")";
}

function getTopPosition(height) {
	var maxHeight = Math.random() * (window.innerHeight - height) + height;
	return Math.floor(maxHeight) + "px";
}

function getLeftPosition(width) {
	var maxWidth = Math.random() * (window.innerWidth - width) + width;
	return Math.floor(maxWidth) + "px";
}

function createStrong() {
	var strong = document.createElement("strong");
	strong.innerText = "div";
	return strong;
}

function getRandomBorderRadius() {
	return Math.floor(Math.random() * (20 - 0) + 0) + "px";
}

function getRandomBorder() {
	return Math.floor(Math.random() * (20 - 1) + 1) + "px";
}