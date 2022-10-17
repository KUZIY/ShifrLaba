using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labashifr.Data
{
    public class UsersDB
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Block { get; set; }
        public bool Limit { get; set; }
    }
}
