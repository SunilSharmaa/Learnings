let inputNumber = prompt(`Enter an integer number`);

let parsedNumber = parseInt(inputNumber);

if(isNaN(parsedNumber)) {
    alert(`${inputNumber} is not a valid number`);
}
else {
    if(parsedNumber < 0) {
        alert(`Negative number`);
    }
    else if (parsedNumber < 10) {
        alert(`1 digit positive integer`);
    }
    else if (parsedNumber < 100) {
        alert(`2 digit positive integer number`);
    }
    else {
        alert(`3 or more digit positive integer`);
    }
}