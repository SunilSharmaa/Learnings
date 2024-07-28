//this alone
document.write(this);

//this with function
var x = 5;
function sample() {
    var x = 10;
    return this.x;
}

document.write(`<br> ${sample()}`)

// var x = 5;
// function sample() {
//     var x = 10;
//     return this.x;
// }
// document.write(`<br> ${sample()}`);


//this with method
let myCar = {
    name : "Grand Vitara",
    color : "Dark Grey",
    model : 2023,

    //methods
    toString : function() {
        return `${this.name}, ${this.color}, ${this.model}`
    }
};

document.write(`<br> ${myCar}`)

