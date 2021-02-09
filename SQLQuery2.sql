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

select count(UnitPrice) from Products

select AVG(unitprice) from Products

select sum(unitprice) from Products

select count(unitprice) from Products where unitprice>=200

select * from products where ProductName like '%cc%'

select * from products where productname like '__r%s'

select * from products where productname like 'c__%t'

select*from Products where ProductName not like 'c%'

select*from customers where city not like '[bsp]%'

select*from customers where city like '[!a-d]%'

select*from customers 

select*from products

select*from orders

select*from products order by productname

select*from customers where country in (select Country from Suppliers)

select*from customers where country not between 'Mexico' and 'USA'

select*from products where unitprice between 10 and 20 and categoryid not in (4,5,6,7,8)

select*from products where ProductName between 'Filo Mix' and 'Ikura' order by ProductName desc

select productname as ürün from products

select productname from products as ürün

select*from Shippers

select*from [Order Details]

select*from Suppliers

select ProductName as Name, UnitPrice as Price from products

select productname as [cheap products] from products

select productname, unitsinstock + unitsonorder as PAPAPAPA from products

select o.OrderId, o.OrderDate, c.CompanyName from customers as c, orders as o where c.companyname='around the horn'

select orders.OrderID from orders inner join customers on orders.CustomerID=customers.CustomerID

select*from orders left join customers on orders.CustomerID=Customers.CustomerID

select orders.OrderID, customers.CompanyName from (orders inner join customers on orders.CustomerID=customers.CustomerID)

select customers.CompanyName, orders.OrderID from customers left join orders on customers.CustomerID=orders.CustomerID order by customers.CompanyName

select orders.OrderID, employees.LastName, Employees.FirstName, employees.EmployeeID from orders right join employees on orders.EmployeeID=employees.EmployeeID order by orders.OrderID

select customers.CompanyName, orders.OrderID from customers full outer join orders on Customers.CustomerID=orders.CustomerID order by customers.companyname

select a.companyname as customername1, b.companyname as customername2, a.country from customers a, customers b where a.customerID<>b.customerID and a.country=b.country order by a.country

select city from customers union all select city from Suppliers order by city

select city, country from customers where country='germany' union select city, country from suppliers where country='germany' order by city

select 'customer' as type,contactname,city,country from customers union select 'supplier',contactname,city,country from suppliers

select count(customerID) as ekmek, country from customers group by country order by count(customerID)

select shippers.CompanyName, count(orders.OrderID) as NumberOfOrders from Orders left join Shippers on Orders.OrderID=shippers.ShipperID group by CompanyName

select count(customerID), country from customers group by country having count(customerID) >3 order by count(CustomerID)

select Employees.lastname, count(orders.OrderID) from (orders inner join employees on orders.EmployeeID=Employees.EmployeeID) group by lastname having count(orders.orderId) > 10

select Employees.lastname, count(orders.OrderID) from orders inner join employees on orders.EmployeeID=Employees.EmployeeID where lastname='davolio' or lastname='fuller' group by lastname having count(orders.OrderID)>25

select companyname from suppliers where exists (select productname from products where products.SupplierID=Suppliers.SupplierID and Unitprice < 22)

select companyname from suppliers where Unitprice < 22

select productname from products where productid = any (select productid from [order details] where Quantity >=10) order by productname

select productname from products where productid = all (select productid from [order details] where quantity > 10)

select products.productname as ürünadi, sum([order details].UnitPrice*[order details].Quantity) as toplammiktar 
from products inner join [order details] on products.productid=[order details].productid 
inner join orders on orders.orderid=[order details].OrderID group by products.ProductName

select p.productname as ürünadi, sum(od.unitprice*od.quantity) as toplam 
from products p inner join [Order Details] od on p.ProductID=od.ProductID
inner join orders o on o.OrderID=od.OrderID group by p.ProductName

select Products.ProductName ürünadi, 
sum([Order Details].UnitPrice*[Order Details].Quantity) KazanılanToplamMiktar 
from Products inner join [Order Details] on 
Products.ProductID=[Order Details].ProductID inner join Orders
on Orders.OrderID=[Order Details].OrderID
group by Products.ProductName;