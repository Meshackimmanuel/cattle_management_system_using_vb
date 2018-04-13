create database  NEWPROJECT
USE NEWPROJECT
create table CATTLE
(
Id varchar(5) primary key,
C_type varchar(4)not null,
Age int,
Dob datetime,
Pasture_id varchar(5) not null,
foreign key(Pasture_id) references PASTURE(Id) on update cascade on delete cascade,
);

create table PASTURE
(
Name varchar(20) not null,
Id varchar(5) primary key,
Location varchar(10) not null,
Area float,
);

create table PURCHASE
(
Purchase_id varchar(5) primary key,
Date datetime,
Amount float,
Seller_name varchar(10),
Seller_no int,
Type char,
);

create table SALES
(
Sales_id varchar(5) primary key,
Date datetime,
Amount float,
Customer_name varchar(10),
Customer_no int,
Type char,
);


create table MILKING
(
Milking_id varchar(5) primary key,
Date datetime,
Cattle_id varchar(5),
Quantity float,
foreign key(cattle_id) references cattle(id) on delete cascade on update cascade
);

create table BREEDING
(
Cattle_id varchar(5) not null,
Calving_date datetime,
Method varchar(100),
foreign key(cattle_id) references CATTLE(id) on update cascade on delete cascade
);

drop table pasture
drop table cattle
drop table purchase
drop table sales
drop table milking
drop table breeding


select * from cattle
select * from pasture
select * from purchase
select * from sales
select * from milking
select * from breeding

insert into cattle values('1234','cow','4','26-march-2013','11111')
insert into pasture values('ram estate','11111','mangalore','24')
insert into purchase values('1234','26-march-2013','25000','krishna','9999','C')
insert into sales values('1234','26-march-2013','30000','govind','8888','C')
insert into milking values('1234','26-march-2013','1234','25')
insert into breeding values('1234','26-march-2013','natural mating')

alter table sales add Type char
alter table sales drop column type


update SALES set type ='C'

select * from milking

alter table milking drop column sales_id , customer_name,customer_no
alter table milking add Cattle_id varchar(10)
update MILKING set cattle_id='1234'
ALTER TABLE milking drop column quantity 
ALTER TABLE milking add Quantity float
update MILKING set quantity='24'
alter table milking drop FK__MILKING__Sales_i__164452B1
SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME ='milking'
select ID from CATTLE where c_TYPE = 'cow'
alter table purchase add Type char
update PURCHASE set type= 'C'
alter table cattle drop column name

insert into cattle values('2585','cow','5','23-december-2015','11111')

use master

drop database project