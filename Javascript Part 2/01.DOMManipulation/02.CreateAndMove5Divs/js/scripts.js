document.addEventListener("DOMContentLoaded", function() {
	var maxHeight = screen.height - 400;
	var maxWidth = screen.width - 400;
	var topX = 300;
	var leftY = 500;
	var circleRadius = 150;                
	var angle = 0;
	var angleStep = 5;
	var interval = 100;
	var divCounter = 5;
	var wrapper = document.getElementById("wrapper");

	for (var i = 0; i < divCounter; i++) {
		angle += angleStep;
		generateDiv(wrapper, angle);
	}

	var divs = document.getElementsByTagName("div");
	var repeat = setInterval(function () {
		for (var i = 0, len = divs.length; i < len; i++) {
			angle += angleStep;
			updatePosition(divs[i]);
		}
	}, interval);

	function updatePosition(currentElement) {
		var currentXPosition = topX + Math.cos(angle) * circleRadius;
		currentElement.style.top = currentXPosition + "px";

		var currentYPosition = leftY + Math.sin(angle) * circleRadius;
		currentElement.style.left = currentYPosition + "px";
	}

	function generateDiv(node, angle) {
		var currentElement = document.createElement("div");
		currentElement.style.position = "absolute";
		currentElement.style.width = "50px";
		currentElement.style.height = "50px";
		currentElement.style.borderRadius = "50px";
		currentElement.style.background = "#0000ff";
		updatePosition(currentElement);
		node.appendChild(currentElement);
	}            
});