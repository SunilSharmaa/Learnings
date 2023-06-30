-- Retrieve the details of orders along with the corresponding employee and product information.

SELECT Orders.OrderID, Orders.OrderDate, Employees.FirstName, Employees.LastName, Products.ProductName, Orders.Quantity, Orders.TotalPrice
FROM Orders
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
JOIN Products ON Orders.OrderID = Products.ProductID;

-- Retrieve the total price of orders placed by each employee.

SELECT Employees.FirstName, Employees.LastName, SUM(Orders.TotalPrice) AS TotalOrderPrice
FROM Orders
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
GROUP BY Employees.FirstName, Employees.LastName;

--Retrieve the product names along with the total quantity of each product ordered.

SELECT Products.ProductName, SUM(Orders.Quantity) AS TotalQuantity
FROM Products
INNER JOIN Orders ON Products.ProductID = Orders.OrderID
GROUP BY Products.ProductName;

--Retrieve the product(s) with the highest price in each category.

SELECT CategoryID, MAX(Price) AS HighestPrice
FROM Products
GROUP BY CategoryID;

