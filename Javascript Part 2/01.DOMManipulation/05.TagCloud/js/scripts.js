document.addEventListener("DOMContentLoaded", init);

function init() {
	var tags = [
		"cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", 
		"css", "wordpress", "xaml", "js", "http", "web", "asp.net", 
		"asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", 
		"cms", "html", "javascript", "http", "http", "CMS"
	];
	var tagCloud = generateTagCloud(tags, 17, 42);
	document.body.appendChild(tagCloud);
}

function generateTagCloud (tags, minFontSize, maxFontSize) {
	var wordsCount = countWords(tags);
	var div = document.createElement("div");
	div.style.width = "300px";
	div.style.border = "2px solid black";

	var min = Number.MAX_VALUE;
	var max = 0;

	for (var word in wordsCount) {
		if (wordsCount[word] > max) {
			max = wordsCount[word];
		}
		if (wordsCount[word] < min) {
			min = wordsCount[word];
		}              
	}

	for (var word in wordsCount) {
		var span = document.createElement("span");

		if (min==wordsCount[word]) {
			span.style.fontSize = minFontSize + "px";
		}
		else if (max == wordsCount[word]) {
			span.style.fontSize = maxFontSize + "px";
		}
		else {
			span.style.fontSize = minFontSize + ((maxFontSize - minFontSize) / ((max - wordsCount[word])+1))+"px";
		}
		span.innerText = word+" ";
		div.appendChild(span);
	}
	return div;
}

function countWords (tags) {
	var wordsCount = {};
	var word = {};
	for(var i in tags) {
		word = tags[i].toLowerCase();
		if (wordsCount[word]) {
			wordsCount[word]++;
		}
		else {
			wordsCount[word] = 1;
		}
	}
	return wordsCount;
}