USE master;

Create table usuarios(
UserID int identity(1,1) primary key,
LoginName nvarchar(100) unique not null,
Password nvarchar(100) not null,
Email nvarchar(150) not null);

insert into usuarios values ('braynel','yuca','braynelgg@gmail.com');
insert into usuarios values ('yamil','azucar','yamilgg@gmail.com');
select * from usuarios

Select @@version