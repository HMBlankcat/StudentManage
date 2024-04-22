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
    public partial class StudentChosen : Form
    {
        public StudentChosen()
        {
            InitializeComponent();
        }
        public void ChosenView()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select Course.* from Course,SC where SC.Sno='{Data.UID}'and SC.Cno=Course.Cno";//从SC和Course中读取该学生选择恶堕课程
            
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(),
                    dc[4].ToString(), dc[5].ToString(), dc[6].ToString());


            }
            dc.Close();
            dao.DaoClose();// 关闭数据读取器和数据库连接
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentChosen_Load(object sender, EventArgs e)
        {
            ChosenView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChosenView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号

                DialogResult dr = MessageBox.Show("确认退课吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"update Course set Pnum=Pnum-1 where Cno='{id}'";
                    string sql2 = $"delete from SC where Cno='{id}'and Sno='{Data.UID}'";
                    Dao dao = new Dao();
                    Dao dao2 = new Dao();
                    if (dao.Execute(sql) > 0 && dao2.Execute(sql2) > 0)
                    {
                        MessageBox.Show("退课成功");
                        ChosenView();
                    }
                    else
                    {
                        MessageBox.Show("退课失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要选择的课程！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
