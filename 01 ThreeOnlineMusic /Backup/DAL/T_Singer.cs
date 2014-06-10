using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using System.Configuration;

using Model;

namespace DAL
{
    public class T_Singer
    {
        #region 增加

        public bool Add(Model.T_Singer model)
        {

            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("insert into T_Singer([Name],[Sex]) values (@name,@sex)", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@name", model.Name);
            cmd.Parameters.AddWithValue("@sex", model.Sex);

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

        public bool Delete(Model.T_Singer model)
        {


            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("delete from T_Singer where Id=@id;delete from T_Music where SingerId=@singerid", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@id", model.Id);
            cmd.Parameters.AddWithValue("@singerid", model.Id);

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

        public bool Update(Model.T_Singer model)
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlCommand cmd = new SqlCommand("update T_Singer set Name=@name,Sex=@sex where Id=@id", myconn);
            
            cmd.Parameters.AddWithValue("@id", model.Id);
            cmd.Parameters.AddWithValue("@name", model.Name);
            cmd.Parameters.AddWithValue("@sex", model.Sex);

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



        #region 不带参查询
        //不带参数查询，默认查询所有记录 mark
        public DataSet Select()
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Singer.Id, dbo.T_Singer.Name, dbo.T_Singer.Sex FROM dbo.T_Singer order by dbo.T_Singer.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Singer");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 不带参查询


        #region 带参查询
        public DataSet Select(int Id)
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Singer.Id, dbo.T_Singer.Name, dbo.T_Singer.Sex FROM dbo.T_Singer where dbo.T_Singer.Id ='" + Id + "'", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Singer");

            sda.Dispose();

            myconn.Dispose();

            return ds;


        }


        #endregion 带参查询


    }
}
