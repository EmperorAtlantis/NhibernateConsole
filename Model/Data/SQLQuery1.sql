use master
go

if exists(select * from sysdatabases where name='Hibernate_test')
begin 
	select '该数据库已存在'
	drop database Hibernate_test
end
else
begin
	create database	Hibernate_test
	on primary
	(
		name='hib',
		filename='D:\VS\SQL\Hib_test\hib.mdf',
		size=5mb,
		maxsize=unlimited,
		filegrowth=10%
	)
	log on
	(
		name='hib_log',
		filename='D:\VS\SQL\Hib_test\hib_log.ldf',
		size=1mb,
		maxsize=unlimited,
		filegrowth=1mb
	)
end
