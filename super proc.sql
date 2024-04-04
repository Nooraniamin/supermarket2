-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @2p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO

create procedure st_insertbranch
@name varchar(50),
@c_id int
as
insert into branch values(@name,@c_id)

create procedure st_deletebranch
@id int
as
delete from branch where b_id = @id

create procedure st_updatebranch
@id int,
@name varchar(50),
@c_id int
as
update branch
set 
b_name = @name,
bcm_id = @c_id
where
b_id = @id 

create procedure st_getbranch 
as
select
b.b_id as 'ID',
b.b_name as'NAME',
b.bcm_id as 'BRANCH ID',
c.cmp_name as 'BRNCH NAME'
from branch b
inner join company c
on c.cmp_id = b.bcm_id
order by b.b_name asc

create procedure st_insertrole
@name varchar(50),
@c_id int
as
insert into roles values(@name,@c_id)

create procedure st_deleterole
@id int
as
delete from roles where r_id = @id

create procedure st_updatebranch
@id int,
@name varchar(50),
@c_id int
as
update roles
set 
r_name = @name,
c_id = @c_id
where
r_id = @id 

create procedure st_getroles 
as
select
r.r_id as 'ID',
r.r_name as'NAME',
r.c_id as 'COMPANY ID',
c.cmp_name as'COMPANY NAME'
from roles r
inner join company c
on c.cmp_id = r.r_id
order by r.r_name asc

create procedure st_insertuser
@name varchar(30),
@cnic int,
@b_id int,
@r_id int,
@u_name varchar(30),
@password varchar(30),
@c_password varchar(30),
@c_id int
as
insert into users values(@name,@cnic,@b_id,@r_id,@u_name,@password,@c_password,@c_id)

create procedure st_userdelete
@id int
as
delete from users where u_id = @id

create procedure st_userupdate
@id int,
@name varchar(30),
@cnic int,
@b_id int,
@r_id int,
@u_name varchar(30),
@password varchar(30),
@c_password varchar(30),
@c_id int
as update users
set
u_name = @u_name,
u_cnic = @cnic,
b_id = @b_id,
r_id = @r_id,
u_u_name = @u_name,
u_password = @password,
u_c_password = @c_password,
cmp_id = @c_id
where
u_id = @id 

create procedure st_getusers
as
select
u.u_id as 'ID',
u.u_name as 'NAME',
u.u_cnic as 'CNIC',
u.b_id as 'B_ID',
b.b_name as 'BRANCH',
u.r_id as 'R_ID',
r.r_name as 'ROLES',
u.u_u_name as 'U_NAME',
u.u_password as 'PASSWORD',
u.u_c_password as 'C_PASSWORD',
u.cmp_id as 'C_ID',
c.cmp_name as 'COMPANY NAME'
from users u
inner join branch b
on b.b_id = u.u_id
inner join roles r
on r.r_id = u.u_id
inner join company c
on c.cmp_id = u.u_id
create procedure st_getcompany
@name varchar(30),
@pass varchar(10)
as
select c.cmp_id as 'ID', c.cmp_name as 'Name', c.cmp_key as 'Key' from company c
where	
c.cmp_name = @name and
c.cmp_key = @pass

create procedure st_getlogin
@id int,
@name varchar(30),
@pass varchar(30)
as
select
u.u_id as 'ID',
u.u_name as 'NAME',
u.u_cnic as 'CNIC',
u.u_salary as 'SALARY',
u.b_id as 'B_ID',
b.b_name as 'BRANCH',
u.r_id as 'R_ID',
r.r_name as 'ROLES',
u.u_u_name as 'U_NAME',
u.u_password as 'PASSWORD',
u.u_c_password as 'C_PASSWORD',
u.cmp_id as 'C_ID',
c.cmp_name as 'COMPANY NAME'
from users u
inner join branch b
on b.b_id = u.b_id
inner join roles r
on r.r_id = u.r_id
inner join company c
on c.cmp_id = u.cmp_id
where
c.cmp_id = @id and u.u_name = @name and u.u_c_password = @pass 

create procedure st_insertCategories
@name varchar(50),
@cmp_id int
as
insert into categories values(@name,@cmp_id)

create procedure st_deleteCategories
@id int
as
delete from categories where c_id = @id

