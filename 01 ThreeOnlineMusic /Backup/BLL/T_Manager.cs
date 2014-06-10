using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Model;
using DAL;

namespace BLL
{
    public class T_Manager
    {
        DAL.T_Manager manger = new DAL.T_Manager();
        //增加
        public bool Add(Model.T_Manager model)
        {
            return manger.Add(model);
        }


        //修改,更新
        public bool Update(Model.T_Manager model)
        {
            return manger.Update(model);
        }

        //删除
        public bool Delete(int Id)
        {
            return manger.Delete(Id);
        }



        //有参查找
        public bool select(Model.T_Manager model)
        {
            return manger.select(model);

        }

        public DataSet Select(int Id)
        {
            return manger.Select(Id);
        }


        //无参查找
        public DataSet select()
        {
            return manger.Select();
        }





    }
}
