using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation2
{
    //you can inheret one class only provide an implemention for the i has a nickname
     class Personal : Donation, IHasANickname
     {
         
        public  void GiveANickname() 
        {
           
        }

       public void GiveMoney() 
       {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 26);
            string nickName = FirstName + x + "_" + LastName + y;

        }

       
     }
}
