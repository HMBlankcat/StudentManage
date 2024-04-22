
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
	Pnum int,--已选人数
	Rno char(10),--上课教室
	Ctime char(30),--上课时间
	foreign key(Rno) references Classroom(Rno)
)

go

-- 创建学生表
CREATE TABLE Student(
	Sno char(11) primary key,
	Sname char(20) ,
	Ssex char(2) ,
	Sbirth char(10) ,
	Sclass char(10),
	Dno char(2),
	Spassword char(16) ,
	foreign key(Dno) references Department(Dno),
	foreign key(Sclass) references Class(Classno)
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
	Climit int,
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
	Score float,
	Grade char(2),
	primary key(Sno,Cno),
	foreign key(Sno) references Student(Sno),
	foreign key(Cno) references Course(Cno),
)


insert into dbo.Teacher(Tno) values('20221000'),('20221001');
insert into dbo.Classroom(Rno,Rfloor,Rlimit) values('北综楼101','1','180'),('北综楼102','1','180');
insert into dbo.CRT(Cno,Tno,Rno) values('1','20221000','北综楼101'),('2','20221000','北综楼102');
insert into dbo.Student(Sno) values('20221001708'),('20221001709'),('20221001710');

insert into dbo.Department(Dno,Dname,Dphone) values('1','李四光学院','123456'),('2','地理与信息工程学院','654321');

insert into dbo.Teacher(Tno) values('20220001'),('20221002'),('20221003');
insert into dbo.Class(Classno,Dno) values('201221','1'),('201222','1');
USE app_student_course;
select * from Student;
insert into dbo.Course values('1','时空数据库','专业必修','2.5','0','北综楼101','112'),('2','时空数据库课程设计','专业必修','2','0','北综楼102','134');
--delete from dbo.Course where Cno = '1' or Cno ='2';
update dbo.SC set Score=95 where Cno='2';
select * from SC;

use app_student_course;
select * from Course;
select * from SC;