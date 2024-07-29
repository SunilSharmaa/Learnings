let array = [8,4,1,19,4,2,1,3];

for(let i = 0; i < array.length; i++) {
    for(let j = 0; j < array.length-i-1; j++) {
        if(array[j] > array[j+1]) {
            let temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
for(let key of array) {
    console.log(key);
}