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
    public partial class AdminCouAdd : Form
    {
        public AdminCouAdd()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminCouAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != " " && textBox3.Text != " " && textBox4.Text != " " && textBox7.Text != " " && textBox6.Text != " ")
            {

                Dao dao = new Dao();
                string sql = $"insert into Course values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','0','{textBox7.Text}','{textBox6.Text}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else MessageBox.Show("添加失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            BeiZongLou beizong = new BeiZongLou();
            beizong.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = Data.Classroom.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
