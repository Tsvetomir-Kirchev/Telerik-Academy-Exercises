document.addEventListener("DOMContentLoaded", init);

function init() {
	var button = document.getElementById("btnOddEven");
	button.addEventListener("click", oddOrEven);
}

function oddOrEven() {
	var number = parseInt(document.getElementById("number").value);
	var result = "odd";
	if( number == Number(number)) {
		if(number % 2 == 0) {
			result = "even";
		}
	} else {
		result = "Please enter a number";
	}
	
	document.getElementById("result").innerText = result;
}