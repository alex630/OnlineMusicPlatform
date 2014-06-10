using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class T_Count
    {
        DAL.T_Count db = new DAL.T_Count();
        //更新
        public bool Update(Model.T_Count model)
        {
            return db.Update(model);
        }    

    }
}
