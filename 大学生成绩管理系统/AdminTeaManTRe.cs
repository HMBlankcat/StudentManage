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
    public partial class AdminTeaManTRe : Form
    {
        string ID = "";

        public AdminTeaManTRe(string Tno,string Tname,string Tzc,string Tphone,string Dno)
        {
            InitializeComponent();
            ID = textBox1.Text = Tno;
            textBox2.Text = Tname;
            textBox3.Text = Tzc;
            textBox4.Text = Tphone;
            textBox5.Text = Dno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {

                Dao dao = new Dao();
                string sql = $"update Teacher set Tno='{textBox1.Text}',Tname='{textBox2.Text}',Tzc='{textBox3.Text}',Tphone='{textBox4.Text}',Dno='{textBox5.Text}' where Tno='{ID}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else MessageBox.Show("修改失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void AdminTeaManTRe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
