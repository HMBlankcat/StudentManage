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
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")//所有信息都填充完毕
            {

                Dao dao = new Dao();//连接数据库
                string sql = $"update Student set Spassword='{textBox3.Text}',Sname='{textBox4.Text}',Ssex='{textBox2.Text}',Sbirth='{textBox5.Text}',Dno='{textBox6.Text}',Sclass='{textBox7.Text}'where Sno='{textBox1.Text}'";
                //输sql指令
                int n = dao.Execute(sql);//获取搜索到的数目
                if (n > 0)
                {
                    MessageBox.Show("注册成功");
                }
                else MessageBox.Show("注册失败，请输入正确的学号！");//输入的学号不在本校的数据库中
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
