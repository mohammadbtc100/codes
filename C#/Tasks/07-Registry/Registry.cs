using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using DevComponents.DotNetBar;
using System.Windows.Forms;
namespace RegisterySetting
{
    public class RegKeyFunctions
    {
        public string myReadKey(string keyName)
        {
            RegistryKey regkey = Registry.LocalMachine;
            regkey = regkey.OpenSubKey(@"SOFTWARE\SirikSahelSystem");
            string str = regkey.GetValue(keyName).ToString();
            return str;
        }
        public void mywriteKey(string keyName, string value1)
        {
            RegistryKey regKey1 = Registry.LocalMachine;
            try
            {
                RegistryKey regKey = Registry.LocalMachine;
                regKey = regKey.OpenSubKey(@"SOFTWARE\SirikSahelSystem", true);
                regKey.SetValue(keyName, value1);
                regKey.Close();
            }
            catch
            {
                regKey1 = regKey1.OpenSubKey(@"SOFTWARE", true);
                regKey1.CreateSubKey(keyName);
                regKey1.Close();
            }
        }
    }
}
