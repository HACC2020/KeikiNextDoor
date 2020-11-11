//Focus an element
window.focus = function focus(element) {
    element.focus();
};

//Set an item in local storage
window.setItem = function setItem(key, value) {
    window.localStorage.setItem(key, value);
}

//Get an item from local storage
window.getItem = function getItem(key) {
    return window.localStorage.getItem(key);
}

//Remove an item from local storage
window.removeItem = function removeItem(key) {
    window.localStorage.removeItem(key);
}

//Clear local storage
window.clear = function clear() {
    window.localStorage.clear();
}
