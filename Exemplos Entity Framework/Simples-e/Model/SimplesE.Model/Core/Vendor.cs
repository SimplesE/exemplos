using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplesE.Model.Core
{
    public class Vendor : User
    {
        public int VendorID { get; set; }
        public float Bonus { get; set; }
    }
}
