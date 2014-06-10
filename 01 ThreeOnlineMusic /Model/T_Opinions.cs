using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_Opinions
    {
        #region T_Opinions


        private int _id;
        private string _author;
        private string _message;
        private DateTime _addDate;
        private char isDel;
 
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
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        public char IsDel
        {
            get { return isDel; }
            set { isDel = value; }
        }


        #endregion T_Opinions

    }
}
