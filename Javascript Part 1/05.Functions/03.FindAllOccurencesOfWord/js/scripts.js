document.addEventListener("DOMContentLoaded", init);

function init() {
	document.getElementById("btnWordOccurrences").addEventListener("click", showOccurences);
}

function showOccurences() {	
	var text = document.getElementById("text").value;
	var word = document.getElementById("word").value;
	getAllOccurrences(text, word, true)
}

function getAllOccurrences(text, word, caseSensitive) {
	var words = text.split(/[,  ?!;.]+/);
	var count = 0;
	for(var i = 0; i < words.length; i++) {
		if(words[i] == word) {
			count++;
		}
	}
	showMessage("The word " + word + " occur " + count + " times in the text: " + text);
}

function showMessage(msg) {
	document.getElementById("result").innerText = msg;
}