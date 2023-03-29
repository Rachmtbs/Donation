using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    //child class
    //abstaract is a contract between  child and parent need to make an impliment 
    public class Dog : Animal 
    {
        //place holder for the sounds a dog makes 

        public string Noise { get; set; }

        // method dog uses
        public string WagTail(string name) 
        {
            //interpolated string returned 
            return $"{name} is wagging its tail";
        }
        // implement make noise
        public override void MakeNoise(string noise)
        {
            System.Console.WriteLine(noise);
        }

        //another make noise method polymorphisim

        public void MakeNoise()
        {
            System.Console.WriteLine("noise");
        }


        //override to string
        public override string ToString() 
        {
            return base.ToString() + "a dog";
        } 
    }
}
