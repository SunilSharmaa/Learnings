async function getData() {
    let response = await fetch("https://restcountries.com/v3.1/all#");
    let data = await response.json();
    console.log(data);

    let countriesCard = document.querySelector(".countries-card");
    data.forEach((value)=> {

        let card = document.createElement("a");
        card.href = `/country.html?name=${value.name.common}`
        card.classList.add("flex")
        card.classList.add("card");
        let cardContent = `
                <img src="${value.flags.svg}" alt="South georgia">

                <div class="card-content">
                    <span class="countries-name">${value.name.common}</span>
                    <div class="population">
                        <p><b>Population:&nbsp;&nbsp;</b><span class="value">${value.population}</span></p>
                    </div>
                    <div class="region">
                        <p><b>Region:&nbsp;&nbsp;</b><span class="value">${value.region}</span></p>
                    </div>
                    <div class="capital">
                        <p><b>Capital:&nbsp;&nbsp;</b><span class="value">${value.capital}</span></p>
                    </div>
                </div>`;
        card.innerHTML = cardContent;
        countriesCard.appendChild(card);
    })
}


getData();