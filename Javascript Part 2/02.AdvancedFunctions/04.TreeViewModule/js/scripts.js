document.addEventListener("DOMContentLoaded", init);

function init() {
	var treeView = new TreeView("div.tree-view");
	var jsNode = treeView.addNode("JavaScript", "#");

	var js1Subnode = jsNode.addNode("JavaScript - part 1", "#");
	var js2Subnode = jsNode.addNode("JavaScript - part 2", "#");
	var jsLibsSubnode = jsNode.addNode("JS Libraries", "#");
	var jsFrameworksSubnode = jsNode.addNode("JS Frameworks and UI", "#");

	var webNode = treeView.addNode("Web", "#");
}

function TreeNode(parent, title, url) {
    var item = createElement(title, url);
    parent.appendChild(item);

    function addNode(title, url) {
        var subtree = item.querySelector("ul");
        if (!subtree) {
            subtree = document.createElement("ul");
            subtree.style.listStyleType = "none";
            subtree.style.display = "none";
            item.appendChild(subtree);
        }

        var itemImage = item.querySelector("img");
        if (itemImage) {
            itemImage.src = getIcon(item);

            if (itemImage.addEventListener) {
                itemImage.addEventListener("click", onClickImage, false);
            } else {
                itemImage.attachEvent("onclick", onClickImage);
            }
        }

        var newNode = new TreeNode(subtree, title, url);
        return newNode;
    }

    function getIcon(element) {
        var subtree = element.querySelector("ul");
        if (!subtree) {
            return "images/blank.png";
        }

        if (subtree.style.display === "none") {
            return "images/collapsed.png";
        } else {
            return "images/expanded.png";
        }
    }

    function onClickImage(event) {
        if (!event) event = window.event;
        var eventSource = (event.target ? event.target : event.srcElement);
        var subtree = eventSource.parentElement.querySelector("ul");
        if (subtree) {
            if (subtree.style.display !== "none") {
                subtree.style.display = "none";
            }
            else {
                subtree.style.display = "block";
            }
            eventSource.src = getIcon(eventSource.parentElement);
        }
        if (event.preventDefault) {
            event.preventDefault();
        }

        return false;
    }

    function createElement(title, url) {
        var element = document.createElement("li");
        element.treeNode = this;

        var anchor = document.createElement("a");
        anchor.innerHTML = title;
        anchor.setAttribute("href", url);

        var image = document.createElement("img");
        image.src = getIcon(element);

        element.insertBefore(anchor, element.firstChild);
        element.insertBefore(image, element.firstChild);

        return element;
    }

    return {
        addNode: addNode
    };
}

function TreeView(selector) {
    var root = document.createElement("ul");
    root.style.listStyleType = "none";

    var wrapper = document.querySelector(selector);
    wrapper.appendChild(root);

    function addNode(title, url) {
        var node = new TreeNode(root, title, url);
        return node;
    }

    return {
        addNode: addNode
    };
}