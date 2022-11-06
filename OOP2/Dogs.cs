using System;

namespace OOP2 {

    class Bulldog : Hund {

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected string _favTrick;

        //Constructor to create objects with the deafault variables
        public Bulldog() : base(2, 2, 2, "Bob", "Rawr", true, "Hund", "Pancake") {

            _favTrick = "Sit";

        }

        public Bulldog(float height, float weight, int age, string name, string sound, bool wild, string ras, string food, string favTrick)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild, ras, food) {

            //This class's value
            _favTrick = favTrick;

        }

        public override void Bark() {

            Console.WriteLine(_sound);

        }

        public void Trick() {

            Console.WriteLine($"{_name}'s favourite trick is {_favTrick}");

        }

    }

    class Retriever : Hund {

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected int _petted;

        //Constructor to create objects with the deafault variables
        public Retriever() : base(2, 2, 2, "Bob", "Rawr", true, "Hund", "Pancake") {

            _petted = 5;

        }

        public Retriever(float height, float weight, int age, string name, string sound, bool wild, string ras, string food, int petted)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild, ras, food) {

            //This class's value
            _petted = petted;

        }

        public override void Bark() {

            Console.WriteLine(_sound);

        }

        public void Petted() {

            Console.WriteLine($"{_name} has been petted {_petted} times");

        }

    }

}
