CREATE PROCEDURE [dbo].[spPopulateProduct]
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO dbo.Product(Id, ProductName, Description,RetailPrice, QuantityInStock) VALUES 
		(1,'Hp 24fw', 'Monitor',99.99,1),
		(2,'Hp Elitedesk G3', 'PC',199.99,1),
		(3,'Dell Precision', 'Laptop',1499.99,1)
END
	