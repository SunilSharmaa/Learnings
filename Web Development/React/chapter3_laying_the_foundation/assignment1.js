import React from "react";
import ReactDOM from "react-dom/client";

let Headings = <div class="title">
    <h1>heading 1</h1>
    <h2>heading 2</h2>
    <h3>heading 3</h3>
</div>

let root = ReactDOM.createRoot(document.getElementById("container"));
root.render(Headings);