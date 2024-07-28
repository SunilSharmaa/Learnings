let rectangle = {
    width : 0,
    height : 0,

    setRectangle : function() {
        let inputNumber = prompt(`Enter width of rectangle`);

        rectangle.width = parseInt(inputNumber);

        inputNumber = prompt(`Enter height of rectangle`);

         rectangle.height = parseInt(inputNumber);

    },

    area : function() {
        return (rectangle.width + rectangle.height);
    },

    perimeter : function() {
        return (2 * (rectangle.width + rectangle.height));
    }
};

rectangle.setRectangle();
let area = rectangle.area();
let perimeter = rectangle.perimeter();
console.log(`Area of rectangle ${area}`);
console.log(`Perimeter of rectangle ${perimeter}`);