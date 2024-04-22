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
    public partial class AdminTeaManClaAdd : Form
    {
        public AdminTeaManClaAdd()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminTeaManClaAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox2.Text != "")
            {

                Dao dao = new Dao();
                string sql = $"insert into CRT values('{textBox1.Text}','{textBox4.Text}','{textBox2.Text}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else MessageBox.Show("添加失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }
    }
}
