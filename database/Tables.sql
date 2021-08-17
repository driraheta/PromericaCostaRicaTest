use demo
go

create table Make
(
    id int identity(1,1) PRIMARY KEY,
    name VARCHAR(100) not null,
    country VARCHAR(1500) null
)

create table Pattern
(
    id int identity(1,1) PRIMARY KEY,
    make_id int FOREIGN KEY REFERENCES Make(id),
    name varchar(200) not null,
    color varchar(100) not null,
    year int not null,
    doors int null
)


insert into Make (name, country) values ('TOYOTA', 'JAPON')
insert into Make (name, country) values ('HONDA', 'JAPON')
insert into Make (name, country) values ('MAZDA', 'JAPON')
insert into Make (name, country) values ('HYUNDAI', 'COREA DEL SUR')
insert into Make (name, country) values ('AUDI', 'ALEMANIA')
insert into Make (name, country) values ('MERCEDEZ BENZ', 'ALEMANIA')
insert into Make (name, country) values ('KIA', 'COREA DEL SUR')
insert into Make (name, country) values ('BMW', 'ALEMANIA')
insert into Make (name, country) values ('BENTLEY', 'REINO UNIDO')


select * from Make

