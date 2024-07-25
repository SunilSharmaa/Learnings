let names = new Array(5);

for(let i = 0; i < 5; i++) {
    names[i] = prompt(`Enter name ${i+1}.`); 
}

let occurenceName = prompt(`Enter another name to search`);

let occurenceNumber = [];
let index = -1;

do {
    index = names.indexOf(occurenceName, index + 1);

    if(index !== -1) {
        occurenceNumber.push(index);
    }

}while(index !== -1)

if(occurenceNumber.length > 0) {
    console.log(`Occurrences of ${occurenceName}`);
    console.log(`${occurenceNumber.join(",")}`);
}

else {
    console.log('no occurrences found');
}