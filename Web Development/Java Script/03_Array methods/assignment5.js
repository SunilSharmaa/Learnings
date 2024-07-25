let array = [1,3,6,2,5,10];
let firstPartSum = 0;
let secondPartSum = 0;

for(let i = 0; i < array.length; i++) {
    if(i % 2 === 0) {
        firstPartSum += array[i];
    }
    else {
        secondPartSum += array[i];
    }
}

let finalArray = [firstPartSum,secondPartSum];

console.log(finalArray.join(','));