using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation2
{
    //base class
    public abstract class Donation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public decimal Amount { get; set; }
        public int Age { get; set; }

    } 
}
