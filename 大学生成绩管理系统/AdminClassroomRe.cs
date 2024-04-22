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
    public partial class AdminClassroomRe : Form
    {
        string ID = "";
        public AdminClassroomRe(string a1,string a2,string a3)
        {
            InitializeComponent();
            ID = textBox1.Text = a1;
            textBox4.Text = a2;
            textBox2.Text = a3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" )
            {

                Dao dao = new Dao();
                string sql = $"update Classroom set Rno='{textBox1.Text}',Rfloor='{textBox4.Text}',Rlimit='{textBox2.Text}' where Rno='{ID}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else MessageBox.Show("修改失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminClassroomRe_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
