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