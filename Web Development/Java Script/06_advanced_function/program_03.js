function takeInput(callback) {
    let input1 = parseInt(prompt(`Enter 1st int number`));
    let input2 = parseInt(prompt(`Enter 2nd int number`));
    
    callback(input1, input2);
}

function productNumber(arg1, arg2) {
    document.write(`Product of these two number is = ${arg1 + arg2}`);
}

takeInput(productNumber);