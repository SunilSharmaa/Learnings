let names = new Array(5);

// Prompt the user to enter 5 names and store them in the array
for (let i = 0; i < 5; i++) {
    names[i] = prompt(`Enter name ${i + 1}: `);
}

let occurrencesName = prompt(`Enter the name to find occurrences: `);

let occurrencesNumber = [];
let index = -1;

// Repeat the search until the name is not found
do {
    // Find the next occurrence of the name starting from the next index
    console.log(`debug = ${index}`);
    index = names.indexOf(occurrencesName, index + 1);
    console.log(`debug = ${index}`);
    
    // If the name is found, add its index to the occurrencesNumber array
    if (index !== -1) {
        occurrencesNumber.push(index);
    }
    console.log(`debug = ${index}`);
} while (index !== -1);

// Check if any occurrences were found
if (occurrencesNumber.length > 0) {
    console.log(`Occurrences of ${occurrencesName}: ${occurrencesNumber.join(", ")}`);
} else {
    console.log(`Name not found`);
}
