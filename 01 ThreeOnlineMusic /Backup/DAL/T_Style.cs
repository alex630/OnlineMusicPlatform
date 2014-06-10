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
    public class T_Style
    {
        #region 增加

        public bool Add(Model.T_Style model)
        {

            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("insert into T_Style([Style]) values (@style)", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@style", model.Style);

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

        public bool Delete(Model.T_Style model)
        {


            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("delete from T_Style where Id=@id;delete from T_Music where StyleId=@styleid", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@id", model.Id);
            cmd.Parameters.AddWithValue("@styleid", model.Id);


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

        public bool Update(Model.T_Style model)
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlCommand cmd = new SqlCommand("update T_Style set Style=@style where Id=@id", myconn);

            cmd.Parameters.AddWithValue("@style", model.Style);
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



        #region 不带参查询
        //不带参数查询，默认查询所有记录
        public DataSet Select()
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Style.Id, dbo.T_Style.Style FROM dbo.T_Style", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Style");

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

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Style.Id, dbo.T_Style.Style FROM dbo.T_Style where dbo.T_Style.Id ='" + Id + "'", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Style");

            sda.Dispose();

            myconn.Dispose();

            return ds;


        }


        #endregion 带参查询

    }
}
