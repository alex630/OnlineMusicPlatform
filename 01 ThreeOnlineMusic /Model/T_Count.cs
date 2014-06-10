using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_Count
    {
        private int _id;
        private int _listenedSum;
        private int _downSum;
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
        public int ListenedSum
        {
            get { return _listenedSum; }
            set { _listenedSum = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DownSum
        {
            get { return _downSum; }
            set { _downSum = value; }
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
