create database supermarket
create table company(
cmp_id int identity primary key,
cmp_name varchar(30),
cmp_key  varchar(10) unique
) 