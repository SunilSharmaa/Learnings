let sum = 0;
let average = 0;
let count = 0;
while(true) {
    let inputNumber = prompt(`Enter valid integer number (enter 0 to stop)`);
    let parsedNumber = parseInt(inputNumber);

    if(isNaN(parsedNumber)) {
        alert(`Enter valid integer number`);
    }
    else if (parsedNumber == 0) {
        console.log(`Sum of total numbers you entered is ${sum}`);
        console.log(`Average of total numbers you entered is ${average}`);
        break;
    }
    else {
        count++;
        sum = sum + parsedNumber;
        average = sum / count; 
    }
}