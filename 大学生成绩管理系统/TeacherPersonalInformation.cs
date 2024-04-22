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
    public partial class TeacherPersonalInformation : Form
    {
        public TeacherPersonalInformation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeacherPersonalInformation_Load(object sender, EventArgs e)
        {
            PersonInfo();//在加载窗口时修改label对应的个人信息
        }
        public void PersonInfo()
        {
            Dao dao = new Dao();
            string sql = $"select dbo.Teacher.*,Dno from dbo.Teacher where dbo.Teacher.Tno='{Data.UID}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                label8.Text = dc[0].ToString();
                label9.Text = dc[1].ToString();
                label10.Text = dc[2].ToString();
                label13.Text = dc[3].ToString();
                label12.Text = dc[4].ToString();


            }
            dc.Close();
            dao.DaoClose();// 关闭数据读取器和数据库连接
        }
    }
}
