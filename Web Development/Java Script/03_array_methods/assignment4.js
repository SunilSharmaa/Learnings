let wrongArray = [NaN, 0, 15, false, -22,'',undefined, 47, null,94];
let correctArray = [];

for(let i = 0; i < wrongArray.length; i++) {
    if(!isNaN(wrongArray[i]) && wrongArray[i] !== false && wrongArray[i] !== undefined && wrongArray[i] !== null && wrongArray[i] !== '' && wrongArray[i] !== 0) {
        correctArray.push(wrongArray[i]);
    }
}

console.log(correctArray.join(','));

