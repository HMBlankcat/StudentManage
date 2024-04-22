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
    public partial class TeachercourseManage : Form
    {
        public TeachercourseManage()
        {
            InitializeComponent();
        }
        string ID = "";
        public TeachercourseManage(string id)
        {
            InitializeComponent();
            ID = id;

        }

        public void Table()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select Course.Cno,Course.Cname,Course.Ccredit,Course.Ctype,Student.Sno,Student.Sname,SC.Score from Course,Student,SC,CRT where CRT.Tno='{Data.UID}'and CRT.Cno='{ID}'and CRT.Cno=Course.Cno and SC.Cno=Course.Cno and SC.Sno=Student.Sno";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(),
                    dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeachercourseManage_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + ' ' +dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Studentid = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string Courseid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号
                if (textBox1.Text != "")
                {
                    Dao dao = new Dao();
                    string sql = $"update SC set Score='{textBox1.Text}'where Sno='{Studentid}'and Cno='{Courseid}'";
                    int n = dao.Execute(sql);
                    if (n > 0)
                    {
                        MessageBox.Show("上传成绩成功");
                    }
                    else MessageBox.Show("上传成绩失败");
                }
                else MessageBox.Show("输入不允许为空或其他字符！");

            }
            catch
            {
                MessageBox.Show("请先选中要选择的课程！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
