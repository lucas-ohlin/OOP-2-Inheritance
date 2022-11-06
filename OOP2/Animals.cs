using System;
using System.Xml.Linq;

namespace OOP2 {

    //abstract class which inherits from Life
    abstract class Djur : Life {

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected float _height;
        protected float _weight;
        protected string _name;
        protected string _sound;
        protected bool _wild;

        //Constructor to create objects with the deafault variables
        public Djur () : base(2) {

            _height = 1;
            _weight = 1;
            _name = "Kalle";
            _sound = "AJ";
            _wild = true;

        }

        public Djur(float height, float weight, int age, string name, string sound, bool wild)
            //Sets the values to the base class's ones
            : base(age) {

            //This class's values
            _height = height;
            _weight = weight;
            _name = name;
            _sound = sound;
            _wild = wild;

        }

        //Virtual so we can override the class in the children classes
        public virtual void Info() {

            Console.WriteLine($"{_name} is {_age} years old, weights {_weight}kg and is {_height}cm tall.\nIs wild: {_wild}");

        }

        public virtual void MakeSound() {

            Console.WriteLine("ljud");

        }

        //Doesn't need to be virtual since we're not going to change it
        public void Sleep() {

            Console.WriteLine("zzz");

        }

        public void Alert() {

            Console.WriteLine("!");

        }

    }

    //internal class which inherits from Djur
    class Reptile : Djur {

        //Constructor to create objects with the deafault variables
        public Reptile () : base(2, 2, 2, "Bob", "Rawr", true) {}

        public Reptile(float height, float weight, int age, string name, string sound, bool wild)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {
        }

    }

    //internal class which inherits from Djur
    class Mammal : Djur {

        //Constructor to create objects with the deafault variables
        public Mammal () : base(2, 2, 2, "Bob", "Rawr", true) {}

        public Mammal(float height, float weight, int age, string name, string sound, bool wild)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {
        }

    }

}
