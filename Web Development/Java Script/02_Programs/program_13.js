let inputNumber = prompt(`Enter any integer number`);

let parsedNumber = parseInt(inputNumber);
let primeArray = [];

if (isNaN(parsedNumber)) {
  alert(`${inputNumber} is not a valid input`);
} 
else {
  for (let i = 2; i <= parsedNumber; i++) {
    let isPrime = true; // Flag to track primality
    for (let j = 2; j <= Math.sqrt(i); j++) { // Iterate only up to the square root
      if (i % j === 0) {
        isPrime = false; // Not prime if divisible by a number other than 1 and itself
        break; // Exit the inner loop if a divisor is found
      }
    }
    if (isPrime) {
      primeArray.push(i); // Add prime number to the array
    }
  }
}

console.log(`Total prime Numbers are:`);
for (let i of primeArray) {
  console.log(i);
}
