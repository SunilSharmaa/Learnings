let numSet1 = [1,2,3];
let numSet2 = [...numSet1, 3, 5, 6];

function callNumber(first, second, ...other) {
    console.log(first);
    console.log(second);
    console.log(other)
}
console.log(numSet2);
callNumber(7,8,9,10,11,12)