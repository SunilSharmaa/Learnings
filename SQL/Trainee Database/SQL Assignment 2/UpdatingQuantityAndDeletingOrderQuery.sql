USE TraineeDB;

UPDATE Orders
SET Quantity = 15
WHERE OrderID = 1005;

DELETE FROM Orders
WHERE OrderID = 1008;