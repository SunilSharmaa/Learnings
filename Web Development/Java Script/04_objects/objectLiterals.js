let myCar = {
    name: "Grand Vitara",
    model: 2024,
    color: "Dark grey",
    show: function()  {
        for(let key in this) {
            console.log(this[key]);
        }
    }
};

myCar.show();

