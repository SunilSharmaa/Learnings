function getQueryString() {
    let urlParam = new URLSearchParams(location.search);
    let params = urlParam.get("name");
    
    document.title = params;
    let url = `https://restcountries.com/v3.1/name/${params}?fullText=true`;
    getData(url);
}

async function getData(countryUrl) {
    let response = await fetch(countryUrl);
    let data = await response.json();
    console.log(data[0]);
}

getQueryString();