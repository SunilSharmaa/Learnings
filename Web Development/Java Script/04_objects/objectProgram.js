

let myCar = new Object();
myCar.name = "Vitara Brezza";
myCar.year = "2024";
myCar.color = "Dark grey";

myCar.model = new Object();
myCar.model.variant = "Zxi";

myCar.show = function() {
    for(let i in myCar) {
        if (typeof myCar[i] !== "function") {
        console.log(myCar[i]);
        }
    }
}
myCar.show();