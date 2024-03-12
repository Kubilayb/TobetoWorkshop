--1. Product isimlerini (`ProductName`) ve birim başına miktar (`QuantityPerUnit`) değerlerini almak için sorgu yazın.

select product_name, quantity_per_unit from products;

--2. Ürün Numaralarını (`ProductID`) ve Product isimlerini (`ProductName`) değerlerini almak için sorgu yazın.
--Artık satılmayan ürünleri (`Discontinued`) filtreleyiniz.

select * from products; --buradan tüm ürünlere baktım ve satılmayan ürünlerden birisini not alıp sorgumu doğruladım.

select product_id, product_name from products where discontinued=1;

--3. Durdurulmayan (`Discontinued`) Ürün Listesini, Ürün kimliği ve ismi (`ProductID`, `ProductName`) değerleriyle almak için bir sorgu yazın.

select discontinued, product_id, product_name from products where discontinued=0;

--4. Ürünlerin maliyeti 20'dan az olan Ürün listesini (`ProductID`, `ProductName`, `UnitPrice`) almak için bir sorgu yazın.

select product_id, product_name, unit_price<20 from products;

--5. Ürünlerin maliyetinin 15 ile 25 arasında olduğu Ürün listesini (`ProductID`, `ProductName`, `UnitPrice`) almak için bir sorgu yazın.

select product_id, product_name, unit_price from products where unit_price between 15 and 25;

--6. Ürün listesinin (`ProductName`, `UnitsOnOrder`, `UnitsInStock`) stoğun siparişteki miktardan az olduğunu almak için bir sorgu yazın.

select product_name, units_on_order, units_in_stock from products where units_in_stock < units_on_order; --sipariş>stok

--7. İsmi `a` ile başlayan ürünleri listeleyeniz.

select product_name from products where product_name like 'A%';

select product_name from products where lower(product_name) like 'a%';

--8. İsmi `i` ile biten ürünleri listeleyeniz.
select product_name from products where product_name like '%i';

select product_name from products where lower(product_name) like '%i';

--9. Ürün birim fiyatlarına %18’lik KDV ekleyerek listesini almak (ProductName, UnitPrice, UnitPriceKDV) için bir sorgu yazın.

select * from products;
select product_name, unit_price, unit_price from products;

select product_name, unit_price, unit_price from products;

select product_name, unit_price, unit_price*1.18 as unit_price_kdv from products; --as aliases(takma ad keyword ü)

--10. Fiyatı 30 dan büyük kaç ürün var?

select count(*) as otuzdan_buyuk from products where unit_price>30;

--11. Ürünlerin adını tamamen küçültüp fiyat sırasına göre tersten listele

select lower(product_name) as lower_case_product_name, unit_price from products order by unit_price desc;
select lower(product_name) as lower_case_product_name, unit_price from products order by unit_price asc;

--12. Çalışanların ad ve soyadlarını yanyana gelecek şekilde yazdır

select * from employees;

select concat(first_name,last_name) as yanyana_hali from employees; --concat karakterleri birleştirmek için kullanılan keyword

--13. Region alanı NULL olan kaç tedarikçim var?

select region from employees; -- kontrol amaçlı sorgu
select count(*) from suppliers where region is null;

--14. Region alanı Null olmayan kaç tedarikçim var?

select count(*) from suppliers where region is not null;

--15. Ürün adlarının hepsinin soluna TR koy ve büyültüp olarak ekrana yazdır.

select product_name from products; -- öncesi

select upper(concat('TR - ', product_name)) as TR_eklenmis_hali from products;

--16. Fiyatı 20den küçük ürünlerin adının başına TR ekle

select concat('TR -', product_name) as fiyatı_20den_az_olanlar from products where unit_price<20;

--17. En pahalı ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.

select product_name, unit_price from products order by unit_price desc limit 1;

select product_name,unit_price as en_pahalı_ürün from products where unit_price = (select max(unit_price) from products);

--18. En pahalı on ürünün Ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.

select product_name, unit_price from products order by unit_price desc limit 10;

--19. Ürünlerin ortalama fiyatının üzerindeki Ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.

select avg(unit_price) as ortalama_fiyat from products;  -- Ürünleri ort fiyatı:28.83 küsür

select product_name, unit_price from products where unit_price > (select avg(unit_price) from products); -- ortalamadan yüksek olanlar

--20. Stokta olan ürünler satıldığında elde edilen miktar ne kadardır.

select sum(unit_price * units_in_stock) as "elde_edilen_miktar" from products;

--21. Mevcut ve Durdurulan ürünlerin sayılarını almak için bir sorgu yazın.

select * from(select count(product_id) as Mevcut from products where units_in_stock > 0),
(select count(product_id) as Durdurulan from products where discontinued = 1);

--22. Ürünleri kategori isimleriyle birlikte almak için bir sorgu yazın.

SELECT p.product_name, c.category_name 
FROM products p, categories c WHERE p.category_id = c.category_id;

--23. Ürünlerin kategorilerine göre fiyat ortalamasını almak için bir sorgu yazın.

SELECT c.category_name, AVG(p.unit_price) AS "ortalama_fiyat" 
FROM products p JOIN categories c 
ON p.category_id = c.category_id GROUP BY c.category_name;
-- Diğer çözüm
select category_id, avg(unit_price) as ort_kategori 
from products group by category_id order by category_id asc;


--24. En pahalı ürünün adı, fiyatı ve kategorisinin adı nedir?

SELECT p.product_name, p.unit_price, c.category_name FROM products p 
JOIN categories c ON p.category_id = c.category_id ORDER BY p.unit_price DESC LIMIT 1;

--25. En çok satılan ürününün adı, kategorisinin adı ve tedarikçisinin adı
select product_name,units_on_order,suppliers.company_name,categories.category_name 
from products 
INNER JOIN categories
ON products.category_id=categories.category_id
INNER JOIN suppliers
ON products.supplier_id = suppliers.supplier_id
Where 
units_on_order= (Select Max(units_on_order) from products)

-- Diğer çözüm

select p.product_name, c.category_name, s.contact_name from products p
join categories c on p.category_id = c.category_id
join suppliers s on s.supplier_id = p.supplier_id
order by p.units_on_order desc
limit 1

-- Diğer çözüm 2

SELECT p.product_name, c.category_name, p.units_on_order, s.company_name 
FROM products p JOIN categories c ON p.category_id = c.category_id 
JOIN suppliers s ON p.supplier_id = s.supplier_id ORDER BY p.units_on_order DESC LIMIT 1;
																 