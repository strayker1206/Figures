USE ProductsDB

CREATE TABLE Products
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL
)

CREATE TABLE Categories
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(30) NOT NULL
)

CREATE TABLE ProductCategory
(
    Id INT IDENTITY PRIMARY KEY,
    ProductId INT NOT NULL,
	CategoryId INT NOT NULL
)

INSERT INTO Products
VALUES ('Core 2 Duo'), ('i5-3210'), ('Ryzen'), ('GeForce GT1080')

INSERT INTO Categories 
VALUES ('Processor'), ('Intel'), ('AMD')

INSERT INTO ProductCategory
VALUES (1,1), (1,2), (2,1), (2,2), (3,1), (3,3)