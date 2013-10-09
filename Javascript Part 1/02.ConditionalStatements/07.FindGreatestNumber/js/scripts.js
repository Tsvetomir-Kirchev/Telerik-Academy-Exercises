document.addEventListener("DOMContentLoaded", init);

function init() {
	var numbers = [10, 21, 0, 51, 12];
	var greatest = numbers[0];
	for(var i = 1; i < numbers.length; i++) {
		if(numbers[i] > greatest) {
			greatest = numbers[i];
		}
	}
	var resultDiv = document.getElementById("result");
	resultDiv.innerText = greatest;
}