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
    public partial class AdminTeaManClass : Form
    {
        public AdminTeaManClass()
        {
            InitializeComponent();
        }

        private void AdminTeaManClass_Load(object sender, EventArgs e)
        {
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧属性
            Dao dao = new Dao();
            string sql = "select Course.Cno ,Course.Cname,Teacher.Tno,Teacher.Tname ,Classroom.Rno from Course,Teacher,CRT,Classroom where Course.Cno=CRT.Cno and Teacher.Tno=CRT.Tno and Classroom.Rno=CRT.Rno";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminTeaManClaAdd admTEAmanadd = new AdminTeaManClaAdd();//新建窗口
            this.Hide();//隐藏当前窗口
            admTEAmanadd.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号
            string a2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string a3 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AdminTeaManClaRe admTEAmanre = new AdminTeaManClaRe(a1,a2,a3);//新建窗口
            this.Hide();//隐藏当前窗口
            admTEAmanre.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string CBianhao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string TBianhao = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //获取编号

                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from CRT where Cno='{CBianhao}' and Tno='{TBianhao}'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
