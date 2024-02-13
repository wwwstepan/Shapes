SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM CategoriesOfProducts
LEFT JOIN Products ON CategoriesOfProducts.ProductId = Products.Id
LEFT JOIN Categories ON CategoriesOfProducts.CategoryId = Categories.Id

