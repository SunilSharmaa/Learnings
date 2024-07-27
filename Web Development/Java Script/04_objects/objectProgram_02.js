let student = {
    name: "Sumit",
    age: 15,
    phy: 45,
    chem: 50,
    maths: 65
};

let totalMarks = 0;

for(let key in student) {
    if(typeof student[key] === 'number' && key !== 'age') {
        totalMarks += student[key];
    }
}

console.log(`total marks: ${totalMarks}`);