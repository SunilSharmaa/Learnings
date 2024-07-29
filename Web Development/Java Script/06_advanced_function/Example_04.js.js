let person = {
    name : "John",
    age : 30,
    city : "New york",

    greet : function() {
        console.log(`My name is ${this.name} and i am ${this.age} year old.`);
    },

    changedCity : function(arg) {
        this.city = arg;
        console.log(`Moved to ${this.city}`);
    }
}

person.greet();
person.changedCity("los Angeles");

for(let key in person) {
    if(typeof person[key] === 'function') {
        console.log(`Method: ${key}`);
    }
    else {
        console.log(`Property: ${key}: ${person[key]}`);
    }
}