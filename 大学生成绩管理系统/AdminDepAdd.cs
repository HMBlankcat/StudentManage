﻿using System;
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
    public partial class AdminDepAdd : Form
    {
        public AdminDepAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != " " && textBox4.Text != " " )
            {

                Dao dao = new Dao();
                string sql = $"insert into Department values('{textBox1.Text}','{textBox4.Text}','{textBox2.Text}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else MessageBox.Show("添加失败");
            }
            else MessageBox.Show("输入不允许为空！");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDepAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
