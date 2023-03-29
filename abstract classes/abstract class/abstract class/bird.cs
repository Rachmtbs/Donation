using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{

    public class Bird :Animal, IFly
    {
        // this is the noise the bird makes

       

        // this is the method that only the bird uses
        public void  FlyAway()
        {
            // introplates string returned 
            //return $"{name} is flying away";
            Console.WriteLine(this.Name + "FlewAway");
        }

        public override void MakeNoise(string noise)
        {
            System.Console.WriteLine("Bird" + noise);
        }
        //override keyword needs to used when using an abstract method when telling the compiler to do 

        public void  Land()
        {
            //we dont use override because it is implined
            //empty because our birds dont land though to fly away they would have to land
        }
    }
}
