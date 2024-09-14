//event bubbling
let grandParent = document.getElementById("grand-parent");
grandParent.addEventListener("click", (e)=> {
    console.log("Grand Parent");
    // e.stopPropagation();
},true)

let parent = document.getElementById("parent");
parent.addEventListener("click", (e)=> {
    console.log("Parent");
    // e.stopPropagation();
},true)

let me = document.getElementById("me");
me.addEventListener("click", (e)=> {
    console.log("Me");
    // e.stopPropagation();
},true)