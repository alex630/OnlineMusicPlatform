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
    public class T_Singer
    {
        DAL.T_Singer db = new DAL.T_Singer();
        //增加

        public bool Add(Model.T_Singer model)
        {
            return db.Add(model);
        }

        //删除
        public bool Delete(Model.T_Singer model)
        {
            return db.Delete(model);
        }



        //更新
        public bool Update(Model.T_Singer model)
        {
            return db.Update(model);
        }


        //无参查找
        public DataSet select()
        {
            return db.Select();
        }
        //有参查找
        public DataSet Select(int Id)
        {
            return db.Select(Id);
        }


    }
}
