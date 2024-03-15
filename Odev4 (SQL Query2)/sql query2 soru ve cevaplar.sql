--Genel sorgular
select * from products;
select * from suppliers;
select * from employees;
--26. Stokta bulunmayan ürünlerin ürün listesiyle birlikte tedarikçilerin ismi ve iletişim numarasını 
--(`ProductID`, `ProductName`, `CompanyName`, `Phone`) almak için bir sorgu yazın.

select p.product_id, p.product_name, s.company_name, s.phone, p.units_in_stock from products p
inner join suppliers s on s.supplier_id = p.supplier_id
where units_in_stock <= 0;

--27. 1998 yılı mart ayındaki siparişlerimin adresi, siparişi alan çalışanın adı, çalışanın soyadı

select o.ship_address as "Sipariş Adresi", concat(e.first_name,' ',e.last_name) as "Çalışanın Adı Soyadı"  from orders o
inner join employees e on e.employee_id = o.employee_id
where extract(year from order_date) = 1998

--28. 1997 yılı şubat ayında kaç siparişim var?

select count(*) as "1997 Şubat Siparişi Sayısı" from orders
where order_date between '1997-02-01'and '1997-02-28';

--29. London şehrinden 1998 yılında kaç siparişim var?

select count(*) as "1998 de London sipariş sayısı" from orders
where extract(year from "order_date") = 1998 and "ship_city"='London'; 

--EXTRACT fonksiyonu, bir tarih veya zaman değerinden belirli bir bileşeni 
--(yıl, ay, gün, saat, vb.) çıkarmak veya almak için kullanılır. 

--alternatif
select count(order_id) as "London 1998 Order" from orders
where ship_city = 'London' and substring(cast(order_date as varchar), 1, 4) = '1998';

----------------------------
--30. 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası

select distinct c.contact_name, c.phone from orders o
inner join customers c on o.customer_id = c.customer_id
where extract(year from order_date) = 1997

--DISTINCT, bir sorgunun sonucunda yinelenen satırları kaldırmak için kullanılan bir SQL anahtar sözcüğüdür. 
--Yani, bir sorgunun sonucunda aynı değerlere sahip birden fazla satır varsa, 
--DISTINCT kullanılarak bu yinelenen satırların bir kez gösterilmesi sağlanır. 
--Bu sayede, sonuç kümesinde her bir değerin yalnızca bir kez bulunmasını sağlar.

-- 30. 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası

select distinct c.contact_name, c.phone
from customers c
join orders o on c.customer_id = o.customer_id
where extract(year from o.order_date) = 1997

-- 31. Taşıma ücreti 40 üzeri olan siparişlerim

select o.order_id, o.freight
from orders o
where o.freight > 40;

-- 32. Taşıma ücreti 40 ve üzeri olan siparişlerimin şehri, müşterisinin adı

select o.order_id, c.contact_name, o.ship_city, o.freight
from orders o
join customers c on o.customer_id = c.customer_id
where o.freight >= 40;

-- 33. 1997 yılında verilen siparişlerin tarihi, şehri, çalışan adı -soyadı ( ad soyad birleşik olacak ve büyük harf),

select o.order_date, o.ship_city, concat(e.first_name, ' ', e.last_name) as "Çalışanın Adı ve Soyadı"
from orders o 
join employees e on o.employee_id = e.employee_id
where extract(year from o.order_date) = 1997

-- 34. 1997 yılında sipariş veren müşterilerin contactname i, ve telefon numaraları ( telefon formatı 2223322 gibi olmalı )

select distinct c.contact_name,translate(c.phone, '()- ','') as telefon
from customers c
join orders o on c.customer_id = o.customer_id
where extract(year from o.order_date) = 1997
--translate('selam', 'se', 'as') gibi  aslam yapıyor.translate(c.phone,'()- ','') burada parantez tire ve boşluk gitsin '' bitişik olsun demiş olduk

-- 35. Sipariş tarihi, müşteri contact name, çalışan ad, çalışan soyad

select o.order_date, c.contact_name as "Müşterinin Adı ve Soyadı", concat(e.first_name, ' ', e.last_name) as "Çalışanın Adı ve Soyadı"
from orders o
join customers c on o.customer_id = c.customer_id
join employees e on o.employee_id = e.employee_id;

-- 36. Geciken siparişlerim?

select * from orders o
where o.required_date < o.shipped_date;

