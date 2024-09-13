let arr = [1,2,3,[4,5,6,[7,8,9,[10,11,12]]]];

console.log(arr);

console.log(arr.flat(1));
console.log(arr.flat(2));
console.log(arr.flat(Infinity));