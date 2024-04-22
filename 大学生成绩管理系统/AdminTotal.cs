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
    public partial class AdminTotal : Form
    {
        public AdminTotal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminTeaMan admtea = new AdminTeaMan();//新建窗口
            this.Hide();//隐藏当前窗口
            admtea.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void AdminTotal_Load(object sender, EventArgs e)
        {
            label2.Text = Data.UID ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminStuMan admstu = new AdminStuMan();//新建窗口
            this.Hide();//隐藏当前窗口
            admstu.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminCouMan admcou = new AdminCouMan();//新建窗口
            this.Hide();//隐藏当前窗口
            admcou.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminClassroomMan admcla = new AdminClassroomMan();//新建窗口
            this.Hide();//隐藏当前窗口
            admcla.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDepMan admdep = new AdminDepMan();//新建窗口
            this.Hide();//隐藏当前窗口
            admdep.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }
    }
}
