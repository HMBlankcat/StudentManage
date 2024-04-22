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
    public partial class AdminCouRe : Form
    {
        string ID = "";

        public AdminCouRe(string a1, string a2, string a3, string a4,string a6, string a7)
        {
            InitializeComponent();
            ID = textBox1.Text = a1;
            textBox2.Text = a2;
            textBox3.Text = a3;
            textBox4.Text = a4;
            textBox7.Text = a6;
            textBox6.Text = a7;
        }

        private void AdminCouRe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != " " && textBox3.Text != " " && textBox4.Text != " " && textBox7.Text != " " && textBox6.Text != " ")
            {

                Dao dao = new Dao();
                string sql = $"update Course set Cno='{textBox1.Text}',Cname='{textBox2.Text}',Ctype='{textBox3.Text}',Ccredit='{textBox4.Text}',Ctime='{textBox6.Text}',Rno='{textBox7.Text}' where Cno='{ID}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else MessageBox.Show("修改失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
