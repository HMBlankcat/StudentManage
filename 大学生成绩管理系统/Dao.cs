using System.Data.SqlClient;


namespace 大学生课程学习管理与成绩评价系统
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=SymboliRudolf\MSSQLSERVER02;Initial Catalog=app_student_course;Integrated Security=SSPI";    //数据库连接字符串
            sc = new SqlConnection(str);  //创建数据库连接对象
            sc.Open();  //打开数据库
            return sc;  //返回数据库连接对象
        
        
        }

        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)  //更新
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)   //读取
        {
            return command(sql).ExecuteReader();
        }

        public void DaoClose()  //关闭
        {
            sc.Close();
        }
    }


}
