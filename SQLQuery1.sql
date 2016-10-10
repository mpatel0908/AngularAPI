CREATE TABLE [dbo]. [Images] 
(
	[Id] int IDENTITY (1,1) not null, 
	[full] NVARCHAR (1000) null, 
	[thumb] NVARCHAR (1000) null, 
	[ProductId] INT not null,
	CONSTRAINT pk_Image PRIMARY KEY(Id),
	CONSTRAINT fk_ImageProduct	FOREIGN KEY (ProductID)	REFERENCES Product(Id)	ON DELETE CASCADE 
);

CREATE TABLE [dbo]. [Review] 
(
	[Id] int IDENTITY (1,1) not null, 
	[stars] int		not null, 
	[author]	NVARCHAR (500)	not null,
	[body]	NTEXT	not null,
	[ProductId]	int not null,
);

CREATE TABLE [dbo]. [Product]
(
	[Id]	int IDENTITY (1,1) not null,
	[Name]	NVARCHAR (1000) not null,
	[Price]	MONEY null,
	[soldOut] BIT null,
	[canPurchase]	BIT null,
	[description] NTEXT null,
);


INSERT INTO Product(name, price, soldOut,	canPurchase, description)
VALUES
('Dodecahedron', 12.95, 0, 1, 'Some gems have hidden qualities beyond their lustre, beyond their shine...Dodecahedron is one of those gems'),
('Pentagonal', 5.95, 0, 1 , 'The pentagonal gem is the newest addition to our store. We think you will love it'),
('Azurite', 110.50, 0 , 1, 'Azurite is a fantastic new gem!'),
('Bloodstone', 22.90, 0, 1, 'Origin of the Bloodstone is unknown, hence its low value. It has a very high shine and 12 sides, however.'),
('Zircon', 1110, 0, 1, 'Zircon is our most coverted and sought after gem. You will pay much to be the proud owner of this gorgeous and high shine gem.');


INSERT INTO Review(ProductId, body, stars, author)	
VALUES
((SELECT ID FROM Product WHERE name =     'Dodecahedron' ), 'This is a great product', 5, 'joseph@codingtemple.com'),
((SELECT ID FROM Product WHERE name =	'Pentagonal'), 


INSERT INTO Image(ProductId, [full], thumb)
VALUES
((SELECT ID FROM Product WHERE name = 'Dodecahedron'), 'dodecahedron-01-full.jpg', 'dodecahedron-01-thumb.jpg'),
((SELECT ID FROM Product WHERE name = 'Pentagonal'), 'pentagonal-01-full.jpg', 'pentagonal-01-thumb.jpg'),
((SELECT ID FROM Product WHERE name = 'Azurite'), null, 'gem-02.gif'),
((SELECT ID FROM Product WHERE name = 'Bloodstone'), null, 'gem-05.gif'),
((SELECT ID FROM Product WHERE name = 'Zircon'), null, 'gem-06.gif')

