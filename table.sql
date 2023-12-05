create table company(
cmp_id int identity primary key,
cmp_name varchar(30) not null,
cmp_key varchar(10) not null)

create table branch(
b_id int identity primary key,
b_name varchar(50) not null,
bcm_id int not null foreign key references company(cmp_id) on delete no action on update no action
)
create table roles(
r_id int identity primary key,
r_name varchar(30) not null,
c_id int not null foreign key references company(cmp_id) on delete no action on update no action
)
create table users(
u_id int identity primary key,
u_name varchar(30) not null,
u_cnic int not null,
b_id int not null foreign key references branch(b_id) on delete no action on update no action,
r_id int not null foreign key references roles(r_id) on delete no action on update no action,
u_u_name varchar(30) unique not null,
u_password varchar(30) not null,
u_c_password varchar(30) not null,
cmp_id int not null foreign key references company(cmp_id) on delete no action on update no action)
