using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace labashifr.Data
{
    public class ControllerMD4
    {
        public string _keyDB;
        public string _key;

        public string Key()
        {
             return _key; 
        }


    readonly string _dbpathMD4;

        public ControllerMD4()
        {
            _dbpathMD4 = Program.dbPathMD4;

            if (!File.Exists(_dbpathMD4))
            {
                using (File.Create(_dbpathMD4)) ;
                MD4 MD4 = new MD4();
                _keyDB = MD4.GetHexHashFromString("key");
                SaveKey();
            }
            GetKey();
        }
        public ControllerMD4(string x)
        {
            
            _key = x;
            _dbpathMD4 = Program.dbPathMD4;
            GetKey();
        }
        public bool CheckKey()
        {
            MD4 MD4 = new MD4();
            if (MD4.GetHexHashFromString(_key) == _keyDB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void GetKey()
        {
            string key = "";
            using (StreamReader reader = new StreamReader(_dbpathMD4))
            {
                key = reader.ReadToEnd();
            }
            if (key != "")
                _keyDB = key.Replace("\n","").Replace("\r","");
        }

        public void SaveKey()
        {
            MD4 MD4 = new MD4();
            using (StreamWriter sw = new StreamWriter(_dbpathMD4, false))
            {
                sw.WriteLine(_keyDB);
            }
        }
    }
}
