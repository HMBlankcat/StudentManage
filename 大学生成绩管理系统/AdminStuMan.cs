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
    public partial class AdminStuMan : Form
    {
        public AdminStuMan()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminStuMan_Load(object sender, EventArgs e)
        {
            Table();

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧属性
            Dao dao = new Dao();
            string sql = "select Student.* from Student,Class where Student.Sclass=Class.Classno ";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();//清空旧属性
                Dao dao = new Dao();
                string sql = $"select Student.* ,Department.Dno from Student,Class,Department where Student.Sclass=Class.Classno and Sno='{textBox1.Text}'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());

                }
                dc.Close();
                dao.DaoClose();
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text == "")
            {
                dataGridView1.Rows.Clear();//清空旧属性
                Dao dao = new Dao();
                string sql = $"select Student.* ,Department.Dno from Student,Class,Department where Student.Sclass=Class.Classno and Student.Dno='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());

                }
                dc.Close();
                dao.DaoClose();
            }
            else if (textBox2.Text != "" && textBox3.Text != "")
            {
                dataGridView1.Rows.Clear();//清空旧属性
                Dao dao = new Dao();
                string sql = $"select Student.* ,Department.Dno from Student,Class,Department where Student.Sclass='{textBox3.Text}' and Student.Sclass=Class.Classno and Student.Dno='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());

                }
                dc.Close();
                dao.DaoClose();
            }
            else MessageBox.Show("系输入不允许为空！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminStuManClass admstumanc = new AdminStuManClass();//新建窗口
            this.Hide();//隐藏当前窗口
            admstumanc.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminStuManAdd admstumanadd = new AdminStuManAdd();//新建窗口
            this.Hide();//隐藏当前窗口
            admstumanadd.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号
                string Sname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string Ssex = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string Sclass = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                AdminStuManRe admstumanre = new AdminStuManRe(id,Sname,Ssex,Sclass);//新建窗口
                this.Hide();//隐藏当前窗口
                admstumanre.ShowDialog();//独立显示新窗口
                this.Show();//显示当前窗口
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
                    string sql = $"delete from Student where Sno='{id}'";
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
