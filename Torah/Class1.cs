using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.InteropServices;

namespace INI
{
    class IniFiles
    {
        public string inipath;



        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        /// <summary> 
        /// 
        /// </summary> 
        /// <param name="INIPath"></param> 
        public IniFiles(string INIPath)
        {
            inipath = INIPath;
        }

        public IniFiles() { }

        /// <summary> 
        ///  
        /// </summary> 
        /// <param name="Section"></param> 
        /// <param name="Key"></param> 
        /// <param name="Value"></param> 
        public void IniWriteValue(string Section, string Key, string Value)
        {
            if (string.IsNullOrEmpty(Section))
            {
                throw new ArgumentException("must Section", "Section");
            }
            if (string.IsNullOrEmpty(Key))
            {
                throw new ArgumentException("must key", "Key");
            }
            if (Value == null)
            {
                throw new ArgumentException("not null ", "Value");
            }

            WritePrivateProfileString(Section, Key, Value, this.inipath);
        }
        /// <summary> 
        ///  
        /// </summary> 
        /// <param name="Section"> )</param> 
        /// <param name="Key"></param> 
        public void IniReadValue(string Section, string Key, ref string Value)
        {
            StringBuilder temp = new StringBuilder(500);
            if (string.IsNullOrEmpty(Section))
            {
                throw new ArgumentException("must Section", "Section");
            }
            if (string.IsNullOrEmpty(Key))
            {
                throw new ArgumentException("must key", "Key");
            }

            int i = GetPrivateProfileString(Section, Key, "", temp, 500, this.inipath);
            if (i != 0)
            {
                Value = temp.ToString();
            }
            temp = null;
        }


        /// <summary> 
        ///  
        /// </summary> 
        /// <returns></returns> 
        public bool ExistINIFile()
        {
            return File.Exists(inipath);
        }
    }
}