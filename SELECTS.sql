-- SELECT
SELECT * FROM Customers

SELECT ContactName Adi, CompanyName SirketAdi, City Sehir FROM Customers

SELECT ContactName, CompanyName, City FROM Customers

SELECT * FROM Customers WHERE City = 'Berlin'

SELECT * FROM Products WHERE CategoryID = 1 OR CategoryID = 3

SELECT * FROM Products WHERE CategoryID = 1 AND UnitPrice >= 10

SELECT * FROM Products ORDER BY ProductName

SELECT * FROM Products ORDER BY CategoryId, ProductName

SELECT * FROM Products ORDER BY UnitPrice DESC

SELECT COUNT(*) [Unit Count] FROM Products

SELECT CategoryID, COUNT(*) Amount FROM Products GROUP BY CategoryID

SELECT CategoryID, COUNT(*) Amount FROM Products GROUP BY CategoryID HAVING COUNT(*) < 10

SELECT CategoryID, COUNT(*) Amount FROM Products WHERE UnitPrice > 20 GROUP BY CategoryID HAVING COUNT(*) < 10

SELECT * FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID

SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID

SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID WHERE Products.UnitPrice > 10

-- DTO (Data Transformation Object)

-- yazım sırasına göre solda olup sağda olmayanları da getir.
SELECT * FROM Products p LEFT JOIN [Order Details] od
ON p.ProductID = od.ProductID

-- hiç sipariş vermeyenler
SELECT * FROM Customers c LEFT JOIN Orders o
ON c.CustomerID = o.CustomerID
WHERE o.CustomerID IS NULL