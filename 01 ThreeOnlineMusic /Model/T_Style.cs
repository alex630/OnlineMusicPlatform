using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_Style
    {
        #region T_Style

        private int _id;
        private string _style;
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
        public string Style
        {
            get { return _style; }
            set { _style = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public char IsDel
        {
            get { return _isDel; }
            set { _isDel = value; }
        }

        #endregion T_Style

    }
}
