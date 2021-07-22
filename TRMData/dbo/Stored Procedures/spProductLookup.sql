CREATE PROCEDURE [dbo].[spProductLookup]
AS
BEGIN
	SET NOCOUNT ON

	SELECT Product.Id,ProductName,[Description],RetailPrice,QuantityInStock
	FROM dbo.Product
	ORDER BY ProductName
END
