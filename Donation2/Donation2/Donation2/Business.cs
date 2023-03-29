using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Donation2
{
    public class Business : Donation, IHasANickname
    {
        public void GiveANickname()
        {

        }
        public  void GiveMoney()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 26);
            string nickName = FirstName + x + "_" + LastName + y;
            
        }
    }
}



