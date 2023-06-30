USE TraineeDB;

SELECT SUM (Quantity) AS TotalQuantity, SUM (TotalPrice) AS TotalPrice
FROM Orders;
