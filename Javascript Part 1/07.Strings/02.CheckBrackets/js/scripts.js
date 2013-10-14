document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnCheckExpression").addEventListener("click", checkExpression);
}

function checkExpression() {
	var expression = document.getElementById("expression").value;
	var arr = new Array();
	var correct = true;
	for(var i = 0; i < expression.length; i++) {
		if(expression[i] == "(") {
			arr.push("(");
		} 
		if(expression[i] == ")") {
			var closingBracket = arr.pop();
			if(closingBracket != "(") {
				correct = false;
			}
		}
	}
	if(arr.length > 0) {
		correct = false;
	}
	if(correct) {
		showMessage("The expression is correct");
	} else {
		showMessage("The expression is not correct");
	}
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}