let company = {
    name : "Apple",
    foundationYear : 1976,
    productList : [
        {
            name : "Iphone",
            year : 2007
        },
        {
            name : "Ipad",
            year : 2010
        }
    ],
    foundedBy : ["Steve Jobs", "Steve Wozniak"],
    ceo : "Steve Jobs",

    //methods
    createNewProduct : function(argName, argYear) {
        company.productList.push({name : argName, year : argYear});
    },

    resign : function() {
        let formerCeo = company.ceo;
        company.ceo = null;
        return formerCeo;
    },

    hireCeo : function(argCeo) {
        company.ceo = argCeo;
    },

    toString : function() {
        let productDetails = "";

        for(let key of company.productList) {
            productDetails += `${key.name} - ${key.year}, `; 
        }

        return `<strong>Name: </strong>${company.name} <br>
        <strong>Foundation year: </strong>${company.foundationYear} <br>
        <strong>Founders: </strong>${company.foundedBy} <br>
        <strong>Ceo: </strong>${company.ceo} <br>
        <strong>Product list: </strong>${productDetails} <br><br>`
    }
}

document.write(`<strong>Company Details <br><br></strong>`);
document.write(company);
document.write(`Ceo ${company.ceo} resigned <br><br>`);
company.resign();
document.write(`<strong>After CEO Resignation</strong> <br><br>`);
document.write(company);
document.write(`<strong>After Hiring New CEO <br><br> </strong>`);
company.hireCeo("Tim Cook");
document.write(company);
document.write(`<strong>After Adding New Product <br><br></strong>`);
company.createNewProduct("IMac", 2014);
document.write(company);