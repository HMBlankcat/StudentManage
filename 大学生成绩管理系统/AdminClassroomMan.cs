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
    public partial class AdminClassroomMan : Form
    {
        public AdminClassroomMan()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 在标签中显示选定行的第一个单元格的值
            label7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table();    // 调用刷新方法
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧属性
            Dao dao = new Dao();
            string sql = "select * from Classroom";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();//清空旧属性
                Dao dao = new Dao();
                string sql = $"select * from Classroom where Classroom.Rno='{textBox1.Text}'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());

                }
                dc.Close();
                dao.DaoClose();
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void AdminClassroomMan_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminClassroomZY adminclazy = new AdminClassroomZY();
            this.Hide();
            adminclazy.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminClassroomAdd adminclaADD = new AdminClassroomAdd();
            this.Hide();
            adminclaADD.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            try
            {
                string a1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号
                string a2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string a3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                AdminClassroomRe adminclaRe = new AdminClassroomRe(a1,a2,a3);
                this.Hide();
                adminclaRe.ShowDialog();
                this.Show();
            }
            catch
            {
                MessageBox.Show("error", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号

                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from Classroom where Rno='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的记录！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
