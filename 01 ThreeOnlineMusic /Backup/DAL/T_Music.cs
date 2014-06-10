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
    public class T_Music
    {
        #region 增加

        public bool Add(Model.T_Music model)
        {

            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("insert into T_Music([MusicName],[MusicPath],[LyricPath],[StyleId],[SingerId]) values (@musicname,@musicpath,@lyricpath,@styleid,@singerid)", myconn);

            //为SQL语句匹配相关参数，并赋值
            cmd.Parameters.AddWithValue("@musicname", model.MusicName);
            cmd.Parameters.AddWithValue("@musicpath", model.MusicPath);
            cmd.Parameters.AddWithValue("@lyricpath", model.LyricPath);
            cmd.Parameters.AddWithValue("@styleid", model.StyleId);
            cmd.Parameters.AddWithValue("@singerid", model.SingerId);

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

        public bool Delete(Model.T_Music model)
        {


            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
            //创建数据库对象
            SqlConnection myconn = new SqlConnection(setting);
            //打开连接
            myconn.Open();
            //创建命令对象，并准备好操作数据库的SQL语句
            SqlCommand cmd = new SqlCommand("delect from T_Music where Id=@id", myconn);

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


        #region 修改

        public bool Update(Model.T_Music model)
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlCommand cmd = new SqlCommand("update T_Stu set MusicName=@musicname,MusicPath=@musicpath,LyricPath=@lyricpath,StyleId=@styleid,SingerId=@singerid AddDate=@adddate where Id=@id", myconn);

            cmd.Parameters.AddWithValue("@musicname", model.MusicName);
            cmd.Parameters.AddWithValue("@musicpath", model.MusicPath);
            cmd.Parameters.AddWithValue("@lyricpath", model.LyricPath);
            cmd.Parameters.AddWithValue("@styleid", model.StyleId);
            cmd.Parameters.AddWithValue("@singerid", model.SingerId);
            cmd.Parameters.AddWithValue("@adddate", DateTime.Now);

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



        //#region 不带参查询

        //public DataSet Select()
        //{ 
        //     //读取配置文件中的相关节点信息：数据库连接字符串
        //    string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();
        //    //创建数据库对象
        //    SqlConnection myconn = new SqlConnection(setting);
        //    //打开连接
        //    myconn.Open();
        //    //创建命令对象，并准备好操作数据库的SQL语句
        //    SqlCommand cmd = new SqlCommand(
        //return 
        //}

        //#endregion 不带参查询


        #region 不带参查询
        //不带参数查询，默认查询所有记录
        public DataSet Select()
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Music.Id, dbo.T_Music.MusicName, dbo.T_Music.MusicPath,dbo.T_Music.LyricPath,dbo.T_Music.SingerId FROM dbo.T_Music order by dbo.T_Music.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 不带参查询
        #region 不带参查询

        public DataSet Select1()
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT top 9 dbo.T_Music.Id, dbo.T_Music.MusicName, dbo.T_Music.MusicPath,dbo.T_Music.LyricPath,dbo.T_Music.SingerId,dbo.T_Singer.Name FROM dbo.T_Music INNER JOIN dbo.T_Singer ON dbo.T_Music.SingerId=dbo.T_Singer.Id order by dbo.T_Music.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }
        public DataSet Select2()
        {
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT top 8 dbo.T_Music.Id, dbo.T_Music.MusicName, dbo.T_Music.MusicPath,dbo.T_Music.LyricPath,dbo.T_Music.SingerId,dbo.T_Singer.Name FROM dbo.T_Music INNER JOIN dbo.T_Singer ON dbo.T_Music.SingerId=dbo.T_Singer.Id order by dbo.T_Music.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 不带参查询


        #region 带参查询
        //不带参数查询，默认查询所有记录
        public DataSet Select(int i)
        {
            int j = Convert.ToInt32(i);
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Music.Id, dbo.T_Music.MusicName, dbo.T_Music.MusicPath,dbo.T_Music.LyricPath FROM dbo.T_Music WHERE dbo.T_Music.Id=" + j + "", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 带参查询







        #region 带参查询

        public DataSet Select1(int i)
        {
            int j = Convert.ToInt32(i);
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT top 9 dbo.T_Music.Id, dbo.T_Music.MusicName, dbo.T_Music.MusicPath,dbo.T_Music.LyricPath,dbo.T_Music.SingerId,dbo.T_Singer.Name FROM dbo.T_Music INNER JOIN dbo.T_Singer ON dbo.T_Music.SingerId=dbo.T_Singer.Id WHERE dbo.T_Music.StyleId=" + j + "order by dbo.T_Music.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }
        public DataSet Select3(int i)
        {
            int j = Convert.ToInt32(i);
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.T_Music.Id, dbo.T_Music.MusicName, dbo.T_Music.MusicPath,dbo.T_Music.LyricPath,dbo.T_Music.SingerId,dbo.T_Singer.Name FROM dbo.T_Music INNER JOIN dbo.T_Singer ON dbo.T_Music.SingerId=dbo.T_Singer.Id WHERE dbo.T_Music.StyleId=" + j + "order by dbo.T_Music.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 带参查询


        #region 带参查询

        public DataSet Select2(int i)
        {
            int j = Convert.ToInt32(i);
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT  dbo.T_Music.Id, dbo.T_Music.MusicName, dbo.T_Music.MusicPath,dbo.T_Music.LyricPath,dbo.T_Music.SingerId,dbo.T_Singer.Name FROM dbo.T_Music INNER JOIN dbo.T_Singer ON dbo.T_Music.SingerId=dbo.T_Singer.Id WHERE dbo.T_Music.StyleId=" + j + "order by dbo.T_Music.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 带参查询


        #region 带参查询

        public DataSet Select2(string str)
        {
            //int j = Convert.ToInt32(i);
            //读取配置文件中的相关节点信息：数据库连接字符串
            string setting = ConfigurationManager.ConnectionStrings["connstring"].ToString();

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT  dbo.T_Music.Id,dbo.T_Music.MusicName,dbo.T_Music.MusicPath,dbo.T_Music.LyricPath,dbo.T_Music.SingerId,dbo.T_Singer.Name FROM dbo.T_Music INNER JOIN dbo.T_Singer ON dbo.T_Music.SingerId=dbo.T_Singer.Id WHERE dbo.T_Music.MusicName like " + str + " order by dbo.T_Music.Id DESC", myconn);

            DataSet ds = new DataSet();

            sda.Fill(ds, "T_Music");

            sda.Dispose();
            myconn.Dispose();

            return ds;
        }

        #endregion 带参查询






    }
}
