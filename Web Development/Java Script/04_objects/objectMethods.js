let myCar = new Object();

myCar["start"] = function(){
    console.log(`starting the engine`);
}

myCar.stop = function() {
    console.log(`stoped the car`);
}

myCar.start();
myCar.stop();

myCar.stereo = new Object();
myCar.stereo.name = "Sony";

console.log(myCar.stereo.name);