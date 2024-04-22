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
    public partial class AdminStuManClass : Form
    {
        public AdminStuManClass()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminStuManClass_Load(object sender, EventArgs e)
        {
            Table();
        }
        public void Table(string id = "")
        {
            dataGridView1.Rows.Clear();//清空旧属性
            Dao dao = new Dao();
            string sql = "";
            if (id == "")
            {
                sql = $"select Student.Sno,Student.Sname from Student,SC where Student.Sno=SC.Sno";
            }
            else sql = $"select Student.Sno ,Student.Sname from Student,SC where Student.Sno=SC.Sno and Student.Sno='{id}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                Dao dao2 = new Dao();
                double Xuefenji = 0;
                double Junji = 0;
                double ZongXueFen = 0;
                string sql2 = $"select Course.Cno,Course.Cname,Course.Ccredit,Course.Ctype,SC.Score from Course,SC where SC.Sno='{dc[0]}' and SC.Cno=Course.Cno ";
                IDataReader dc2 = dao2.read(sql2);
                while (dc2.Read())
                {
                    string Rank = "";
                    double JiDian;
                    double Xuefen = double.Parse(dc2[2].ToString());
                    if (dc2[4].ToString() == "")
                    {
                        JiDian = 0;
                        ZongXueFen += Xuefen;
                        Rank = "未结课";
                        continue;
                    } //解决没出成绩的时候Score1读到""产生报错的问题
                    int Score1 = int.Parse(dc2[4].ToString());

                    if (Score1 >= 90 && Score1 <= 100) { Rank = "A"; JiDian = 4.0; }
                    else if (Score1 >= 85 && Score1 <= 89) { Rank = "A-"; JiDian = 3.7; }
                    else if (Score1 >= 82 && Score1 <= 84) { Rank = "B+"; JiDian = 3.3; }
                    else if (Score1 >= 78 && Score1 <= 81) { Rank = "B"; JiDian = 3.0; }
                    else if (Score1 >= 75 && Score1 <= 77) { Rank = "B-"; JiDian = 2.7; }
                    else if (Score1 >= 71 && Score1 <= 74) { Rank = "C+"; JiDian = 2.3; }
                    else if (Score1 >= 66 && Score1 <= 70) { Rank = "C"; JiDian = 2.0; }
                    else if (Score1 >= 62 && Score1 <= 65) { Rank = "C-"; JiDian = 1.7; }
                    else if (Score1 >= 61 && Score1 <= 60) { Rank = "D"; JiDian = 1.3; }
                    else if (Score1 == 0) { Rank = "未结课"; JiDian = 0; Xuefen = 0; }
                    else { Rank = "不及格"; JiDian = 0; }

                    if (dc2[3].ToString() == "基础必修")
                    {
                        Xuefenji = JiDian * 1.2;
                    }
                    else if (dc2[3].ToString() == "专业必修")
                    {
                        Xuefenji = JiDian * 1.1;
                    }
                    else if (dc2[3].ToString() == "专业选修")
                    {
                        Xuefenji = JiDian * 1.0;
                    }
                    Junji += Xuefen * Xuefenji;
                    ZongXueFen += Xuefen;
                }
                dc2.Close();
                dao2.DaoClose();
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), (Junji / ZongXueFen).ToString(), ZongXueFen.ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Table(textBox1.Text.ToString());
                if (dataGridView1.Rows.Count == 0)
                    MessageBox.Show("该学生不存在或未选课。");
            }
            else { MessageBox.Show("输入不能为空！"); }
        }
    }
}
