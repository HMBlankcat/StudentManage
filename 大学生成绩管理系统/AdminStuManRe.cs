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
    public partial class AdminStuManRe : Form
    {
        string ID = "";
        public AdminStuManRe(string id, string Sname, string Ssex, string Sclass)
        {
            InitializeComponent();
            ID = textBox1.Text = id;
            textBox2.Text = Sname;
            textBox3.Text = Ssex;
            textBox4.Text = Sclass;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                Dao dao = new Dao();
                string sql = $"update Student set Sno='{textBox1.Text}',Sname='{textBox2.Text}',Ssex='{textBox3.Text}',Sclass='{textBox4.Text}' where Sno='{ID}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else MessageBox.Show("修改失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void AdminStuManRe_Load(object sender, EventArgs e)
        {

        }
    }
}
