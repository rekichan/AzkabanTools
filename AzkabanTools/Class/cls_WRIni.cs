using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzkabanTools
{
    class cls_WRIni
    {
        public string _inipath = "";

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        object lockobject;//多线程被锁对象

        /// <summary> 
        /// 构造方法 
        /// </summary> 
        /// <param name="_iniFilePath">文件路径</param>
        public cls_WRIni(string _iniFilePath)
        {
            _inipath = _iniFilePath;
            lockobject = new object();
        }

        /// <summary>
        /// 写入INI文件 
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName])</param>
        /// <param name="Key">键</param> 
        /// <param name="Value">值</param> 
        public void IniWriteValue(string Section, string Key, string Value)
        {
            lock (lockobject)
            {
                WritePrivateProfileString(Section, Key, Value, this._inipath);
            }
        }

        /// <summary>
        /// 读出INI文件 
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        public string IniReadValue(string Section, string Key, string sDefault)
        {
            lock (lockobject)
            {
                StringBuilder temp = new StringBuilder(500);
                int i = GetPrivateProfileString(Section, Key, sDefault, temp, 500, this._inipath);
                if (temp.Length == 0)
                {
                    temp.Append(sDefault);
                }
                return temp.ToString();
            }
        }
    }
}