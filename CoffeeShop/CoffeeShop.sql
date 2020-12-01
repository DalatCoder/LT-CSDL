﻿CREATE DATABASE CoffeeShop
GO

USE CoffeeShop
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL,
	Type INT NOT NULL DEFAULT 0	-- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES Bill(id),
	FOREIGN KEY (idFood) REFERENCES Food(id)
)
GO

INSERT INTO dbo.Account (UserName, DisplayName, PassWord, Type)
VALUES 
	(N'TRONGHIEU', N'TRONG HIEU', N'123', 1),
	(N'THIHA', N'THI HA', N'123', 1),
	(N'STAFF', N'STAFF', N'123', 0)
SELECT * FROM dbo.Account
GO

CREATE PROC USP_GetAccountByUserName
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username
END
GO

EXEC USP_GetAccountByUserName @userName = N'TRONGHIEU'
GO

CREATE PROC USP_Login
@userName NVARCHAR(100),
@password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @password
END
GO

EXEC USP_Login @userName = N'TRONGHIEU', @password = N'123'

DECLARE @i INT = 1
WHILE @i <= 17
BEGIN
	INSERT TableFood(name) VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END
GO

SELECT * FROM TableFood
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM TableFood
GO

UPDATE TableFood SET status = N'Có người' WHERE id = 3

EXEC USP_GetTableList
GO

INSERT FoodCategory(name) 
VALUES
	(N'Hải sản'),
	(N'Đồ nướng'),
	(N'Nước ngọt')

INSERT Food(name, idCategory, price)
VALUES
	(N'Ốc nhồi thịt', 1, 30000),
	(N'Nghêu hấp xả', 1, 20000),
	(N'Mực một nắng nướng sa tế', 2, 120000),
	(N'Heo rừng nướng muối ớt', 2, 50000),
	(N'Coca', 3, 10000),
	(N'Pepsi', 3, 10000),
	(N'7Up', 3, 10000)

INSERT Bill(DateCheckIn, DateCheckOut, idTable, status)
VALUES 
	(GETDATE(), NULL, 1, 0),
	(GETDATE(), NULL, 2, 0),
	(GETDATE(), GETDATE(), 2, 1)	

INSERT BillInfo(idBill, idFood, count)
VALUES 
	(1, 1, 2),
	(1, 3, 4),
	(1, 5, 1),
	(2, 1, 2),
	(2, 6, 3),
	(3, 1, 2),
	(3, 5, 1)

SELECT * FROM Bill
SELECT * FROM BillInfo
SELECT * FROM Food
SELECT * FROM FoodCategory
GO

CREATE PROC USP_GetUncheckBillsByTableID
@tableID INT
AS
BEGIN
	SELECT * FROM Bill WHERE idTable = @tableID AND status = 0
END
GO

EXEC USP_GetUncheckBillsByTableID 1
GO

CREATE PROC USP_GetBillInfosByBillID
@billID INT
AS
BEGIN
	SELECT * FROM BillInfo WHERE idBill = @billID
END
GO

EXEC USP_GetBillInfosByBillID 2
GO

CREATE PROC USP_GetMenuByBillID
@billID INT
AS
BEGIN
	SELECT Food.name, Food.price, BillInfo.count FROM BillInfo
	JOIN Bill ON BillInfo.idBill = Bill.id
	JOIN Food ON BillInfo.idFood = Food.id
	WHERE BillInfo.idBill = @billID
END
GO

EXEC USP_GetMenuByBillID 2
GO

CREATE PROC USP_GetAllCategory
AS SELECT * FROM FoodCategory
GO

EXEC USP_GetAllCategory
GO

CREATE PROC USP_GetFoodByCategoryID
@catID INT
AS
BEGIN
	SELECT * FROM Food WHERE Food.idCategory = @catID
END
GO

EXEC USP_GetFoodByCategoryID 3
GO

ALTER PROC USP_InsertBill
@idTable INT
AS
BEGIN
	IF (NOT EXISTS(SELECT * FROM Bill WHERE idTable = @idTable AND status = 0))
	BEGIN
		INSERT Bill(DateCheckIn, DateCheckOut, idTable, status, discount)
		VALUES (GETDATE(), NULL, @idTable, 0, 0)
	END
END
GO

EXEC USP_InsertBill 1
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExistsBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExistsBillInfo = id, @foodCount = count FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExistsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE BillInfo
			SET count = @newCount
			WHERE idBill = @idBill AND idFood = @idFood
		ELSE
			DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT BillInfo(idBill, idFood, count)
		VALUES (@idBill, @idFood, @count)
	END
END
GO

EXEC USP_InsertBillInfo 1, 1, 1
GO

ALTER PROC USP_CheckoutBill
@billID INT, @discount INT
AS
BEGIN
	UPDATE Bill
	SET status = 1, discount = @discount
	WHERE id = @billID
END
GO

EXEC USP_CheckoutBill 1
GO

-- Khi thêm mới hoặc cập nhật billInfo thì thay đổi trạng thái của bàn
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill AND status = 0

	UPDATE TableFood SET status = N'Có người' WHERE id = @idTable
END
GO	

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM Bill WHERE idTable = @idTable AND status = 0

	IF (@count = 0)
		UPDATE TableFood SET status = N'Trống' WHERE id = @idTable
END
GO 

ALTER TABLE Bill
ADD discount INT DEFAULT 0

UPDATE Bill SET discount = 0

SELECT * FROM Bill