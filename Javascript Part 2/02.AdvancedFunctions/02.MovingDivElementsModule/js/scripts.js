document.addEventListener("DOMContentLoaded", init);

function init() {
	var movingDivs = module();
	document.getElementById("btnAddToRectangle").addEventListener("click", function() {
		movingDivs.add(1);
	});
	document.getElementById("btnAddToCircle").addEventListener("click", function() {
		movingDivs.add(2);
	});
}

function module() {

	function CreateDiv() {
		var div = document.createElement("div");
		div.style.width = "50px";
		div.style.height = "50px";
		div.style.color = generateRandomColor();
		div.style.border = "1px" + " solid " + generateRandomColor();
		div.style.backgroundColor = generateRandomColor();
		div.style.position = "absolute";
		div.innerText = "Div";
		div.style.textAlign = "center";
		div.style.borderRadius = "50px";

		function generateRandomColor() {
			var red = (Math.random() * 256) | 0;
			var green = (Math.random() * 256) | 0;
			var blue = (Math.random() * 256) | 0;

			return "rgb(" + red + "," + green + "," + blue + ")";
		}

		return div;
	}           

	function addRect() {
		var div = CreateDiv();
		document.body.appendChild(div);
		moveRect(div);
	}

	function addCircle() {
		var div = CreateDiv();
		document.body.appendChild(div);
		moveInCircle(div);
	}

	function moveRect(element) {
		var top = 50;
		var left = 50;
		setInterval(function () {
			if (top <= 200 && left == 50) {
				top++;
			}
			else if (left <= 200 && top > 199) {
				left++;
			}
			else if (left > 199 && top >= 50) {
				top--;
			}

			else if (top < 51 && left >= 50) {
				left--;
			}
			element.style.top = top + "px";
			element.style.left = left + "px";
		}, 5);
	}

	function moveInCircle(element) {
		element.setAttribute("angleAttr", "0");
		element.style.left = "650px";
		element.style.top = "200px";
		
		setInterval(function () {
			var angleInRadians = (element.getAttribute("angleAttr")) * (Math.PI / 180);
			var left = 150 * Math.cos(angleInRadians) + 500;
			var top = 150 * Math.sin(angleInRadians) + 200;
			element.style.left = left + "px";
			element.style.top = top + "px";
			element.attributes.angleAttr.nodeValue++;
		}, 5);
	}

	function add(param) {
		if (param == "rectangle" || param == 1) {
			addRect();
		}
		if (param == "circle" || param == 2) {
			addCircle();
		}
	}

	return {
		add: add
	}
}