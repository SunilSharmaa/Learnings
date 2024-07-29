function multiply(arg1, arg2, callback) {
    let product = arg1 * arg2;
    document.write(`Multiplication of ${arg1} and ${arg2} is ${product} <br>`)
    callback(product);
}

function checkEvenOdd(product) {
    let result = product % 2 === 0 ? "Even" : "Odd";
    document.write(`Its an ${result} number`);
}

multiply(9,7,checkEvenOdd);