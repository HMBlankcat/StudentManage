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
    public partial class StudentTotal : Form
    {
        public StudentTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentPersonalInformation stuperinf = new StudentPersonalInformation();//新建窗口
            this.Hide();//隐藏当前窗口
            stuperinf.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentChoose stucho = new StudentChoose();//新建窗口
            this.Hide();//隐藏当前窗口
            stucho.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentGrade stugra = new StudentGrade();//新建窗口
            this.Hide();//隐藏当前窗口
            stugra.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentRoad sturoa = new StudentRoad();//新建窗口
            this.Hide();//隐藏当前窗口
            sturoa.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void StudentTotal_Load(object sender, EventArgs e)
        {

        }
    }
}
