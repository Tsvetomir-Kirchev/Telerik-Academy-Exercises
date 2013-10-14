document.addEventListener("DOMContentLoaded", init);

function init() {
	var Person = function(fname, lname) {
		this.fname = fname;
		this.lname = lname;
		this.fullName = fname + " " + lname;
	};
	var obj = new Person("Tsvetomir", "Kirchev");
	showMessage("obj.fullName: " + obj.fullName);
	var cloneObj = deepCopy(obj);
	showMessage("cloneObj.fullName: " + cloneObj.fullName);
	showMessage("changed fname of cloneObj");
	cloneObj.fname = "xXx";
	showMessage("obj.fname: " + obj.fname);
	showMessage("cloneObj.fname: " + cloneObj.fname);
	var i = 5;
	showMessage("i: " + i);
	var ci = deepCopy(i);
	showMessage("the clone of i, ci: " + ci);
	var s = "string";
	showMessage("s: ");
	var cs = deepCopy(s);
	showMessage("the clone of s, cs: " + cs);
}

function deepCopy(obj) {
	if(typeof obj == "number" || typeof obj == "string") {
		return obj;
	} else {
		var clone = {};
		for(var i in obj) {
			if(typeof(obj[i])=="object" && obj[i] != null)
				clone[i] = cloneObject(obj[i]);
			else
				clone[i] = obj[i];
		}
		return clone;
	}
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}