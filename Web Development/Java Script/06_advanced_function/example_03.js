function multiply(arg1,arg2,callback) {
    let product = arg1 * arg2;
    console.log(`Product of ${arg1} and ${arg2} is ${product}`);
    callback(product);
}

multiply(5,5,(product) => {
    if(product % 2 === 0) {
        console.log(`and its an Even number`);
    } else {
        console.log(`and its an Odd number`);
    }
})