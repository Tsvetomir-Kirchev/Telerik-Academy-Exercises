document.addEventListener("DOMContentLoaded", init);

function init() {
	var people = [ 
		{ name: 'Tsvetomir', age: 27 },  
		{ name: 'Jack', age: 18 },  
		{ name: 'Jim', age: 22 }  
    ];
	var result = generateList(people, document.getElementById("result").innerHTML);
	showMessage(result);
}

function generateList(people, template) {
	var result = "<ul>";

	people.forEach(function(human) {
		result += "<li>";
		result += template.replace(/-\{(.*?)\}-/g, function(match, p1) {
			return human[p1]
		});

		result += "</li>";
	});

	result += "</ul>";
	return result;
}

function showMessage(msg) {
	document.getElementById("result").outerHTML = (msg);
}