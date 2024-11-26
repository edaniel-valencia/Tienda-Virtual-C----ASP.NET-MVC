using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class User
    {

        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Ulastname { get; set; }
        public string Uemail { get; set; }
        public string Uphone { get; set; }
        public string Upassword { get; set; }
        public int Ureset { get; set; }
        public int Ustatus { get; set; }
    }
}
