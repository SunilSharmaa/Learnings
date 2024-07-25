var a = null;
var result = a + 10;
console.log(result);


var b;
var result2 = b + 11;
console.log(result2);

console.log(varVariable); // Output: undefined

function example() {
    var varVariable = "I am a var";
    let letVariable = "I am a let";
    console.log(varVariable); // Output: "I am a var"
    console.log(letVariable); // Output: "I am a let"
}

example(); // Call the function


console.log(letVariable); // Throws a ReferenceEr