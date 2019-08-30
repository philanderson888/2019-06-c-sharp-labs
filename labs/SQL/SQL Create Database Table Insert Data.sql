drop database test02
drop table table_02

create database test02

create table table_02(
	id int NOT NULL IDENTITY,
	name nvarchar(50) NOT NULL,
	ishappy bit,
	date_of_birth DATETIME NULL,
)

INSERT INTO table_02 (name,date_of_birth) VALUES ('BOB','2019-01-01 05:22:01.123')
INSERT INTO table_02 (name,date_of_birth) VALUES ('tim','2019-01-01 05:22:01.123')
INSERT INTO table_02 (name, ishappy) VALUES ('paula','true')
select * from table_02

UPDATE table_02 set ishappy='false' where id=3
select * from table_02

UPDATE table_02 set ishappy='false'
select * from table_02

