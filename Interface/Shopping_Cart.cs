using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Shopping_Cart
    {
        public int SCid { get; set; }
        public Client idCliente { get; set; }
        public Product idProduct { get; set; }
        public int SCamount { get; set; }
    }
}