-- 37. Geciken siparişlerimin tarihi, müşterisinin adı

select o.order_date as "Sipariş Tarihi", c.contact_name as "Müşteri Adı"
from orders o
join customers c on o.customer_id = c.customer_id
where o.required_date < o.shipped_date;

-- 38. 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi

select o.order_id, p.product_name, c.category_name, od.quantity
from orders o 
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
join categories c on p.category_id = c.category_id
where o.order_id = 10248;

-- 39. 10248 nolu siparişin ürünlerinin adı , tedarikçi adı

select o.order_id, p.product_name, s.company_name
from orders o 
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
join suppliers s on p.supplier_id = s.supplier_id
where o.order_id = 10248;

-- 40. 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti

select e.employee_id, p.product_name, od.quantity as "satılan ürün adedi", o.order_date
from employees e
join orders o on e.employee_id = o.employee_id
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
where e.employee_id = 3 and extract(year from o.order_date) = 1997;

-- 41. 1997 yılında bir defasinda en çok satış yapan çalışanımın ID,Ad soyad

select e.employee_id, concat(e.first_name,' ', e.last_name) as "Ad Soyad", 
sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_order_price"
from employees e
join orders o on e.employee_id = o.employee_id
join order_details od on o.order_id = od.order_id
group by e.employee_id, o.order_date
having o.order_date between '1997.01.01' and '1997.12.31'
order by total_order_price desc
limit 1;

-- 42. 1997 yılında en çok satış yapan çalışanımın ID,Ad soyad 
select employee_id, sum(total_order_price) as "total_order_price_of_employee"
from (select e.employee_id, e.first_name, e.last_name, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_order_price"
	  from employees e
	  join orders o on e.employee_id = o.employee_id
	  join order_details od on o.order_id = od.order_id
	  group by e.employee_id, o.order_date
	  having o.order_date between '1997.01.01' and '1997.12.31'
	  order by total_order_price desc)
group by employee_id
order by total_order_price_of_employee desc
limit 1;

-- 43. En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?

select p.product_name, p.unit_price, c.category_name
from products p
join categories c on p.category_id = c.category_id
order by p.unit_price desc
limit 1;

-- 44. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre

select concat(e.first_name,' ',e.last_name) as "Personel Adı ve Soyadı", o.order_date, o.order_id,
from employees e
join orders o on e.employee_id = o.employee_id
order by o.order_date

-- 45. SON 5 siparişimin ortalama fiyatı ve orderid nedir?

select (sum(total_order_price) / 5) as "average_price_of_last_five_orders"
from (select o.order_id, o.order_date, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_order_price" 
	  from order_details od
	  join orders o on od.order_id = o.order_id
	  group by o.order_id, o.order_date
	  order by o.order_date desc
	  limit 5)

-- 46. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?

select p.product_name,c.category_name,sum(od.quantity) as "Ocak Ayı Toplam Satış Miktarı"
from orders o
join order_details od on o.order_id = od.order_id
join products p on od.product_id = p.product_id
join categories c on p.category_id = c.category_id
where extract(month from o.order_date) = 1
group by p.product_name, c.category_name;
-----DİĞER ÇÖZÜM
select p.product_name, c.category_name, sum(od.quantity) from products p
join categories c on p.category_id = c.category_id
join order_details od on p.product_id = od.product_id
join orders o on od.order_id = o.order_id
group by p.product_name, c.category_name, o.order_date
having substring(cast(o.order_date as varchar), 6, 2) = '01';

-- 47. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?
--ortalama satış miktarı
select Avg(quantity) as "Ortalama Satış Miktarı"
from order_details
-- ortalama üstü satışlar
select o.order_id,o.order_date,od.product_id,od.quantity
from orders o
join order_details od ON o.order_id = od.order_id
where od.quantity > (select avg(quantity) from order_details);

--diğer çözüm
select avg(unit_price * quantity) from orders o
join order_details od on o.order_id = od.order_id

-- 48. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı

select p.product_name, c.category_name, s.company_name, sum(od.quantity) as "Toplam satış"
from products p
join categories c on p.category_id = c.category_id
join suppliers s on p.supplier_id = s.supplier_id
join order_details od on p.product_id = od.product_id
group by p.product_name, c.category_name, s.company_name
order by "Toplam satış" desc
limit 1;

-- 49. Kaç ülkeden müşterim var

