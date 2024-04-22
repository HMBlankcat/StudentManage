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
    public partial class TeacherCourse : Form
    {
        public TeacherCourse()
        {
            InitializeComponent();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select Course.Cno ,Course.Cname,Teacher.Tno,Teacher.Tname from Course,Teacher,CRT where Teacher.Tno='{Data.UID}' and Teacher.Tno=CRT.Tno and Course.Cno=CRT.Cno";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());


            }
            dc.Close();
            dao.DaoClose();// 关闭数据读取器和数据库连接
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TeacherCourse_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
             label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号
                TeachercourseManage TeachercouMan = new TeachercourseManage(id);
                this.Hide();
                TeachercouMan.ShowDialog();
                this.Show();
            }
            catch
            {
                MessageBox.Show("请先选中要选择的课程！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
