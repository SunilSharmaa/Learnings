let heading = React.createElement(
    "h1", 
    {id: "heading"}, 
    "hello from react!"
);

let root = ReactDOM.createRoot(document.getElementById("base"));

root.render(heading);