select count(distinct c.country) as total_country_count
from customers c;

-- 50. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?

select sum(od.quantity*od.unit_price) as "Toplam Satış"
from employees e
join orders o on e.employee_id = o.employee_id
join order_details od on o.order_id = od.order_id
where e.employee_id = 3 and order_date >'1998-01-01'

--51. 10 numaralı ID ye sahip ürünümden son 3 ayda ne kadarlık ciro sağladım?

select sum(od.unit_price * od.quantity) as "Toplam Ciro"
from orders o
join order_details od on o.order_id = od.order_id
where od.product_id = 10 and o.order_date >= current_date - interval '3 months';
--Dİğer çözüm
select p.product_id, sum(od.quantity * od.unit_price * (1 - od.discount)) as "total_endorsement"
from products p
join order_details od on p.product_id = od.product_id
join orders o on od.order_id = o.order_id
group by p.product_id, o.order_date
having p.product_id = 10 and o.order_date > current_date - interval '3 months';

--52. Hangi çalışan şimdiye kadar toplam kaç sipariş almış..?

select concat(e.first_name, ' ', e.last_name) as "Çalışanın Adı ve Soyadı", 
count(o.order_id) as "Sipariş Miktarı"
from employees e
join orders o on e.employee_id = o.employee_id
group by "Çalışanın Adı ve Soyadı"

--53. 91 müşterim var. Sadece 89’u sipariş vermiş. Sipariş vermeyen 2 kişiyi bulun

select c.contact_name, o.order_id
from customers c
left join orders o on c.customer_id = o.customer_id
where o.order_id is null
order by c.contact_name asc

--54. Brazil’de bulunan müşterilerin Şirket Adı, TemsilciAdi, Adres, Şehir, Ülke bilgileri

select c.company_name, c.contact_name, c.address, c.city, c.country
from customers c
where c.country = 'Brazil';

--55. Brezilya’da olmayan müşteriler

select c.contact_name, c.country
from customers c
where c.country != 'Brazil';

--56. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler

select c.contact_name, c.country
from customers c
where c.country = 'Spain' or  c.country = 'France' or c.country = 'Germany';

--57. Faks numarasını bilmediğim müşteriler

select c.contact_name, c.fax
from customers c
where c.fax is null;

--58. Londra’da ya da Paris’de bulunan müşterilerim

select c.contact_name, c.city
from customers c
where c.city = 'London' or c.city = 'Paris';

--59. Hem Mexico D.F’da ikamet eden HEM DE ContactTitle bilgisi ‘owner’ olan müşteriler

select c.contact_name, c.city, c.contact_title
from customers c
where c.city = 'México D.F.' and c.contact_title = 'Owner';

--60. C ile başlayan ürünlerimin isimleri ve fiyatları

select p.product_name, p.unit_price
from products p
where lower(p.product_name) like 'c%';

--61. Adı (FirstName) ‘A’ harfiyle başlayan çalışanların (Employees); Ad, Soyad ve Doğum Tarihleri

select e.first_name, e.last_name, e.birth_date
from employees e
where lower(e.first_name) like 'a%';

--62. İsminde ‘RESTAURANT’ geçen müşterilerimin şirket adları

select company_name
from customers
where lower(company_name) like '%restaurant%';

--63. 50$ ile 100$ arasında bulunan tüm ürünlerin adları ve fiyatları

select p.product_name, p.unit_price
from products p
where p.unit_price between 50 and 100;

--64. 1 temmuz 1996 ile 31 Aralık 1996 tarihleri arasındaki siparişlerin (Orders), SiparişID (OrderID) ve SiparişTarihi (OrderDate) bilgileri

select o.order_id, o.order_date
from orders o
where o.order_date between '1996-07-01' and '1996-12-31';

--65. Müşterilerimi ülkeye göre sıralıyorum:
select contact_name, country 
from customers 
order by country asc
--diğer çözüm
select c.contact_name, c.country
from customers c
order by c.country asc;

--66. Ürünlerimi en pahalıdan en ucuza doğru sıralama, sonuç olarak ürün adı ve fiyatını istiyoruz

select p.product_name, p.unit_price
from products p
order by p.unit_price desc;

--67. Ürünlerimi en pahalıdan en ucuza doğru sıralasın, ama stoklarını küçükten-büyüğe doğru göstersin sonuç olarak ürün adı ve fiyatını istiyoruz

