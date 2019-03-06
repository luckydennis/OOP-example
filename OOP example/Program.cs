using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example
{
    class Program
    {
        public abstract class Animal    //abstraction?
        {
            //in an abstract class modifiers can only be public or protected
            public int age;
            public string gender;

            public Animal(int age, string gender)
            {
                this.age = age;
                this.gender = gender;
            }
            public abstract void noise();  // to use this abstract method, I need to make the class abstract too
            

            virtual public void call() // had to make this virtual
            {
                Console.WriteLine("I am animal");

            }

        }


        public class Dog : Animal   //inheritance
        {
            public string name;

            //public int a;
            
            public Dog(string name,int a,string gender) : base(a,gender)
            {
                this.name = name;
                //base.Animal(age, gender);
            }

            override public void noise()
            {
                Console.WriteLine("ruff ruff");
            }
            override public void call() //run time polymorphism
            {
                Console.WriteLine($"I am {this.name},a {this.age} year old {this.gender} dog");
            }
            public void amountOfFood(int pound) //compile-time polymorphism
            {
                Console.WriteLine($"I am {pound} pounds, I eat 2 cups of food"); //set number for now
            }
            public void amountOfFood(int pound,bool dry) //compile-time polymorphism
            {

                if(dry == true)
                    Console.WriteLine($"I am {pound} pounds, I eat 2 cups of dry food");
                else
                    Console.WriteLine($"I am {pound} pounds, I eat 2 cups of wet food");
            }
        }

        static void Main(string[] args)
        {
            Animal A = new Dog("max", 10,"male");
            A.call(); // run-time polymorphism

            Dog D = new Dog("Bob", 5, "female");
            D.noise();
            D.amountOfFood(15);
            D.amountOfFood(15, true);
            Console.ReadKey();

        }
    }
}
