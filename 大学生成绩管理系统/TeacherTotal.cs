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
    public partial class TeacherTotal : Form
    {
        public TeacherTotal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeacherPersonalInformation teacherperinf = new TeacherPersonalInformation();//新建窗口
            this.Hide();//隐藏当前窗口
            teacherperinf.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherCourse teachercourse = new TeacherCourse();//新建窗口
            this.Hide();//隐藏当前窗口
            teachercourse.ShowDialog();//独立显示新窗口
            this.Show();//显示当前窗口
        }

        private void TeacherTotal_Load(object sender, EventArgs e)
        {

        }
    }
}
