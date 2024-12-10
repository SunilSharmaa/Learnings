import React from "react";
import ReactDOM from "react-dom/client";

let Footer = () => <h4>Footer</h4>;
let Heading = () => {
  return <h2>Heading</h2>;
};


let div = (
  <div>
    <Heading />
    <h1>imported jsx_</h1>
    <div>
      <h2>export jsx_</h2>
    </div>
    {<Footer />}
  </div>
);

let root = ReactDOM.createRoot(document.getElementById("head"));
root.render(div);
