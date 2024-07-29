function area(radius, callback) {
    let circleArea = 3.14 * radius * radius;
    callback(circleArea);
}

function displayArea(circleArea) {
    document.write(`Area of a circle is = `, circleArea);
}

area(5,displayArea);