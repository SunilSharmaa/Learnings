let toggleButton = document.getElementById("toggle-button");
let navItems = document.getElementById("nav-items");
toggleButton.addEventListener("click", ()=> {
    navItems.classList.toggle("hidden");
})