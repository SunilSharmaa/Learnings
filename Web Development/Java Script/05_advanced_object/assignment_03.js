let account = {
    accountId : 0,
    name : "",
    balance : 0.0,

    setAccount : function(arg1, arg2,arg3) {
        account.accountId = arg1;
        account.name = arg2;
        account.balance = arg3;
    },

    deposite : function(arg1) {
        account.balance += arg1;
    },

    withdraw : function (arg1) {
        if(arg1 > account.balance) {
            console.log(`Withdraw amount is greater then balance`);
        } else {
            account.balance -= arg1;
        }
    },

    toString : function() {
        return (`Account id = ${account.accountId}, Name = ${account.name}, Balance = ${account.balance}`);
    }
}

account.setAccount(134,"Gamma",1500.60);
account.deposite(800);
account.withdraw(467);

document.write(account)
console.log(account);