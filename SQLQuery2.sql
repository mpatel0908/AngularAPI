CREATE PROCEDURE sp_GetProducts AS

SELECT 
	id,
	canPurchase, 
	soldOut, 
	name,
	price, 
	[description]
FROM 
	Product


CREATE PROCEDURE sp_GetImagesForProduct
(
	@productId	int
)
AS

SELECT
	[full],
	thumb,
	id
FROM
	[Image]
WHERE
	ProductID = @productId



CREATE PROCEDURE sp_AddReview
(
	@productId int
	@stars int,
	@author NVARCHAR (500),
	@body ntext
)
AS
INSERT INTO Review(
	ProductId,
	stars,
	author,
	body
	)
VALUES(
	@productId,
	@stars,
	@author,
	@body
	)