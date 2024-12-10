import React from "react";
import ReactDOM from "react-dom/client"

let div = (<div>
    <h1>imported jsx_</h1>
    <div>
        <h2>export jsx_</h2>
    </div>
</div>);
let root = ReactDOM.createRoot(document.getElementById("head"));
root.render(div)