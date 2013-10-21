document.addEventListener("DOMContentLoaded", init);

function init() {
	var liTags = document.getElementsByTagName("li");
	for (var i = 0; i < liTags.length; i++) {
		liTags[i].addEventListener("click", revealSubList);
	}
	
	var uls = document.getElementsByTagName("ul");
	for(var i = 0; i < uls.length; i++) {
		if(i == 0) {
			uls[i].style.display = "block";
		} else {
			uls[i].style.display = "none";
		}
	}
}

function revealSubList(clickedUl) {
	if (typeof(this.getElementsByTagName("ul")[0]) == "undefined") {
		return 0;
	}
	if (this == clickedUl.target && this.getElementsByTagName("ul")[0].style.display == "block") {
		this.getElementsByTagName("ul")[0].style.display = "none";
	}
	else {
		this.getElementsByTagName("ul")[0].style.display = "block";
	}
}