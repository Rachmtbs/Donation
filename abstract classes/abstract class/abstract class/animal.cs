using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    // properties common to animals
    //classes can be abstract methods cannot exsist in abstract classes 
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Noise { get; set; }

        //method common to animals
        public abstract void MakeNoise(string noise);
          // a method decleration with no body⬆️ you cannot provide an implimentation
        // overriding a method

        public override string ToString()
        {
            return "This animal is a ";
        }

    }
}
