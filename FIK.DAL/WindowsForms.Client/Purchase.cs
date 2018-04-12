using FIK.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Client
{
    public class Purchase
    {
        public int Id { get; set; }
        public string RcvNo { get; set; }
        public string PrdCode { get; set; }
        public int? Qty { get; set; }
        public DateTime? RcvDate { get; set; }
        
        public decimal? TestMoney { get; set; }
        public decimal? TestNumeric { get; set; }

        [FIK_NoCUD]
        public string ItemName { get; set; }
    }
}
