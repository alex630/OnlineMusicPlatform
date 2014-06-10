using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//mycodes.net
namespace Model
{
    public class T_Manager
    {
        private int _id;
        private string _userName;
        private string _passWord;
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
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
     
        /// <summary>
        /// 
        /// </summary>
        public char IsDel
        {
            get { return _isDel; }
            set { _isDel = value; }
        }

    }
}
