let student1 = {
    name : "Gamma",
    gender : "Male"
};

let student2 = {
    name : "Gamma",
    gender : "Male"
};

console.log(student1 === student2);
document.write(student1 === student2);

console.log((JSON.stringify(student1) === JSON.stringify(student2)));
