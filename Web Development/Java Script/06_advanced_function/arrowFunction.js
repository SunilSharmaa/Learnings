//normal function
function add(arg1, arg2) {
    return(arg1 + arg2);
}

document.write(add(13,19));

//arrow function
let multily = (arg1, arg2) => {
    return (arg1 * arg2);
}
document.write(`<br>`);
document.write(multily(5,9));

//another variant for arrow function
let substract = (arg1, arg2) => (arg1 - arg2);

document.write(`<br>`);
document.write(substract(90,60));

//another variant for arrow function
let squar = n => n * n;

document.write(`<br>`);
document.write(squar(8));