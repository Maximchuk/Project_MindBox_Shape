select o.Id, p.Name ProductName, c.Name CategoryName 
from order o 
inner join Products p on o.ProductId = p.Id
left join Category c on p.CategoryId = c.Id
where o.date_reg>='20240101'