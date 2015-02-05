using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntrianFM
{
    class IniFile
    {
        private string filePath;
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivatePrivateProfileString(string section, string key, string val, string filePath);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniFile(string filePath)
        {
            this.filePath = filePath;
        }
        public void Write(string section, string key, string value)
        {
            WritePrivatePrivateProfileString(section, key, value.ToLower(), this.filePath);
        }
        public string Read(string section, string key)
        {
            StringBuilder sb = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", sb, 255, this.filePath);
            return sb.ToString();
        }
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }
    }
}
