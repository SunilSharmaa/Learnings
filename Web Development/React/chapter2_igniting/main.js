import React from "react";
import ReactDOM from 'react-dom/client';


let heading = React.createElement(
    "div",
    {id:"parent"},[
        React.createElement(
            "div",
            {id:"child"},[
                React.createElement("h1",{},"I.m h1 tag"),
                React.createElement("h2",{},"i,m h2 tag")
            ]
        ),
        React.createElement(
            "div",
            {id:"child2"},[
                React.createElement("h1",{},"I.m h1 tag"),
                React.createElement("h2",{},"i,m h2 tag")
            ]
        )
        
    ]
)

let root = ReactDOM.createRoot(document.getElementById("base"));

root.render(heading);
