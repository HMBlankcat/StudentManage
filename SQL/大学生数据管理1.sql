
--创建Sqlserver数据库,表
-- 原始数据中有中文的时候插入到SQL server数据库中会产生中文乱码,在插入数据前加N解决

IF DB_ID(N'app_student_course') IS NULL
CREATE DATABASE app_student_course;
GO
USE app_student_course;
go

-- 创建管理员表

CREATE TABLE table_admin (
	id char(40) primary key , --主键 id
	username char(40) , --用户名
	password char(20) , --密码
	name char(30) , --姓名
	telephone char(11) --电话号码
)
go
-- 插入一条初始管理员用户数据
insert into table_admin(id,username,password) values('20001001000','123456','123456');

go
--创建系表
CREATE TABLE Department(
	Dno char(2) primary key,
	Dname char(20) UNIQUE NOT NULL,
	Dphone char(11) UNIQUE

)

-- 创建教室表
CREATE TABLE Classroom(
	Rno char(10) primary key,
	Rfloor int,
	Rlimit int,
)
go

CREATE TABLE Class(
	Classno char(10) primary key,
	Dno char(2),
	foreign key(Dno) references Department(Dno)
)






go

--创建课程表
CREATE TABLE Course(
	Cno char(8) primary key,--课程编号
	Cname char(20) ,--课程名称
	Ctype char(8),--课程类型
	Ccredit float,--课程学分
	Pnum char(5),--已选人数
	Rno char(10),--上课教室
	Ctime char(30),--上课时间
)

go

-- 创建学生表
CREATE TABLE Student(
	Sno char(11) primary key,
	Sname char(20) ,
	Ssex char(2) ,
	Sbirth char(10) ,
	Sclass char(6),
	Dno char(2),
	Spassword char(16) ,
	foreign key(Dno) references Department(Dno)
)

go
-- 创建教师表

create table Teacher(
	 Tno char(8) primary key ,  -- 主键
     Tname char(20)  ,  -- 姓名
     Tzc char(6)  ,  -- 职称
     Tphone char(11)  ,  -- 电话
	 Dno char(2),
	 TPassword char(16) ,
	 foreign  key(Dno) references Department(Dno)
)

go
--创建CRT表
CREATE TABLE CRT(
	Cno char(8),
	Tno char(8),
	Rno char(10),
	Climit smallint,
	primary key(Rno,Cno,Tno),
	foreign key(Tno) references Teacher(Tno),
	foreign key(Cno) references Course(Cno),
	foreign key(Rno) references Classroom(Rno),
)

go

--创建课程和学生联系SC表

CREATE TABLE SC(
	Sno char(11),
	Cno char(8),
	Score char(6),
	Grade char(2),
	primary key(Sno,Cno),
	foreign key(Sno) references Student(Sno),
	foreign key(Cno) references Course(Cno),
)



insert into dbo.Student(Sno) values('20221001708'),('20221001709'),('20221001710');