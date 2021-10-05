using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BranchDTO
    {
        public int branchId { get; set; }
        public string branchName { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string idManager { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
        public Nullable<int> idChainStore { get; set; }
        public List<int> Categories { get; set; } = new List<int>();
    }
}
