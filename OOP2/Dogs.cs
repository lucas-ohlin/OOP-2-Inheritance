using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2 {

    class Bulldog : Hund {

        public string _favTrick;

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

        public int _petted;

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
