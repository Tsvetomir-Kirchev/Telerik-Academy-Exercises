document.addEventListener("DOMContentLoaded", init);

function init() {
	Array.prototype.remove = function(el) {
		for(var i = 0; i < this.length; i++) {
			if(this[i] === el) {
				this.splice(i, 1);
				i--;
			}
		}
	}
	
	var arr = [1, 2, 21, 2, 1, 1, 2, 1, 4];
	showMessage("arr: " + "[" + arr.join(", ") + "]");
	arr.remove(1);
	showMessage("arr.remove(1): " + "[" + arr.join(", ") + "]");
	arr.remove(2);
	showMessage("arr.remove(2): " + "[" + arr.join(", ") + "]");
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}