document.addEventListener("DOMContentLoaded", init);

function init() {
	var url = "http://tsvetomir-kirchev.com/about";
	showMessage("url: " + url);
	parseUrl(url);
}

function parseUrl(url) {
	var protocolEndIndex = url.indexOf("://");
	var protocol = url.substring(0, protocolEndIndex);
	
	var serverFirstIndex = protocolEndIndex + 3;
	var serverLastIndex = url.indexOf("/", serverFirstIndex);
	var server = url.substring(serverFirstIndex, (serverLastIndex - serverFirstIndex) + 3);
	
	var resource = "";
	if (serverLastIndex + 1 < url.length) {
		resource = url.substring(serverLastIndex + 1);//url.length - serverLastIndex - 2);
	}
	
	showMessage("protocol: " + protocol);
	showMessage("server: " + server);
	showMessage("resource: " + resource);
}

function showMessage(msg) {
	document.getElementById("result").innerText += (msg + "\n");
}