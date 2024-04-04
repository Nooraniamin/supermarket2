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
create table categories(
c_id int identity primary key,
c_name varchar(50) not null,
cmp_id int not null foreign key references company(cmp_id) on delete no action on update no action
)
create table product(
p_id int identity primary key,
p_name varchar(30) not null,
c_id int not null foreign key references categories(c_id) on delete no action on update no action,
amount money not null,
discount int not null,
a_discount money not null,
cmp_id int not null foreign Key references company(cmp_id) on delete no action on update no action
)
create table insertitems(
id int identity primary key,
billno int not null,
p_id int not null foreign key references product(p_id),
price money not null,
discount int not null,
a_amount money not null,
qty int not null,
f_amount money,
b_id int not null foreign key references branch(b_id) on delete no action on update no action,
u_id int not null foreign key references users(u_id),
dateno varchar(10) not null
)
create table customer
(
cus_id int identity primary key,
cus_name varchar(20) not null,
cus_number varchar(15) unique not null,
cmp_id int not null foreign key references company(cmp_id) on delete no action on update no action
)
create table bill(
id int identity primary key,
billno int not null unique,
billtype varchar(20),
f_amount money not null,
g_amount money,
r_amount money,
cus_id int  not null foreign key references customer(cus_id) on delete no action on update no action,
b_id int not null foreign key references branch(b_id) on delete no action on update no action
)