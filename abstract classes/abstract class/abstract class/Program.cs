using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            //this is where I project executes 
            //Console.WriteLine("Hello There!");

            // animal is the base class its is abstract making an abstract class you need to substatuate thats why the below is in error
                 //Animal animal = new Animal();
            Dog dog = new Dog();
            Bird bird = new Bird();
            bird.Noise = "Chirp";
            bird.Name = "Bigbird";
            dog.Name = "Fido";
            dog.Noise = "Whoof whoof!";
            //dog.MakeNoise(dog.Noise);
            Console.WriteLine(dog.ToString());
            //dog.GiveDogLegs();
            Console.WriteLine(bird.ToString());

            ShowAnimal(dog);
            ShowAnimal(bird);
            Console.WriteLine();
            bird.FlyAway();
            DoSoemthingFlying(bird);
        }

        //method from another system or project

        public static void ShowAnimal(Animal animal)
        {
            Console.WriteLine("showing animal"  );
            animal.MakeNoise(animal.Noise);
        }
        public static void DoSoemthingFlying(IFly fly)
        {
            //send an object that is ifly
            Console.WriteLine("Yeah I flew far and fast!");
        }
    }
}
