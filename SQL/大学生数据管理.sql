
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
	Pnum int,--��ѡ����
	Rno char(10),--�Ͽν���
	Ctime char(30),--�Ͽ�ʱ��
	foreign key(Rno) references Classroom(Rno)
)

go

-- ����ѧ����
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
	Climit int,
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
	Score float,
	Grade char(2),
	primary key(Sno,Cno),
	foreign key(Sno) references Student(Sno),
	foreign key(Cno) references Course(Cno),
)


insert into dbo.Teacher(Tno) values('20221000'),('20221001');
insert into dbo.Classroom(Rno,Rfloor,Rlimit) values('����¥101','1','180'),('����¥102','1','180');
insert into dbo.CRT(Cno,Tno,Rno) values('1','20221000','����¥101'),('2','20221000','����¥102');
insert into dbo.Student(Sno) values('20221001708'),('20221001709'),('20221001710');

insert into dbo.Department(Dno,Dname,Dphone) values('1','���Ĺ�ѧԺ','123456'),('2','��������Ϣ����ѧԺ','654321');

insert into dbo.Teacher(Tno) values('20220001'),('20221002'),('20221003');
insert into dbo.Class(Classno,Dno) values('201221','1'),('201222','1');
USE app_student_course;
select * from Student;
insert into dbo.Course values('1','ʱ�����ݿ�','רҵ����','2.5','0','����¥101','112'),('2','ʱ�����ݿ�γ����','רҵ����','2','0','����¥102','134');
--delete from dbo.Course where Cno = '1' or Cno ='2';
update dbo.SC set Score=95 where Cno='2';
select * from SC;

use app_student_course;
select * from Course;
select * from SC;