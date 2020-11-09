CREATE DATABASE RestaunrantManagement
GO

USE RestaunrantManagement
GO

CREATE TABLE [Table]
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(1000) NULL,
	Status INT,
	Capacity INT NULL
)
GO
SELECT * FROM [Table]

CREATE TABLE Category
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(1000) DEFAULT N'Chưa đặt tên',
	Type INT
)
GO
SELECT * FROM Category

CREATE TABLE Food 
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(1000) DEFAULT N'Chưa đặt tên',
	Unit NVARCHAR(100),
	FoodCategoryID INT REFERENCES Category(ID),
	Price INT DEFAULT 0,
	Notes NVARCHAR(3000) NULL
)
GO
SELECT * FROM Food

CREATE TABLE Account
(
	AccountName NVARCHAR(100) PRIMARY KEY,
	Password NVARCHAR(200),
	FullName NVARCHAR(1000),
	Email NVARCHAR(1000) NULL,
	Tell NVARCHAR(200),
	DateCreated SMALLDATETIME DEFAULT GETDATE()
)
GO
SELECT * FROM Account

CREATE TABLE Role 
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Rolename NVARCHAR(1000),
	Path NVARCHAR(3000) NULL,
	Notes NVARCHAR(3000) NULL
)
GO
SELECT * FROM Role

CREATE TABLE RoleAccount
(
	AccountName NVARCHAR(100) REFERENCES Account(AccountName),
	RoleID INT REFERENCES Role(ID),
	Actived bit,
	Notes NVARCHAR(3000) NULL,
	PRIMARY KEY (AccountName, RoleID)
)
GO
SELECT * FROM RoleAccount

CREATE TABLE Bills
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(1000) DEFAULT N'Hóa đơn thanh toán',
	TableID INT REFERENCES [Table](ID),
	Amount INT DEFAULT 0,
	Discount FLOAT NULL DEFAULT 0,
	Tax FLOAT NULL DEFAULT 0,
	Status BIT DEFAULT 0,
	Account NVARCHAR(100) REFERENCES Account(AccountName),
	CheckoutDate SMALLDATETIME DEFAULT GETDATE()
)
GO
SELECT * FROM Bills

CREATE TABLE BillDetails
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	BillID INT REFERENCES Bills(ID),
	FoodID INT REFERENCES Food(ID),
	Quantity INT DEFAULT 0
)
GO
SELECT * FROM BillDetails

-- INSERT --
INSERT INTO Category(Name, Type)
	VALUES 
		(N'Khai vị', 1),
		(N'Hải sản', 1),
		(N'Gà', 1),
		(N'Cơm', 1),
		(N'Thịt', 1),
		(N'Rau', 1),
		(N'Canh', 1),
		(N'Lẩu', 1),
		(N'Bia', 0),
		(N'Nước ngọt', 0),
		(N'Cà phê', 0),
		(N'Trà đá', 0);
SELECT * FROM Category

INSERT INTO Food (Name, Unit, FoodCategoryID, Price, Notes)
	VALUES
		(N'Rau muống xào tỏi', N'Đĩa', 6, 20000, NULL),
		(N'Cơm chiên Dương Châu', N'Đĩa nhỏ', 4, 40000, N'3 người ăn'),
		(N'Cơm chiên Dương Châu', N'Đĩa lớn', 4, 45000, N'5 người ăn'),
		(N'Ếch thui rơm', N'Đĩa', 2, 75000, NULL),
		(N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, NULL),
		(N'Càng cua hấp', N'Đĩa', 2, 100000, NULL),
		(N'Canh cải', N'Tô', 7, 20000, NULL),
		(N'Gà nướng muối ớt', N'Con', 3, 180000, NULL),
		(N'Bia 333', N'Chai', 9, 12000, NULL),
		(N'Bia Heniken', N'Chai', 9, 20000, NULL),
		(N'Súp cua', N'Tô', 1, 15000, NULL),
		(N'Thịt kho', N'Đĩa', 5, 25000, N'Theo thời giá');
SELECT * FROM Food;

INSERT INTO [Table] (Name, Status, Capacity)
	VALUES
		('01', 0, 4),
		('02', 0, 4),
		('03', 0, 4),
		('04', 2, 6),
		('05', 0, 8);
SELECT * FROM [Table];

INSERT INTO Account (AccountName, Password, FullName, Email, Tell, DateCreated)
	VALUES
		('lgcong', 'legiacong', N'Lê Gia Công', 'conglg@dlu.edu.vn', NULL, NULL),		
		('tdquy', 'thaiduyquy', N'Thái Duy Quý', 'quytd@dlu.edu.vn', NULL, NULL),
		('ttplinh', 'tranthiphuonglinh', N'Trần Thị Phương Linh', 'linihttp@dlu.edu.vn', NULL, NULL);
INSERT INTO Account (AccountName, Password, FullName, Email, Tell)
	VALUES ('pttnga', 'phanthithanhnga', N'Phan Thị Thanh Nga', 'ngaptt@dlu.edu.vn', NULL);
SELECT * FROM Account;

INSERT INTO Role (Rolename, Path, Notes)
	VALUES
		(N'Administator', NULL, NULL),
		(N'Kế toán', NULL, NULL),
		(N'Nhân viên thanh toán', NULL, NULL),
		(N'Nhân viên phục vụ', NULL, NULL);
SELECT * FROM Role;

INSERT INTO RoleAccount (RoleID, AccountName, Actived, Notes)
	VALUES
		(1, 'lgcong', 1, NULL),
		(1, 'pttnga', 1, NULL),
		(1, 'tdquy', 1, NULL),
		(1, 'ttplinh', 1, NULL),
		(3, 'lgcong', 0, NULL),
		(3, 'pttnga', 0, NULL),
		(3, 'tdquy', 1, NULL),
		(3, 'ttplinh', 1, NULL);
SELECT * FROM RoleAccount;

INSERT INTO Bills (TableID, Amount, Discount, Tax, Status, CheckoutDate, Account)
	VALUES
		(4, 150000, 0.05, 0, 0, NULL, 'tdquy'),
		(3, 200000, NULL, NULL, 1, NULL, 'pttnga');
SELECT * FROM Bills;

INSERT INTO BillDetails (BillID, FoodID, Quantity)
	VALUES
		(1, 3, 2),
		(1, 4, 1),
		(1, 5, 3),
		(1, 6, 2),
		(2, 7, 2),
		(2, 5, 5);
SELECT * FROM BillDetails;
