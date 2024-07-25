while(true) {
    let inputYear = prompt(`Enter your date of birth`);

    let dateOfBirth = parseInt(inputYear);

    if(isNaN(dateOfBirth)) {
        alert(`Invalid input`);
    }
    else if((2024 - dateOfBirth) < 1) {
        alert(`Invalid birth year, Try again`);
    }
    else if((2024 - dateOfBirth) > 0 && (2024 - dateOfBirth) < 18) {
        console.log(`You are not eligible for voting`);
        break;
    }
    else {
        console.log(`Kudoss!! You can vote `);
        break;
    }
}