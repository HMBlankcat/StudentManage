
--����Sqlserver���ݿ�,��
-- ԭʼ�����������ĵ�ʱ����뵽SQL server���ݿ��л������������,�ڲ�������ǰ��N���

IF DB_ID(N'app_student_course') IS NULL
CREATE DATABASE app_student_course;
GO
USE app_student_course;
go

-- ��������Ա��

CREATE TABLE table_admin (
	id char(40) primary key , --���� id
	username char(40) , --�û���
	password char(20) , --����
	name char(30) , --����
	telephone char(11) --�绰����
)
go
-- ����һ����ʼ����Ա�û�����
insert into table_admin(id,username,password) values('20001001000','123456','123456');

go
--����ϵ��
CREATE TABLE Department(
	Dno char(2) primary key,
	Dname char(20) UNIQUE NOT NULL,
	Dphone char(11) UNIQUE

)

-- �������ұ�
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

--�����γ̱�
CREATE TABLE Course(
	Cno char(8) primary key,--�γ̱��
	Cname char(20) ,--�γ�����
	Ctype char(8),--�γ�����
	Ccredit float,--�γ�ѧ��
	Pnum char(5),--��ѡ����
	Rno char(10),--�Ͽν���
	Ctime char(30),--�Ͽ�ʱ��
)

go

-- ����ѧ����
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
-- ������ʦ��

create table Teacher(
	 Tno char(8) primary key ,  -- ����
     Tname char(20)  ,  -- ����
     Tzc char(6)  ,  -- ְ��
     Tphone char(11)  ,  -- �绰
	 Dno char(2),
	 TPassword char(16) ,
	 foreign  key(Dno) references Department(Dno)
)

go
--����CRT��
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

--�����γ̺�ѧ����ϵSC��

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