let userInput = prompt(`Enter any number`);
let parsedNumber = parseInt(userInput);

if (isNaN(parsedNumber)) {
    alert(`Invalid input`);
} else {
    switch(parsedNumber) {
        case 1:
        case 2:
        case 11:
        case 12:
            alert(`Winter`);
            break;
        case 3:
        case 4:
        case 5:
        case 6:
            alert(`Summer`);
            break;
        case 7:
        case 8:
        case 9:
        case 10:
            alert(`Rainy`);
            break;
        default:
            alert(`Wrong Month Number`);
    }
}
