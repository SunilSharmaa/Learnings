let billAmount = [];
let totalBillAmount = 0;

for(let i = 0; i < 4; i++) {
    let inputAmount = prompt(`Enter amount of bill no. ${i+1}`);
    let parsedNumber = parseFloat(inputAmount);

    if(isNaN(parsedNumber)) {
        alert(`Enter valid bill amount`);
        i--;
    }
    else {
        billAmount[i] = parsedNumber;
        totalBillAmount += billAmount[i]; 
    }
}

if(totalBillAmount < 250) {
    let tipAmount = (totalBillAmount * 20) / 100;
    console.log(`Bill amount - ${totalBillAmount} \n
Tip amount 20% - ${tipAmount} \n
Total amount = ${totalBillAmount + tipAmount}`);
}
else if (totalBillAmount <= 500 && totalBillAmount >= 250) {
    let tipAmount = (totalBillAmount * 15) / 100;
    console.log(`Bill amount - ${totalBillAmount} \n
Tip amount 20% - ${tipAmount} \n
Total amount = ${totalBillAmount + tipAmount}`);
}
else {
    let tipAmount = (totalBillAmount * 10) / 100;
    console.log(`Bill amount - ${totalBillAmount} \n
Tip amount 20% - ${tipAmount} \n
Total amount = ${totalBillAmount + tipAmount}`);
}