/*Database*/
create database uniDb;
use uniDb;
--Students Tables
create table students(
	sid bigint identity(1,1) primary key,
	name nvarchar(50) not null,
	field nvarchar(50)
);
insert into students(name,field) Values('Ali','Com');
insert into students(name,field) Values('Reza','Com');
select * from students;

--Courses
create table courses(
	cid int identity(1,1) primary key,
	name nvarchar(50) not null,
	field nvarchar(50)
);
insert into courses(name,field) values('Db','com');
insert into courses(name,field) values('Ds','com');
insert into courses(name,field) values('Ad','com');
select * from courses;

--Teacher
create table teachers(
	tid int identity(100,10) primary key,
	name nvarchar(50),
	field nvarchar(50)
);
insert into teachers(name,field) values('Ab','com');
insert into teachers(name,field) values('Pa','com');
select * from teachers;

--Presentation
create table present(
	cid int references courses(cid),
	tid int references teachers(tid),
	term int,
	[day] int,
	[time] char(5),
);
select * from present;

--Selection
create table selection(
	[sid] bigint references students([sid]),
	cid int references courses(cid),
	term int
);
select * from selection;