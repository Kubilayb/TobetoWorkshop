select * from products;

select product_name,unit_price from products;

--where koşulu

Select * from products where category_id=2

--Birden fazla filtreleme
-- Stok sayısı 60'dan büyük ve category_id=3
-- iki koşuluda sağlayan dataları getir

--And 
Select product_name,units_in_stock,category_id from products where units_in_stock>60 and category_id=3

--iki koşuldan birisinin sağlaması durumu

--Or 
Select product_name,units_in_stock,category_id from products where units_in_stock>60 or category_id=3


--Between keywordu
Select product_name,units_in_stock,category_id from products where units_in_stock>=60 and units_in_stock<=120

Select product_name,units_in_stock,category_id from products where units_in_stock Between 40 AND 100

Select product_name,units_in_stock,category_id from products where category_id Between 2 AND 5

--COUNT => adet sayısı


Select COUNT(*) from products where unit_price>50

--alias => takma isim
Select COUNT(*) AS "ürün adedi" from products where unit_price>50


Select COUNT(city) from employees;

Select city from employees;

--DISTINCT
-- tekrarı engelliyor
Select distinct city from employees

Select COUNT(distinct city) as "Şehirler"  from employees



--In() fonksiyonu
--içerisinde parametre olarak verilen n kadar veri
select * from products where product_name='Chai' or product_name='Chang' or product_name='Aniseed Syrup';

Select * from products Where product_name IN('Chai','Chang','Aniseed Syrup')

Select * from products Where category_id IN(2,3,5)


select * from products;

--LIKE keywordu
-- pattern => kalıba benzer ifadeleri getirir
-- % => ilgili metnin sol ya da sağına eklendiğinde

Select * from products where product_name LIKE 'Gei%'

Select * from products where product_name LIKE '%ost'

Select * from products where product_name LIKE 'Gei__st'

Select * from products where product_name LIKE '%t%'

-- SUM => toplama
Select SUM(unit_price) as "total unit price" from products

--Average => AVG
Select AVG(unit_price) as "Average unit price" from products

Select AVG(unit_price) as "Average unit price" from products where unit_price>60


--MAX - MIN
Select MAX(unit_price) as "max unit price" from products

Select MIN(unit_price) as "max unit price" from products

--order by => sıralama
--default olarak küçükten büyüğe

--Descending => DESC => büyükten küçüğe
select product_name,unit_price from products order by unit_price DESC 

--Ascending => ASC => küçükten büyüğe
select product_name,unit_price from products order by unit_price ASC 

select product_name,unit_price from products where unit_price>50 order by unit_price ASC 

--SUB QUERY -- İç içe sorgular
-- ortalamanın altında bir fiyata sahip olan

Select product_name,unit_price from products where unit_price < (Select AVG(unit_price) from products)

select product_name,unit_price from products Where unit_price= (Select Max(unit_price) from products)

select product_name,unit_price from products Where unit_price= (Select Min(unit_price) from products)
