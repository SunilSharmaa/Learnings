import {destination} from "./popularDestinations.js";

let destinationSection = document.getElementById("destination-section");
console.log(destinationSection);

for (let key of destination) {
    let content = `<div class="mt-4 h-24 bg-white rounded-s-md  rounded-e-md overflow-hidden flex gap-x-5">
                <img class="h-full " src="${key.imageUrl}" alt="${key.imageAlt}">
                <div class="text-black">
                    <h2 class="font-semibold mt-4 text-[15px]">${key.city}</h2>
                    <p class="text-gray-600 text-[12px] font-normal mt-0">$${key.averagePrice} / night average</p>
                    <a class="text-[10px] font-medium mt-3 inline-block text-blue-600" href="#">Explore ${key.propertyCount} properties</a>
                </div>
            </div>`;
    
    let div = document.createElement("div");
    div.innerHTML = content;

    destinationSection.appendChild(div);
}

