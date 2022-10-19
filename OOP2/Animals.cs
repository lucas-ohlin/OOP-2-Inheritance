using System;

namespace OOP2 {

    //abstract class which inherits from Life
    abstract class Djur : Life {

        public float _height;
        public float _weight;
        public string _name;
        public string _sound;
        public bool _wild;

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

        public Reptile(float height, float weight, int age, string name, string sound, bool wild)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {
        }

    }

    //internal class which inherits from Djur
    class Mammal : Djur {

        public Mammal(float height, float weight, int age, string name, string sound, bool wild)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {
        }

    }

}
