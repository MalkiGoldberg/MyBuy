using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FilterProofDTO
    {
        public string idUser { get; set; }
        public int kindOfPayment { get; set;}
        public int action { get; set;}
        public int category { get; set;}
        public int chainStore { get; set;}
        public int branch { get; set;}
        public DateTime beginDate { get; set;}
        public DateTime endDate { get; set;}
        public bool recycling { get; set;}
    }
}
