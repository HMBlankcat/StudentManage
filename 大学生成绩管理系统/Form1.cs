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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //添加CB类型
            this.CBUserType.Items.Add("学生");
            this.CBUserType.Items.Add("教师");
            this.CBUserType.Items.Add("管理员");
            this.CBUserType.SelectedIndex = 0;
            TBpassword.PasswordChar = '●';

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //点击登录
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TBaccount.Text != null && TBpassword.Text != null)
            {
                login();
            }
            else
            {
                MessageBox.Show("账号和密码不能为空!");
            }
        }

        public Boolean login()
        {
            if(CBUserType.SelectedItem.ToString() == "学生")
            {
                Dao dao = new Dao();//连接数据库
                string sql = "select * from Student where Sno='" + TBaccount.Text + "' and Spassword='" + TBpassword.Text + "'";//输指令：选择Student表中同时满足Sno=用户名的内容和Spassword=文本框2的内容
                IDataReader dc = dao.read(sql);//读取筛选结果
                if (dc.Read())//逐条读取数据
                {
                    Data.UID = dc["Sno"].ToString();//用全局变量存储账号
                    Data.UName = dc["Sname"].ToString();//用全局变量存储姓名
                    MessageBox.Show("登陆成功");
                    StudentTotal student = new StudentTotal();//新建窗口
                    this.Hide();//隐藏当前窗口
                    student.ShowDialog();//独立显示新窗口
                    this.Show();//显示当前窗口
                    dao.DaoClose();//关闭数据库连接
                    return true;
                }
                else//数据库中没有相符记录
                {
                    MessageBox.Show("登陆失败");
                    dao.DaoClose();//关闭数据库连接
                    return false;
                }
            }
            else if (CBUserType.SelectedItem.ToString() == "教师")//教师
            {
                Dao dao = new Dao();//连接数据库
                string sql = "select * from Teacher where Tno='" + TBaccount.Text + "' and TPassword='" + TBpassword.Text + "'";
                //输指令：选择Teacher表中同时满足Tno=文本框1的内容和TPassword=文本框2的内容
                IDataReader dc = dao.read(sql);//读取筛选结果
                if (dc.Read())//逐条读取数据
                {
                    Data.UID = dc["Tno"].ToString();//用全局变量存储账号
                    Data.UName = dc["Tname"].ToString();//用全局变量存储姓名
                    MessageBox.Show("登陆成功");
                    TeacherTotal teacher = new TeacherTotal();//新建窗口
                    this.Hide();//隐藏当前窗口
                    teacher.ShowDialog();//独立显示新窗口
                    this.Show();//显示当前窗口
                    dao.DaoClose();//关闭数据库连接
                    return true;
                }
                else//数据库中没有相符记录
                {
                    MessageBox.Show("登陆失败");
                    dao.DaoClose();//关闭数据库连接
                    return false;
                }
            }
            else if (CBUserType.SelectedItem.ToString() == "管理员")//管理员
            {
                Dao dao = new Dao();//连接数据库
                string sql = "select * from dbo.table_admin where id='" + TBaccount.Text + "' and password='" + TBpassword.Text + "'";
                //输指令：选择table_admin表中同时满足username=文本框1的内容和password=文本框2的内容
                IDataReader dc = dao.read(sql);//读取筛选结果
                if (dc.Read())//逐条读取数据
                {
                    Data.UID = dc["id"].ToString();//用全局变量存储账号
                    MessageBox.Show("登陆成功");
                    AdminTotal admin = new AdminTotal();//新建窗口
                    this.Hide();//隐藏当前窗口
                    admin.ShowDialog();//独立显示新窗口
                    this.Show();//显示当前窗口
                    dao.DaoClose();//关闭数据库连接
                    return true;
                }
                else//数据库中没有相符记录
                {
                    MessageBox.Show("登陆失败");
                    dao.DaoClose();//关闭数据库连接
                    return false;
                }
            }
            else
            {
                return false;
            }    
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            if (CBUserType.SelectedItem.ToString() == "学生")//跳转学生注册
            {
                StudentRegister stureg = new StudentRegister();
                this.Hide();
                stureg.ShowDialog();
                this.Show();
            }
            else if (CBUserType.SelectedItem.ToString() == "教师")//跳转教师注册
            {
                TeacherRegister teareg = new TeacherRegister();
                this.Hide();
                teareg.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("管理员不可注册!");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