select product_name, unit_price from products
order by unit_price desc,units_in_stock asc;
--Diğer çözüm
select p.product_name, p.unit_price
from products p
order by p.unit_price desc, p.units_in_stock asc;

--68. 1 Numaralı kategoride kaç ürün vardır..?

select count(*) as "Toplam Ürün Sayısı"
from products
where category_id = 1
--Diğer çözüm
select c.category_id, count(*) as "Toplam Ürün Sayısı"
from categories c
join products p on c.category_id = p.category_id
group by c.category_id
having c.category_id = 1;


--69. Kaç farklı ülkeye ihracat yapıyorum..?

select count(distinct c.country) as "Ülke sayısı"
from orders o join customers c on o.customer_id = c.customer_id

--70. a.Bu ülkeler hangileri..?

select distinct c.country
from customers c
order by c.country asc;

---71. En Pahalı 5 ürün

select p.product_name, p.unit_price
from products p
order by p.unit_price desc
limit 5;

--72. ALFKI CustomerID’sine sahip müşterimin sipariş sayısı..?

select c.customer_id, count(*) as "Sipariş sayısı"
from customers c
join orders o on c.customer_id = o.customer_id
group by c.customer_id
having c.customer_id = 'ALFKI';

--73.Ürünlerimin toplam maliyeti

select sum(unit_price * quantity) as "Toplam Maliyet"
from order_details 
--Toplam maliyeti her ürünün fiyatı ve miktarı ile hesapladım

--74. Şirketim, şimdiye kadar ne kadar ciro yapmış..?

select sum(od.quantity * od.unit_price * (1 - od.discount)) as "Toplam Ciro"
from order_details od

--75. Ortalama Ürün Fiyatım

select avg(p.unit_price) as "Ürünlerin Ortalama Fiyatı" from products p

--76. En Pahalı Ürünün Adı

select p.product_name as "En Pahalı Ürün", p.unit_price
from products p
order by p.unit_price desc
limit 1;

--77. En az kazandıran sipariş

select order_id, sum(unit_price * quantity) as "Toplam Kazanç"
from order_details
group by order_id
order by "Toplam Kazanç" asc limit 1;
--diğer çözüm
select o.order_id, sum(od.quantity * od.unit_price * (1 - od.discount)) as total_gained
from orders o
join order_details od on o.order_id = od.order_id
group by o.order_id
order by sum(od.quantity * od.unit_price) asc
limit 1;

--78. Müşterilerimin içinde en uzun isimli müşteri
select contact_name from customers

select c.contact_name, length(c.contact_name)
from customers c
group by c.contact_name
order by length(c.contact_name) desc
limit 1;

--79. Çalışanlarımın Ad, Soyad ve Yaşları

select concat(e.first_name,' ', e.last_name) as "Çalışanların Adı Soyadı", 
extract(year from age(current_date,birth_date)) as "Çalışanların Yaşları"
FROM employees e;

select * from employees
--Diğer çözüm
select concat(e.first_name,' ', e.last_name) as "Çalışanların Adı Soyadı" , date_part('year', age(current_date, e.birth_date)) as "age"
from employees e;

--80. Hangi üründen toplam kaç adet alınmış..?

select p.product_name, sum(od.quantity) as "Alınan Adet Sayısı"
from products p
join order_details od on p.product_id = od.product_id
group by p.product_name
order by p.product_name asc;

--81. Hangi siparişte toplam ne kadar kazanmışım..?

select o.order_id, sum(od.quantity * od.unit_price) as "Toplam Kazanç"
from orders o
join order_details od on o.order_id = od.order_id
group by o.order_id
order by o.order_id asc;

--82. Hangi kategoride toplam kaç adet ürün bulunuyor..?

select c.category_name, count(*) as total_product_count
from categories c
join products p on c.category_id = p.category_id
group by c.category_id
order by category_name asc;

--83. 1000 Adetten fazla satılan ürünler?

select p.product_name, sum(od.quantity) as "Satış Miktarı"
from products p
join order_details od on p.product_id = od.product_id
group by p.product_name
having sum(od.quantity) > 1000
order by sum(od.quantity) asc;

--84. Hangi Müşterilerim hiç sipariş vermemiş..?

select c.company_name, o.order_id
from customers c
left join orders o on c.customer_id = o.customer_id
where o.order_id is null;




