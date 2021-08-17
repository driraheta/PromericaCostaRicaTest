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

ALTER TABLE dbo.Pattern
  ADD CONSTRAINT uq_pattern UNIQUE(make_id, name, year, doors);

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

----------------------

select * from Pattern
INSERT INTO Pattern (make_id, name, color, year, doors) values (1, 'COROLLA', 'NEGRO', 2015, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (1, 'COROLLA', 'BLANCO', 2018, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (1, 'COROLLA', 'AZUL', 204, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (1, 'COROLLA', 'ROJO', 20120, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (1, 'YARIS', 'NEGRO', 2009, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (1, 'YARIS', 'NEGRO', 2015, 4)

INSERT INTO Pattern (make_id, name, color, year, doors) values (2, 'CIVIC', 'OCRE', 2009, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (2, 'CIVIC', 'AZUL', 2013, 2)
INSERT INTO Pattern (make_id, name, color, year, doors) values (2, 'CIVIC', 'BLANCO', 2015, 2)
INSERT INTO Pattern (make_id, name, color, year, doors) values (2, 'CITY', 'BLANCO', 2016, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (2, 'CITY', 'GRIS', 2018, 4)


INSERT INTO Pattern (make_id, name, color, year, doors) values (3, '3', 'GRIS', 2020, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (3, '3', 'NEGRO', 2018, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (3, '3', 'ROJO', 2010, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (3, 'CX-3', 'ROJO', 2018, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (3, 'CX-5', 'NEGRO', 2020, 4)


INSERT INTO Pattern (make_id, name, color, year, doors) values (4, 'ACCENT', 'GRIS', 2020, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (4, 'ELANTRA', 'BLANCO', 2018, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (4, 'ACCENT', 'ROJO', 2010, 4)

INSERT INTO Pattern (make_id, name, color, year, doors) values (7, 'RIO', 'NEGRO', 2014, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (7, 'RIO', 'ROJO', 2018, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (7, 'FORTE', 'AZUL', 2016, 4)
INSERT INTO Pattern (make_id, name, color, year, doors) values (7, 'FORTE', 'NEGRO', 2012, 2)
INSERT INTO Pattern (make_id, name, color, year, doors) values (7, 'FORTE', 'BLANCO', 2020, 4)

select * from Pattern