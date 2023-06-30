SELECT Employees.*
from Employees
inner join Orders
on Employees.EmployeeID = Orders.EmployeeID;
