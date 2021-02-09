--Select
--ANSII Yazış Standardı
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'

--case insensitive büyük/küçük harfe duyarsız sistem
select * from Products where categoryId=1 or CategoryID=3

select*from Products where CategoryID=1 and UnitPrice>=10

select*from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products

select CategoryID,count(*) from products group by CategoryID

select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10 --having kümülatiflere uygulanır, önce where çalışır sonra group by

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories --inner join birleştirme bir araya getirme demek
on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10

Select*from Products p left join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID=od.OrderID --left join solda olup sağda olmayanları getir demek, --right join tam tersi

select*from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

--DTO Data Transformation object

insert into customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Country)
values ('KKTY', 'Donit Company', 'Burak Koktay', 'Master of None', 'Antalya Ahatli', 'Antalya','Turkey')


select * from Customers where Country='Turkey'