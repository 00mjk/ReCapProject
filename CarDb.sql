Create Table Cars(
 CarId int NOT NULL PRIMARY KEY IDENTITY (1,1),
 BrandId int NOT NULL , ColorId int NOT NULL,
 DailyPrice decimal , Descriptions nvarchar (50),

 FOREIGN KEY (BrandId) REFERENCES Colors(ColorId),
 FOREIGN KEY (ColorId) REFERENCES Brands(BrandId)
)
Create Table Color(
ColorId int NOT NULL Primary key IDENTITY (1,1),
ColorName nvarchar(20)
)
Create Table Brand (
BrandId int NOT NULL PRIMARY KEY IDENTITY (1,1),
Brand nvarchar(25)
)
INSERT INTO Cars (BrandId, ColorId, DailyPrice, Descriptions)
VALUES 
(1,2,100,'Otomatik Dizel'),
(1,3,400,'Manuel Benzinli'),
(2,2,220,'Otomatik Benzin'),
(3,1,700,'Manuel Dizel')
INSERT INTO Color (ColorId,ColorName)
VALUES
(2, 'Beyaz'), 
(1,'Siyah'),
(3,'Mavi')
INSERT INTO Brand(BrandId,Brand)
VALUES 
(1,'Volvo'),
(2,'BMW'),
(3,'Mercedes')