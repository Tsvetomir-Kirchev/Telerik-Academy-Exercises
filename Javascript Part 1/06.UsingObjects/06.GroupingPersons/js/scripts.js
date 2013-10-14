document.addEventListener("DOMContentLoaded", init);

function init() {
	Person = function(firstname, lastname, age) {
		this.firstname = firstname;
		this.lastname = lastname;
		this.age = age;
	};
	var arr = [
		new Person("Gosho", "Petrov", 32),
		new Person("Jack", "Daniels", 18),
		new Person("Jonny", "Walker", 20)
	];
	
	for(var p in arr) {
		showMessage(arr[p].firstname + " " + arr[p].lastname + " " + arr[p].age);
	}
	var groupedArr = group(arr, "firstname");
	showMessage("grouped by firstname: ");
	for(var p in groupedArr["firstname"]) {
		showMessage(arr[p].firstname + " " + arr[p].lastname + " " + arr[p].age);
	}
}

// Very strange and confusing condition for this exercise.
// Why it is necessary to return associative array with keys: properties, and why we need to group by only one, 
// when we need to return associative array with all the 3?
function group(persons, property) {
	var arr = new Array();
	arr["firstname"] = new Array(persons.length);
	arr["lastname"] = new Array(persons.length);
	arr["age"] = new Array(persons.length);
	for(var p in persons) {
		arr["firstname"].push(persons[p]);
		arr["lastname"].push(persons[p]);
		arr["age"].push(persons[p]);
	}
	if(property == "firstname") {
		arr["firstname"].sort(function(a, b) {
			return b - a;
		});
	} else if(property == "lastname") {
	arr["lastname"].sort(function(a, b) {
			return b - a;
		});
	} else if(property == "age") {
		arr["age"].sort(function(a, b) {
			return a - b;
		});
	} else {
		showMessage("There is no property: " + property);
	}
	return arr;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}