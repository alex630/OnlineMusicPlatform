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
    public class T_Opinions
    {
        #region 增加

        public bool Add(Model.T_Opinions model)
        {

            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("insert into T_Music([Id],[Author],[Message]) values (@id,@author,@message)", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@id", model.Id);
            cmd.Parameters.AddWithValue("@author", model.Author);
            cmd.Parameters.AddWithValue("@message", model.Message);

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

        public bool Delete(Model.T_Opinions model)
        {


            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("delect from T_Opinions where Id=@id", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@id", model.Id);


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


       
    }
}
