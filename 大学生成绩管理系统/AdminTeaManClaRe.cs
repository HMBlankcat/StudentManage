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
    public partial class AdminTeaManClaRe : Form
    {
        string CBianhao = "";
        string TBianhao = "";
        string RBianhao = "";

        public AdminTeaManClaRe(string CNO,string TNO,string RNO)
        {
            InitializeComponent();
            CBianhao = textBox1.Text = CNO;
            TBianhao = textBox4.Text = TNO;
            RBianhao = textBox2.Text = RNO;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminTeaManClaRe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "")
            {

                Dao dao = new Dao();
                string sql = $"update CRT set Cno='{textBox1.Text}',Tno='{textBox4.Text}',Rno='{textBox2.Text}' where Cno='{CBianhao}' and Tno='{TBianhao}'";
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
