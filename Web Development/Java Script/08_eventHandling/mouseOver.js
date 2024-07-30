let element = document.getElementById("text");

element.onmouseover = () => {
    element.style.color = "red";
    element.style.fontSize = "30px";
}

element.onmouseout = () => {
    element.style.color = "black";
    element.style.fontSize = "1rem";
}