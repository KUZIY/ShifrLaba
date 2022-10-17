using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace labashifr.Data
{
    internal class ControllerMD4
    {
        public string _keyDB;
        public string _key;
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
        public string decryptData(byte[] hashedData)
        {
            TakeKey();

            byte[] bytesIv = new byte[16];
            byte[] mess = new byte[hashedData.Length - 16];
            for (int i = hashedData.Length - 16, j = 0; i < hashedData.Length; i++, j++)
                bytesIv[j] = hashedData[i];
            for (int i = 0; i < hashedData.Length - 16; i++)
                mess[i] = hashedData[i];
            Aes aes = Aes.Create();
            aes.Key = _aesKey;
            aes.IV = bytesIv;
            string text = "";
            byte[] data = mess;
            ICryptoTransform crypt = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        text = sr.ReadToEnd();
                    }
                }
            }
            return text;

        }
        public byte[] encryptData(string text)
        {
            Aes aes = Aes.Create();
            aes.GenerateIV();
            aes.GenerateKey();
            aes.Key = _key;
            byte[] encrypted;
            ICryptoTransform crypt = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(text);
                    }
                }
                encrypted = ms.ToArray();
            }

            return encrypted.Concat(aes.IV).ToArray();
        }
    }
}
