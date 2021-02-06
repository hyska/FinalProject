select ProductID, ProductName, CategoryName, UnitPrice
from Products
inner join Categories
on Products.CategoryID = Categories.CategoryID