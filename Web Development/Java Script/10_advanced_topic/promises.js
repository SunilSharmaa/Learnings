// promise one
let promiseOne = new Promise((resolve, reject)=> {
    setTimeout(()=>{
        console.log("promise-1");
        resolve();
    },1000)
})

promiseOne.then(()=>{
    console.log("promise-1-resolved");
});

// promise two
new Promise((resolve, reject)=>{
    setTimeout(()=>{
        console.log("\npromise-2");
        resolve();
    },1000)
}).then(()=>{
    console.log("promise-2-resolved");
});

// promise three
let promiseThree = new Promise((resolve, reject)=>{
    setTimeout(()=>{
        console.log("\npromise-3");
        resolve({"username" : "sunil", "password" : 123});
    },1000)
})

promiseThree.then((user)=>{
    console.log(user);
    console.log("promise-3-resolved");
})

// promise four
let promiseFour = new Promise((resolve, reject)=>{
    setTimeout(()=>{
        console.log("\npromise-4");
        let obj = {
            username: "user-1",
            password: 123
        };

        let error = false;
        
        if(!error) {
            resolve(obj);
        } else {
            let errorText = "error! something went wrong";
            reject(errorText);
        }
    },1000)
})

promiseFour.then((user)=>{
    console.log("promise-4-resolved");
    console.log(user);
})
.catch((message)=>{
    console.log(message);
})
.finally(() => "Response received");