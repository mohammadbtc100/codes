--https://learn.microsoft.com/en-us/sql/t-sql/statements/alter-login-transact-sql?view=sql-server-ver16

/*Novels Table*/
create table novels(
	id int identity(1,1),
	name varchar(50),
	cover image,
	constraint pk_novels primary key(id)
);
select * from novels;

/*Login*/
CREATE LOGIN loginname WITH PASSWORD = '<Password>';
CREATE LOGIN dblab2 WITH PASSWORD = 'Fall@f2024';
drop login dblab2;
alter login dblab2 with password='Fall@f2024' MUST_CHANGE,CHECK_EXPIRATION=ON;
GRANT SELECT, INSERT, UPDATE, DELETE TO Developer;

-- Store Procedure
CREATE PROCEDURE addNovel
	@name varchar(50),
	@cover image
AS
BEGIN
	insert into novels(name,cover) values(@name,@cover);
END
GO

