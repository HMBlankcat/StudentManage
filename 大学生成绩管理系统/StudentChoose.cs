using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大学生课程学习管理与成绩评价系统
{
    public partial class StudentChoose : Form
    {
        public StudentChoose()
        {
            InitializeComponent();
            Table();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(e.RowIndex);// 在控制台输出行索引
            if (e.RowIndex != -1)
            {
                // 设置当前单元格为指定行的指定列
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 将标签文本设置为所选行的第一列和第二列的值的组合
            label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from dbo.Course";
            IDataReader dc = dao.read(sql);// 执行 SQL 查询，并获取数据读取器
            while (dc.Read())
            {
                // 将查询结果添加到数据表格中的新行
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), 
                    dc[4].ToString(), dc[5].ToString(), dc[6].ToString());


            }
            dc.Close();// 关闭数据读取器
            dao.DaoClose();// 关闭数据读取器和数据库连接
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentChosen stuchosen = new StudentChosen();//新建窗口
            this.Hide();//隐藏当前窗口
            stuchosen.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号

                DialogResult dr = MessageBox.Show("确认选课吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql3 = $"select Ctime from Course where Cno='{id}'";
                    string sql4 = $"select Course.Ctime from Course,SC where SC.Sno='{Data.UID}'and SC.Cno=Course.Cno";
                    Dao dao4 = new Dao();
                    Dao dao3 = new Dao();
                    IDataReader dc4 = dao4.read(sql4);
                    IDataReader dc3 = dao3.read(sql3);
                    string t = "";// 存储课程上课时间的变量
                    int i = 1;// 选课时间冲突标志位
                    while (dc3.Read()) { t = dc3[0].ToString(); }// 遍历查询结果，获取课程上课时间
                    while (dc4.Read())
                    {
                        // 如果已选课程的上课时间与当前课程相同，则将冲突标志位置为0
                        if (dc4[0].ToString() == t)
                            i = 0;
                    }
                    dao4.DaoClose();
                    dao3.DaoClose();
                    if (i == 1)// 如果没有时间冲突
                    {
                        // 更新课程表中的选课人数加1，并在选课表中插入学生选课信息
                        string sql = $"update Course set Pnum=Pnum+1 where Cno='{id}' and Pnum<180";
                        string sql2 = $"insert into dbo.SC(Sno,Cno) values('{Data.UID}','{id}')";
                        Dao dao = new Dao();
                        Dao dao2 = new Dao();
                        if (dao.Execute(sql) > 0 && dao2.Execute(sql2) > 0)// 如果更新和插入操作成功
                        {
                            MessageBox.Show("选课成功");// 弹出选课成功消息框
                            Table();// 刷新课程表格
                        }
                        else
                        {
                            MessageBox.Show("选课失败" + sql);// 弹出选课失败消息框
                        }
                        dao.DaoClose();
                        dao2.DaoClose();
                    }
                    else MessageBox.Show("选课时间冲突！");
                }
            }
            catch
            {
                MessageBox.Show("请先选中要选择的课程！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void StudentChoose_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
