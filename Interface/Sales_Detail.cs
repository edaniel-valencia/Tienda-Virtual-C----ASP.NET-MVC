using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Sales_Detail
    {
        public int SDid { get; set; }
        public int Sid { get; set; }
        public Product Product { get; set; }
        public int SDamount { get; set; }
        public decimal SDtotalValue { get; set; }
        public string StransactionCode { get; set; }

        public List<Sales_Detail> SalesDetail {  get; set; }

    }
}
