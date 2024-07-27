let myCar = new Object();
myCar.name = "Grand Vitara";
myCar.year = "2024";
myCar["color"] = "Dark grey";
myCar["variant"] = "Sigma";

console.log(myCar.name);
console.log(myCar.year);
console.log(myCar["color"]);
console.log(myCar["variant"]);

let str = "color";
console.log(myCar[str]);


myCar.color = "Black";
delete myCar.color;
console.log(myCar.color);

console.log('name' in myCar);
console.log("color" in myCar);

for(let temp in myCar) {
    console.log(myCar[temp]);
}