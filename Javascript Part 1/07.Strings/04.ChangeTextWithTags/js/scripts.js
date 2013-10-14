document.addEventListener("DOMContentLoaded", init);

function init() {
	var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>." + 
	" We <mixcase>don't</mixcase> have <lowcase>Anything</lowcase> else."
	document.getElementById("result").innerText = text;
	showMessage();
	var txt = changeText(text);
	showMessage("Changed: " + txt);
}

function changeText(str) {
	return str.replace(/<upcase>(.*?)<\/upcase>/g, function(match, p1) {
		return p1.toUpperCase()
	}).replace(/<lowcase>(.*?)<\/lowcase>/g, function(match, p1) {
		return p1.toLowerCase()
	}).replace(/<mixcase>(.*?)<\/mixcase>/g, function(match, p1) {
		return mixCase(p1)
	});
}

function mixCase(str) {
	var replaced = "";
	for (i = 0; i < str.length; i++) {
		replaced += str.charAt(i)[Math.round(Math.random()) ? "toLowerCase" : "toUpperCase"]()
	}
	return replaced;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}