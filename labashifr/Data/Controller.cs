using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labashifr.Data
{
    public class Controller
    {
        public List<UsersDB> _listUsers;
        readonly string _dbpath;
        public Controller()
        {
            _listUsers = new List<UsersDB>();
            _dbpath = Program.dbPath;

            if (!File.Exists(_dbpath))
            {
                using (File.Create(_dbpath)) ;
                _listUsers.Add(new UsersDB() { UserName = "admin", Password = "", Block = false, Limit = false });
                SaveData();
            }
            GetData();
        }

        public void GetData()
        {
            string dataJson = "";
            Program.ControllerMD4 = new Data.ControllerMD4();
            string k = Program.ControllerMD4._key;
            //ControllerMD4 v = new ControllerMD4("Z"); ;  
            //string key = v.Key();
            using (StreamReader reader = new StreamReader(_dbpath))
            {
                dataJson = reader.ReadToEnd();
            }
            if (dataJson != "")
                //ControllerMD4 controllerMD4 = new ControllerMD4();

                _listUsers = JsonConvert.DeserializeObject<List<UsersDB>>(Encription.Decrypt(dataJson,"key"));    
        }

        public void SaveData()
        {
            string dataJson = Encription.Encrypt(JsonConvert.SerializeObject(_listUsers));

            using (StreamWriter sw = new StreamWriter(_dbpath, false))
            {
                sw.WriteLine(dataJson);
            }
        }
    }
}
