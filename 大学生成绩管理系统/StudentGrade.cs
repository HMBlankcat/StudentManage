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
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentGrade_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            double Xuefenji = 0;// 学分绩
            double Junji = 0;// 累计绩点
            double ZongXueFen = 0;// 总学分
            string sql = $"select Course.Cno,Course.Cname,Course.Ccredit,Course.Ctype," +
                $"SC.Score from Course,SC where SC.Sno='{Data.UID}' and SC.Cno=Course.Cno ";// 查询学生已修课程信息的 SQL 语句
            IDataReader dc = dao.read(sql);// 执行 SQL 查询，并获取数据读取器
            while (dc.Read())
            {
                string Rank = "";// 成绩等级
                double JiDian;// 绩点
                double Xuefen = double.Parse(dc[2].ToString());// 课程学分
                // 若成绩为空
                if (dc[4].ToString() == "")
                {
                    JiDian = 0;
                    ZongXueFen += Xuefen;
                    Rank = "未结课";
                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), Rank, JiDian, Xuefenji);
                    continue;// 添加数据到表格，并跳过后续代码
                } //解决没出成绩的时候Score1读到""产生报错的问题
                int Score1 = int.Parse(dc[4].ToString());// 课程成绩

                // 根据成绩确定等级和绩点
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

                // 根据课程类型确定学分绩
                if (dc[3].ToString() == "基础必修")
                {
                    Xuefenji = JiDian * 1.2;
                }
                else if (dc[3].ToString() == "专业必修")
                {
                    Xuefenji = JiDian * 1.1;
                }
                else if (dc[3].ToString() == "专业选修")
                {
                    Xuefenji = JiDian * 1.0;
                }
                // 更新累计绩点和总学分
                Junji += Xuefen * Xuefenji;
                ZongXueFen += Xuefen;

                // 添加数据到表格
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), Rank, JiDian, Xuefenji);
            }
            // 若总学分为0，则显示成绩尚未公布的提示信息，否则显示平均绩点
            if (ZongXueFen == 0)
            {
                label2.Text = "成绩尚未公布，请耐心等待";
            }
            else label2.Text = (Junji / ZongXueFen).ToString();

            dc.Close();// 关闭数据读取器
            dao.DaoClose(); // 关闭数据库连接
        }
    }
}
