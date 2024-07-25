let numbers = new Array(5);

for(let i = 0; i < 5; i++) {
    let inputNumber = prompt(`Enter integer no. ${i+1}`);
    inputNumber = parseInt(inputNumber)
    if(isNaN(inputNumber)) {
        alert(`Enter valid integer number`);
        i--;
    } else {
        numbers[i] = inputNumber;
    }
}

let removeOccurrenceNumber = 0;

while(true) {
    let inputNumber = prompt(`Enter another number to remove its occurrence`);
    removeOccurrenceNumber = parseInt(inputNumber);
    
    if(isNaN(removeOccurrenceNumber)) {
        alert(`Input valid integer number`);
    } else {
        break;
    }
}

for(let i = 0; i < 5; i++) {
    if(numbers[i] === removeOccurrenceNumber) {
        numbers.splice(i,1);
        i--;
    }
}

for(let i of numbers) {
    console.log(i);
}