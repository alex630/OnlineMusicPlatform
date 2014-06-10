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
    public class T_Music
    {
        DAL.T_Music db = new DAL.T_Music();
        //增加
        public bool Add(Model.T_Music model)
        {
            return db.Add(model);
        }
        //查找
        public DataSet select()
        {
            return db.Select();
        }
        public DataSet Select1()
        {
            return db.Select1();
        }
        public DataSet Select2()
        {
            return db.Select2();
        }
        //查找
        public DataSet select(int i)
        {
            return db.Select(i);
        }
        public DataSet select3( int i)
        {
            return db.Select3(i);
        }
        public DataSet select1(int i)
        {
            return db.Select1(i);
        }
        public DataSet select2(int i)
        {
            return db.Select2(i);
        }
        public DataSet select2(string str)
        {
            return db.Select2(str);
        }
    }
}
