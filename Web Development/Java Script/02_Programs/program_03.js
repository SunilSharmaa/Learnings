let inputNumber = prompt(`enter any number`);

let parsedNumber = parseInt(inputNumber);

if(isNaN(parsedNumber)) {
    alert(`${inputNumber} is not a number`);
}
else {
    let parity = parsedNumber % 2 === 0 ? 'even' : 'odd';
    alert(`${inputNumber} is an ${parity} number`);
}