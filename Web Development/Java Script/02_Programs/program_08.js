let inputNumber = prompt(`enter any integer number`);

let parsedNumber = parseInt(inputNumber);

if(isNaN(parsedNumber)) {
    alert(`not a number`);
}
else {
    for(let i = 1; i<=10; i++) {
        console.log(`${parsedNumber} * ${i} = ${parsedNumber * i}`);
    }

}