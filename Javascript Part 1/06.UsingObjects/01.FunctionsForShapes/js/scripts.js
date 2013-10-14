document.addEventListener("DOMContentLoaded", init);

function init() {
	var p1 = new Point(15, 20);
	var p2 = new Point(35, 5);
	var distance = calculateDistance(p1, p2);
	showMessage("p1: " + p1.print());
	showMessage("p2: " + p2.print());
	showMessage("Distance between p1 and p2: " + distance);
	
	var l1 = new Line(new Point(12, 21), new Point(32, 34));
	var l2 = new Line(new Point(21, 22), new Point(32, 34));
	var l3 = new Line(new Point(4, 4), new Point(35, 5));
	showMessage("canFormTriangle with l1: " + l1.width + ", l2: " + l2.width + ", l3: " + l3.width + "? " + canFormTriangle(l1, l2, l3));
}

function Point(x, y) {
	this.x = x;
	this.y = y;
	this.print = function() {
		return "(" + x + ", " + y + ")";
	}
}

function Line(p1, p2) {
	this.width = calculateDistance(p1, p2);
}

function canFormTriangle(l1, l2, l3) {
	l1 = l1.width;
	l2 = l2.width;
	l3 = l3.width;
	
	if(l1 > l2 && l1 > l3) {
		if(l1 < (l2 + l3)){
			return true;
		} else {
			return false;
		}
	} else if(l2 > l1 && l2 > l3) {
		if(l2 < (l1 + l3)) {
			return true;
		} else {
			return false;
		}
	} else if(l3 > l1 && l3 > l2) {
		if(l3 < (l1 + l2)) {
			return true;
		} else {
			return false;
		}
	} else {
		return false;
	}
}

function calculateDistance(p1, p2) {
	var dx = p2.x - p1.x;
	var dy = p2.y - p1.y;
	var distance = Math.sqrt(dx * dx + dy * dy);
	return distance;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}