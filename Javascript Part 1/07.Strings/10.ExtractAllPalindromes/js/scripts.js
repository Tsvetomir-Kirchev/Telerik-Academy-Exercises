document.addEventListener("DOMContentLoaded", init);

function init() {
	var text = "This is text with palindromes such as abba, exe, php.";
	showMessage("Text: " + text);
	var palidromes = getAllPalindromes(text);
	showMessage("Palindromes: " + palidromes.join(", "));
}

function getAllPalindromes(text) {
	var words = text.split(/[,  ?!;.]+/);
	var palindromes = new Array();
	for(var i = 0; i < words.length; i++) {
		var word = words[i];
		var isPalindrome = true;
		for(var j = 0; j < words[i].length / 2; j ++) {
			if(word[j] != word[word.length - j - 1]) {
				isPalindrome = false;
				break;
			}
		}
		if(isPalindrome) {
			palindromes.push(word);
		}
	}
	return palindromes;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}