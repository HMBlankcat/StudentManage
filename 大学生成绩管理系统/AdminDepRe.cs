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
    public partial class AdminDepRe : Form
    {
        string ID = "";
        public AdminDepRe(string a1, string a2, string a3)
        {
            InitializeComponent();
            ID = textBox1.Text = a1;
            textBox4.Text = a2;
            textBox2.Text = a3;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "")
            {

                Dao dao = new Dao();
                string sql = $"update Department set Dno='{textBox1.Text}',Dname='{textBox4.Text}',Dphone='{textBox2.Text}'where Dno='{ID}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else MessageBox.Show("修改失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }
    }
}
