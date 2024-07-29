let employees = [
    {name: "Neeraj", salary: 90000, hireDate: "July 1, 2010"},
    {name: "Deepak", salary: 75000, hireDate: "August 15, 2009"},
    {name: "Anshul", salary: 80000, hireDate: "December 12, 2011"},
    {name: "Rahul", salary: 85000, hireDate: "January 5, 2013"},
    {name: "Amit", salary: 72000, hireDate: "March 20, 2012"},
    {name: "Priya", salary: 95000, hireDate: "September 8, 2014"},
    {name: "Suresh", salary: 88000, hireDate: "April 25, 2015"},
    {name: "Neha", salary: 82000, hireDate: "June 30, 2016"},
    {name: "Kavita", salary: 73000, hireDate: "November 3, 2017"},
    {name: "Rajesh", salary: 89000, hireDate: "February 14, 2018"},
    {name: "Preeti", salary: 84000, hireDate: "October 10, 2019"},
    {name: "Sanjay", salary: 76000, hireDate: "May 12, 2020"},
    {name: "Meena", salary: 91000, hireDate: "August 22, 2021"},
    {name: "Vikram", salary: 78000, hireDate: "December 7, 2022"},
    {name: "Shalini", salary: 93000, hireDate: "March 17, 2023"}
]

for(let i = 0; i < employees.length - 1; i++) {
    for(let j = 0; j < employees.length - 1 - i; j++) {
        if(employees[j].salary < employees[j + 1].salary) {
            let temp = employees[j];
            employees[j] = employees[j + 1];
            employees[j + 1] = temp;
        }
    }
}

console.log(employees);