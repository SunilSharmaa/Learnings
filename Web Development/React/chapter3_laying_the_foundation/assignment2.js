import React from "react";
import ReactDOM from "react-dom/client";

let Para = ()=> {
    return <p>paragraph</p>;
}
let Heading = ()=> {
    return (<div class="title">
        <h1>heading 1</h1>
        {<Para />}
        <h2>heading 2</h2>
        {<Para />}
        <h3>heading 3</h3>
        {<Para />}
    </div>)
}

let root = ReactDOM.createRoot(document.getElementById("container"));
root.render(<Heading />)