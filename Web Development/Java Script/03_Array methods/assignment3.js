let array = [7,3,1,1,2,5,5,7,3,9,8,3,8,4];

let uniqueArray = [];

for(let i = 0; i < array.length; i++) {
    let isDuplicate = false;

    for(let j = 0; j < uniqueArray.length; j++) {
        if(array[i] === uniqueArray[j]) {
            isDuplicate = true;
            break;
        }
    }

    if(!isDuplicate) {
        uniqueArray.push(array[i]);
    }
}

for(let i of uniqueArray) {
    console.log(i);
}