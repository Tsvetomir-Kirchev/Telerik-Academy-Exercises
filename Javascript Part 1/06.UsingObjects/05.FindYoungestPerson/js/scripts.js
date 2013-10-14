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
	
	var youngest = getYoungestPerson(arr);
	showMessage("The youngest person is: " + youngest.firstname + " " + youngest.lastname + " " + youngest.age);
}

function getYoungestPerson(arr) {
	var youngest;
	var min = 1000;
	for(var person in arr) {
		if(min > arr[person].age) {
			min = arr[person].age;
			youngest = arr[person];
		}
	}
	return youngest;
}

function showMessage(msg) {
	document.getElementById("result").innerHTML += (msg + "<br />");
}