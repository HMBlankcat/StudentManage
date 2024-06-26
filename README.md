# StudentManage
based on c# .net and SQL Server
数据库课程设计指导书
一、课程设计的目的
1、检验学生对所学的DBMS理论的理解程度；
2、培养学生利用数据模型和E_R工具分析现实世界的能力；
3、锻炼学生使用软件工程的思想进行系统软件和应用软件开发能力；
4、加强学生能够利用现在主流的DBMS产品（如SQL Server、Oracle）开发应用系统的能力。
二、课程设计要求
为了能够达到课程设计的目的，因此学生需要做到以下几点：
1、	每次上机前做好充分的准备工作，熟悉课本内容，查阅资料，对课程实习的内容进行方案的预设计，写出源程序的代码；
2、	课程设计的重点在于利用数据库设计步骤和方法，制定E-R模型、数据流图、数据字典等，并通过模式分解，确定范式，避免冗余及操作不一致，从而评估数据模型的合理性。
3、	建立关系数据库必须采用SQL语言实现，不允许用数据库可视化界面实现。
4、	开发语言不限，可采用C++、C#、Java等主流设计语言，可设计C/S或B/S架构的系统。
5、	充分利用上机时间完成源程序代码的输入、调试及优化；
6、	实习结束后，按照指导书附件中“实习报告格式”的要求撰写出课程设计报告。
7、	按题目要求进行设计实现，不旷课、不迟到、不早退、遵守机房的规定，爱护机房设备。
三、课程设计时间及考核办法
1、	实习结束时指导老师根据系统设计及代码演示给出实习成绩。
2、	根据实习报告和演示给出综合成绩。
四、课程设计题目及要求
需求包含但不限于以下需求，同学们可根据自己对现实语义的理解，设计更丰富和完善的系统功能设计和数据库模型。
1.	关系数据库安装及操作
根据《上机参考》的文档要求，熟悉了解关系数据库的安装、配置、建库及SQL的操作，并完成相关练习。
2.	空间数据库设计
设计点和线的空间数据结构，用线描述教学楼及教室的分布图，用点和线描述学校的道路网，可自定义坐标系统。
3.	大学生课程学习管理与成绩评价系统
设计并开发一套完整的在校大学生学习的综合管理系统，其中可包括以下几个模块：
（一）选课管理：该系统包括教师、学生、系、课程和教室等信息，基本情况如下：
1.	教师有工作证号、姓名、职称、电话等；学生有学号、姓名、性别、出生年月等；
2.	系有系代号、系名和系办公室电话等；课程有课序号、课名、课程类型、学分、上课时间及名额等。
3.	课程类型分为基础必修、专业必修和选修三个类型；
4.	教室有教室号码、层数、容纳人数、教室的空间位置等信息。开课时要把课程和教室进行关联，可通过交互方式将课程和教室进行挂接；
5.	每个学生都属于一个班，每个班都属于一个系，每个教师也都属于一个系。一名教师可以教多门课，一门课可以有几位主讲老师，一名同学可以选多门课，一门课可被若干同学选中，每门课的学生人数有上限。一名同学选中的课若已学完，应该记录有相应成绩。本单位学生、教师可能存在重名，工作证号、学号可以作为标识。
6.	教学系统主要提供数据维护、选课和信息查询。其中常见的查询有：系统中各对象的基本信息查询。 查询指定班、系的学生信息（名单、人数等）。查询学生的成绩、学分情况。查询教师授课情况和学生选课情况等。

（二）成绩评价：设计学生的绩点数据模型，每门课程分数对应有不同的绩点，设置好绩点计算规则，系统能够自动对参加学习的所有学生进行绩点统计和排名，能够按照班级对学生的平均绩点情况进行统计输出和分析。
绩点规则如下：
成绩	等级	绩点
90-100	A	4.0
85-89	A-	3.7
82-84	B+	3.3
78-81	B	3.0
75-77	B-	2.7
71-74	C+	2.3
66-70	C	2.0
62-65	C-	1.7
60-61	D	1.3
补考60	D-	1.0
60以下	F	0
课程加以课程权重系数：基础必修：1.2；专业必修：1.1；选修：1.0。
课程学分绩点 = 课程权重系数×绩点
学生平均绩点=(课程学分1×课程学分绩点+课程学分2×课程学分绩点+......+课程学分n×课程学分绩点)/(课程学分1+课程学分2+......+课程学分n)

（三）绘制平面图：利用绘笔画出公教一的教室平面图，并且画出学校的道路网，以点和线要素形式存储。
（四） 选择教室：录入课程信息时可通过交互平面图选择课程教室。并且可以通过选定课程，自动跳转所在教室位置。
（五）教室指引：完成学校各教学设施的地图查询，同时能够为选课的同学提供路径指引，给出从宿舍到教室的最短路径。

注：可把本班同学的课程成绩录入系统中，验证系统运行结果。
五、报告的要求和格式
严格按照下面的内容格式要求进行编写。

