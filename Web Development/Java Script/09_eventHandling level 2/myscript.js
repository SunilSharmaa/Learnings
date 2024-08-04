let ul = document.getElementById("listContainer");

ul.addEventListener("click", (event)=>{
    if(event.target.tagName === "LI"){
        event.target.remove();

    }
})

let button = document.getElementById("addNewElement");

button.addEventListener("click", ()=>{
    let text = prompt("Enter new checklist name");
    if(text) {
        let li = document.createElement("li");
        li.textContent = text;
        ul.appendChild(li);
    }
})