document.addEventListener("DOMContentLoaded", init);

function init() {
	var div = document.createElement("div");
	div.style.background = "#0000ff";
	div.innerText = "Div";
	var domModule = module();
	domModule.appendChild(div, "#wrapper");
	domModule.removeChild("#btnRemove", "#wrapper");
	var wrapper = document.getElementById("wrapper");
	wrapper.style.background = "#00ff00";
	wrapper.style.width = "300px";
	wrapper.style.height = "300px";
	domModule.addHandler("#wrapper", "click", function() {
		alert("Clicked in #wrapper");
	})
}

function module() {
	function appendChild(element, container) {
		var parent = document.querySelectorAll(container);
		for(var i = 0; i < parent.length; i++) {
			parent[i].appendChild(element);
		}
	}
	
	function removeChild(element, container) {
		var parent = document.querySelectorAll(container);
		for (var i = 0; i < parent.length; i++) {
			var child = parent[i].querySelectorAll(element);
			for (var j = 0; j < child.length; j++) {
				parent[i].removeChild(child[j]);
			}
		}
	}
	
	function addHandler(element, eventType, handler) {
		var el = document.querySelectorAll(element);
		for(var i = 0; i < el.length; i++) {
			el[i].addEventListener(eventType, handler);
		}
	}
	
	function appendToBuffer(parentSelector, tagName, attributes, innerHTML) {
		if (!fragmentsBuffer[parentSelector]) {
			fragmentsBuffer[parentSelector] = document.createDocumentFragment();
		}
		var element = createElement(tagName, attributes, innerHTML);
		fragmentsBuffer[parentSelector].appendChild(element);
		if (fragmentsBuffer[parentSelector].childNodes.length === MAX_FRAGMENT_SIZE) {
			var parent = getElement(parentSelector);
			parent.appendChild(fragmentsBuffer[parentSelector]);
			fragmentsBuffer[parentSelector] = null;
		}
	}
	
	return {
		appendChild: appendChild,
		removeChild: removeChild,
		addHandler: addHandler,
		appendToBuffe: appendToBuffer
	};
}