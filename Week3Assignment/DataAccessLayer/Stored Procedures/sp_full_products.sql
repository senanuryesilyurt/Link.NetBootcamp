USE Week3Assignment2
GO

CREATE PROC ProductDtos
AS
BEGIN

SELECT Categories.Name AS 'CategoryName' , Products.Name AS 'ProductName', ProductFeatures.Name AS 'FeatureName',Products.Price
FROM Products 
JOIN Categories ON Categories.Id=Products.CategoryId
JOIN ProductFeatures ON ProductFeatures.Id=Products.Id

END