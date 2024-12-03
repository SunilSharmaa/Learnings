let heading = React.createElement(
    "div",
    {id:"parent"},
    React.createElement(
        "div",
        {id:"child"},
        React.createElement(
            "h1",
            {},
            "I.m h1 tag"
        )
    )
);

let root = ReactDOM.createRoot(document.getElementById("base"));

root.render(heading);
