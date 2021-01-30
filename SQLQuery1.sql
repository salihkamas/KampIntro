Select Products.ProductName as UrunAdi , sum([Order Details].UnitPrice*[Order Details].Quantity) as ToplamKazanc from Products inner join 
[Order Details] on Products.ProductID=[Order Details].ProductID inner join Orders on Orders.OrderID=[Order Details].OrderID
group by Products.ProductName
order by ToplamKazanc
