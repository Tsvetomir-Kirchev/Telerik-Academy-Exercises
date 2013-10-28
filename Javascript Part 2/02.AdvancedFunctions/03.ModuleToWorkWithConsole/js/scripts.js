document.addEventListener("DOMContentLoaded", init);

function init() {
	var specialConsole = module();
	var point = {
		x: 5,
		y: 3
	};
	
	specialConsole.writeLine("Message: Hello!");
	specialConsole.writeLine("Message: {0}", "Hello!");
	specialConsole.writeLine("This is the object Point: {0}", point);
	specialConsole.writeError("Error: {0}", "Something happened");
	specialConsole.writeWarning("Warning: {0}", "A warning");
}

function module() {

	function writeLine() {
		for (var i = 0; i < arguments.length; i++) {
			arguments[i] = JSON.stringify(arguments[i]);
		}

		while (arguments[0].search(/{(\d)}/) != -1) {
			arguments[0].match(/{(\d)}/);
			var num = parseInt(RegExp.lastMatch.replace(/{(\d)}/, "$1"));
			arguments[0] = arguments[0].replace(/{(\d)}/, arguments[num + 1]);
		}
		console.log(arguments[0].toString());
	}

	function writeError() {
		for (var i = 0; i < arguments.length; i++) {
			arguments[i] = JSON.stringify(arguments[i]);
		}

		while (arguments[0].search(/{(\d)}/) != -1) {
			arguments[0].match(/{(\d)}/);
			var num = parseInt(RegExp.lastMatch.replace(/{(\d)}/, "$1"));
			arguments[0] = arguments[0].replace(/{(\d)}/, arguments[num + 1]);
		}
		console.error(arguments[0].toString());
	}

	function writeWarning() {
		for (var i = 0; i < arguments.length; i++) {
			arguments[i] = JSON.stringify(arguments[i]);
		}

		while (arguments[0].search(/{(\d)}/) != -1) {
			arguments[0].match(/{(\d)}/);
			var num = parseInt(RegExp.lastMatch.replace(/{(\d)}/, "$1"));
			arguments[0] = arguments[0].replace(/{(\d)}/, arguments[num + 1]);
		}
		console.warn(arguments[0].toString());
	}
	
	return {
		writeLine: writeLine,
		writeError: writeError,
		writeWarning: writeWarning
	}
}