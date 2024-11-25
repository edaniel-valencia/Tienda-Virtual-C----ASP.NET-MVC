using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pdescription { get; set; }
        public decimal Pprice { get; set; }
        public int Pstock { get; set; }
        public string ProuteImage { get; set; }
        public string PnameImage { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public bool Pstatus { get; set; }
    }
}
