using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_Singer
    {

        #region T_Singer


        private int _id;
        private string _name;
        private string _sex;
        private char _isDel;

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public char IsDel
        {
            get { return _isDel; }
            set { _isDel = value; }
        }


        #endregion T_Singer

    }
}
