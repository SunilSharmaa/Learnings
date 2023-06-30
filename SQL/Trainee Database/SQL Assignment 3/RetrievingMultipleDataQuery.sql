USE TraineeDB;

-- order placed by customer from mumbai city

select  c.CustomerName, o.OrderID, o.OrderDate, o.ProductName, o.Quantity, o.TotalPrice, c.City
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
inner join Customers c on o.EmployeeID = c.CustomerID
where City = 'Mumbai';

-- customer names along with the total number of orders placed by each customer.

SELECT c.CustomerName, COUNT(o.OrderID) AS TotalOrders
FROM Customers c
JOIN Employees e ON c.CustomerID = e.EmployeeID
JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY c.CustomerName;

-- employee names along with the total quantity and total price of orders placed by each employee.

SELECT Employees.FirstName, Employees.LastName, SUM(Orders.Quantity) AS TotalQuantity, SUM(Orders.TotalPrice) AS TotalPrice
FROM Orders
INNER JOIN Employees
ON Orders.EmployeeID = Employees.EmployeeID
GROUP BY Employees.FirstName, Employees.LastName;

-- employee(s) who have placed the highest number of orders.

SELECT TOP 1 WITH TIES Employees.FirstName, Employees.LastName, COUNT(Orders.OrderID) AS TotalOrders
FROM Orders
INNER JOIN Employees
ON Orders.EmployeeID = Employees.EmployeeID
GROUP BY Employees.FirstName, Employees.LastName
ORDER BY TotalOrders DESC;


