using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_Music
    {
        #region T_Music
        private int _id;
        private string _musicName;
        private string _musicPath;
        private string _lyricPath;
        private int _styleId;
        private int _singerId;
        private char _isDel;
        private DateTime _addDate;




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
        public string MusicName
        {
            get { return _musicName; }
            set { _musicName = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MusicPath
        {
            get { return _musicPath; }
            set { _musicPath = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LyricPath
        {
            get { return _lyricPath; }
            set { _lyricPath = value; }
        }
        /// <summary>
        /// 
        /// </summary>        
        public int StyleId
        {
            get { return _styleId; }
            set { _styleId = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SingerId
        {
            get { return _singerId; }
            set { _singerId = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public char IsDel
        {
            get { return _isDel; }
            set { _isDel = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }
        #endregion T_Music

    }
}
