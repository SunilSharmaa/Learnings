let inputNumber = prompt(`enter any number`);

let parsedNumber = parseInt(inputNumber);

if(isNaN(parsedNumber)) {
    alert(`${inputNumber} is not a number`);
}
else {
    if(parsedNumber < 0) {
        let absNumber = -(parsedNumber);
        alert(`${absNumber}`)
    }

    else {
        alert(`${parsedNumber}`)
    }
}