// let count = 0;
// setTimeout(function() {
//     console.log(`hello`);
// },3000)

// let intervalId = setInterval(function() {
//     console.log(`Hii`);
//     count++;
//     if(count > 3) {
//         clearInterval(intervalId);
//     }
// },2000)

let count = 0;

function setIntervalCallback() {
    console.log(`Count = ${count + 1}`);
    count++;

    if(count === 5) {
        clearInterval(intervalId);
    }
}

let intervalId = setInterval(setIntervalCallback, 1000);

let count2 = 0;
let intervalId2 = setInterval(function() {
    console.log(`Count 2 = ${count2 + 1}`);
    count2++;

    if(count2 === 5) {
        clearInterval(intervalId2);
    }
},1000)