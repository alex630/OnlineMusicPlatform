using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//mycodes.net

using System.Data;
using System.Data.SqlClient;

using System.Configuration;

using Model;

namespace DAL
{
    public class T_Manager
    {
        #region 增加

        public bool Add(Model.T_Manager model)
        {

            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("insert into T_Manager([UserName],[PassWord]) values (@username,@password )", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@username", model.UserName);
            cmd.Parameters.AddWithValue("@password", model.PassWord);

            //执行相关SQL语句并返回受影响的行数，若受影响行数大于0，则表示执行成功，否者，执行失败
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Dispose();
                myconn.Dispose();
                return true;

            }
            else
            {
                cmd.Dispose();
                myconn.Dispose();
                return false;
            }
        }

        #endregion 增加


        #region 删除

        public bool Delete(int id)
        {


            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("DELETE T_Manager WHERE Id='"+id+"'", myconn);

            //为SQL语句匹配相关参数，并赋值
            //cmd.Parameters.AddWithValue("@id", model.Id);


            //执行相关SQL语句并返回受影响的行数，若受影响行数大于0，则表示执行成功，否者，执行失败
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Dispose();
                myconn.Dispose();
                return true;

            }
            else
            {
                cmd.Dispose();
                myconn.Dispose();
                return false;
            }
        }

        #endregion 删除



        #region 修改

        public bool Update(Model.T_Manager model)
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlCommand cmd = new SqlCommand("update T_Manager set PassWord=@password where Id=@id", myconn);

            cmd.Parameters.AddWithValue("@password", model.PassWord);
            cmd.Parameters.AddWithValue("@id", model.Id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Dispose();
                myconn.Dispose();

                return true;
            }
            else
            {
                cmd.Dispose();
                myconn.Dispose();

                return false;
            }
        }





        #endregion 修改


        #region 带参查询1
        public bool select(Model.T_Manager model)
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            string username = model.UserName;
            //string password = model.PassWord;

            string str = "SELECT [Id] FROM T_Manager WHERE UserName=@username AND PassWord=@password ";

            SqlCommand cmd = new SqlCommand(str, myconn);

            cmd.Parameters.AddWithValue("@username", model.UserName.ToString());
            cmd.Parameters.AddWithValue("@password", model.PassWord);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            sda.Fill(ds);

            sda.Dispose();

            myconn.Dispose();

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion 带参查询1


        #region 带参查询2
        public DataSet Select(int Id)
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Manager.Id, dbo.T_Manager.UserName, dbo.T_Manager.PassWord FROM dbo.T_Manager where dbo.T_Manager.Id ='" + Id + "'", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Manager");

            sda.Dispose();

            myconn.Dispose();

            return ds;


        }


        #endregion 带参查询2






        #region 不带参查询
        //不带参数查询，默认查询所有记录
        public DataSet Select()
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select [Id],[UserName],[PassWord] from dbo.T_Manager", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Manager");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 不带参查询
    }
}