create procedure st_updateCategories
@id int,
@name varchar(50),
@cmp_id int
as
update categories
set 
c_name = @name,
cmp_id = @cmp_id
where
c_id = @id

create procedure st_getCategories
@id int
as 
select
c.c_id as 'ID',
c.c_name as'NAME',
c.cmp_id as 'COMPANY ID',
cmp.cmp_name as'COMPANY NAME'
from categories c
inner join company cmp
on cmp.cmp_id = c.cmp_id
where c.cmp_id = @id
order by c.c_name asc

create procedure st_insertproduct
@name varchar(30),
@c_id int,
@amount money,
@discont int,
@a_amount money,
@cmp_id int
as 
insert into product values(@name,@c_id,@amount,@discont,@a_amount,@cmp_id)

create procedure st_deleteproduct
@id int
as
delete from product where p_id = @id
 
create procedure st_updateproduct
@id int,
@name varchar(30),
@c_id int,
@amount money,
@discount int,
@a_amount money,
@cmp_id int
as
update product
set
p_name = @name,
c_id = @c_id,
amount = @amount,
discount = @discount,
a_discount = @a_amount,
cmp_id =  @cmp_id
where
p_id = @id 

create procedure st_getproduct
@id int
as
select
p.p_id as 'ID',
p.p_name as 'NAME',
p.c_id as 'C_ID',
c.c_name as 'C_NAME',
p.amount as 'AMOUNT',
p.discount as 'DISCOUNT',
p.a_discount as 'A_DISCOUNT',
p.cmp_id as 'CMP_ID',
cmp.cmp_name as 'CMP_NAME'
from product p
inner join categories c
on c.c_id = p.c_id
inner join company cmp
on cmp.cmp_id = p.cmp_id
where
cmp.cmp_id = @id 
order by p.p_name asc

create procedure st_getMenu
@id int
as 
select
p.p_id as 'ID',
p.p_name as'NAME'
from product p
inner join categories c
on c.c_id = p.c_id
where p.c_id = @id
order by p.p_name asc

create procedure st_getpriceWRTproduct
@id int
as 
select
p.amount as 'Price',
p.discount as 'Discount',
p.a_discount as 'After discount'
from product p
where 
p.p_id = @id

create procedure st_insertitem
@billno int,
@p_id int,
@price money,
@discount money,
@a_amount money,
@qty int,
@famount money,
@b_id int,
@u_id int,
@date varchar(10)
as 
insert into insertitems values(@billno,@p_id,@price,@discount,@a_amount,@qty ,@famount,@b_id ,@u_id,@date)

create procedure st_deleteitem
@id int
as
delete from insertitems where  id = @id 

create procedure st_updateitem
@id int,
@billno int,
@p_id int,
@price money,
@discount money,
@a_amount money,
@qty int,
@famount money,
@b_id int,
@u_id int,
@date varchar(10)
as
update insertitems
set
p_id = @p_id,
price = @price,
discount = @discount,
a_amount = @a_amount,
qty = @qty,
f_amount = @famount,
b_id = @b_id,
u_id = @u_id,
dateno = @date
where
id = @id and billno = @billno

alter procedure st_getitems
@billno int
as 
select
i.id as 'id',
i.p_id as 'p_id',
p.p_name as 'Product',
i.price as 'Price',
i.discount as 'discount',
i.a_amount as 'after amount',
i.qty as 'qty',
i.f_amount as 'total',
i.billno as 'Bill no'
from insertitems i
inner join product p
on p.p_id = i.p_id
where
i.billno = @billno

create procedure st_getcategoriesWRTproduct
@id int
as 
select
c.c_id as 'c_id',
c.c_name as 'C_name'
from categories c
inner join product p
on c.c_id = p.c_id
where
p.p_id = @id

create procedure st_insertcustomer
@name varchar(20),
@phone varchar(15),
@cmp int
as
insert into customer values(@name,@phone,@cmp)

create procedure st_getcusWRTphone
@phone varchar(15)
as
select
c.cus_id as 'id',
c.cus_name as 'name',
c.cus_number as 'phone'
from customer c
where
c.cus_number = @phone

create procedure st_insertbill
@billno int ,
@billtype varchar(20),
@f_amount money,
@g_amount money,
@r_amount money,
@cus_id int,
@b_id int 
as
insert into bill values(@billno,@billtype ,@f_amount ,@g_amount ,@r_amount ,@cus_id ,@b_id)