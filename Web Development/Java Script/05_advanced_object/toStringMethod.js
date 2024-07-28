let myBike = {
    name : "Meteor 350",
    model : 2024,
    variant : "Stellar Black"
};

myBike.toString = function() {
    return `${myBike.name}, ${myBike.model}, ${myBike.variant}`
}

// document.write(myBike)
console.log(myBike);