USE TraineeDB

CREATE TABLE Orders (
OrderID INT NOT NULL UNIQUE,
OrderDate DATE NOT NULL,
EmployeeID INT NOT NULL,
ProductName VARCHAR(50) NOT NULL,
Quantity INT NOT NULL CHECK (Quantity > 0 AND Quantity < 25),
TotalPrice INT NOT NULL
);