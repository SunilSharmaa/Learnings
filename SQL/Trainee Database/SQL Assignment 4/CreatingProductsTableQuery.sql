USE TraineeDB;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Price INT NOT NULL,
    CategoryID INT NOT NULL
);
