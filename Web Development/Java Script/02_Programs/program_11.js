let sumEven = 0;
let sumOdd = 0;

let inputNumber = prompt(`Enter any integer number`);

let parsedNumber = parseInt(inputNumber);

if(isNaN(parsedNumber)) {
 alert(`${inputNumber} is not a valid number`);
}
else {
    for(let i = 0; i <= parsedNumber; i++) {
        if(i % 2 == 0) {
            sumEven = sumEven + i;
        }
        else {
            sumOdd = sumOdd + i;
        }
    }
    console.log(`Sum of all the even number = ${sumEven}`);
    console.log(`Sum of all the odd number = ${sumOdd}`);
}