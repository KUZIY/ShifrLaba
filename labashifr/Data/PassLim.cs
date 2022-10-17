using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labashifr.Data
{
    static class PassLim
    {
        static Regex limitchar = new Regex("[-.,;!?()]");
        static Regex limitlat = new Regex("[A-Za-z]");
        static Regex limitkir = new Regex("[А-Яа-я]");


        public static bool CheckLimit (string Pass)
        {
            if (limitchar.IsMatch(Pass) && limitlat.IsMatch(Pass) && limitkir.IsMatch(Pass))
                return true;
            return (false);
        }
    }
}
