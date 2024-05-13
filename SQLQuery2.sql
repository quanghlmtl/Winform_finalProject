use master
go
create database QLKho
go
use QLKho
go
-- Tạo bảng Categories
CREATE TABLE Categories (
    CategoryID int IDENTITY(1,1) PRIMARY KEY,
    CategoryName nvarchar(255) NOT NULL,
    Description nvarchar(255)
);

-- Tạo bảng Suppliers
CREATE TABLE Suppliers (
    SupplierID int IDENTITY(1,1) PRIMARY KEY,
    SupplierName nvarchar(255) NOT NULL,
    ContactName nvarchar(255),
    Address nvarchar(255),
    Phone nvarchar(50)
);

-- Tạo bảng Products
CREATE TABLE Products (
    ProductID int IDENTITY(1,1) PRIMARY KEY,
    ProductName nvarchar(255) NOT NULL,
    CategoryID int,
    QuantityPerUnit nvarchar(255),
    UnitPrice decimal,
    UnitsInStock int,
    UnitsOnOrder int,
    ReorderLevel int,
    Discontinued bit,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Tạo bảng Customers
CREATE TABLE Customers (
    CustomerID int IDENTITY(1,1) PRIMARY KEY,
    CustomerName nvarchar(255) NOT NULL,
    ContactName nvarchar(255),
    Address nvarchar(255),
    Phone nvarchar(50)
);

-- Tạo bảng PurchaseOrders
CREATE TABLE PurchaseOrders (
    PurchaseOrderID int IDENTITY(1,1) PRIMARY KEY,
    SupplierID int,
    OrderDate datetime,
    TotalAmount decimal,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

-- Tạo bảng PurchaseOrderDetails
CREATE TABLE PurchaseOrderDetails (
    PurchaseOrderDetailID int IDENTITY(1,1) PRIMARY KEY,
    PurchaseOrderID int,
    ProductID int,
    Quantity int,
    UnitPrice decimal,
    FOREIGN KEY (PurchaseOrderID) REFERENCES PurchaseOrders(PurchaseOrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Tạo bảng SalesOrders
CREATE TABLE SalesOrders (
    SalesOrderID int IDENTITY(1,1) PRIMARY KEY,
    CustomerID int,
    OrderDate datetime,
    TotalAmount decimal,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Tạo bảng SalesOrderDetails
CREATE TABLE SalesOrderDetails (
    SalesOrderDetailID int IDENTITY(1,1) PRIMARY KEY,
    SalesOrderID int,
    ProductID int,
    Quantity int,
    UnitPrice decimal,
    FOREIGN KEY (SalesOrderID) REFERENCES SalesOrders(SalesOrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
-- Tạo bảng 'login'
CREATE TABLE login (
    username NVARCHAR(50) PRIMARY KEY,
    password NVARCHAR(50) NOT NULL,
    status bit NOT NULL
);

-- Tạo bảng 'employee_info'
CREATE TABLE employee_info (
    employee_id INT PRIMARY KEY IDENTITY(321001,1),
    full_name NVARCHAR(100) NOT NULL,
    date_of_birth DATE NOT NULL,
    gender bit,
    address NVARCHAR(200),
    phone_number NVARCHAR(15),
    email NVARCHAR(100),
    username NVARCHAR(50),
    CONSTRAINT fk_username FOREIGN KEY (username) REFERENCES login(username)
);
