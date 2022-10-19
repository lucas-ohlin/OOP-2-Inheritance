using System;

namespace OOP2 {

    //internal class which inherits from Mammal
    internal class Human : Mammal {

        public bool _doingTaxes;

        public Human(float height, float weight, int age, string name, string sound, bool wild, bool taxes)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {

            //This class's value
            _doingTaxes = taxes;

        }

        public override void Info() {

            base.Info();
            Console.Write($"Is currently doing taxes: {_doingTaxes}");

        }

    }

    //internal class which inherits from Mammal
    class Rabbit : Mammal {

        public float _jump;

        public Rabbit(float height, float weight, int age, string name, string sound, bool wild, float jump)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {

            //This class's value
            _jump = jump;

        }

        public virtual void Jump() {

            Console.WriteLine($"{_name} can jump {_jump} meters.");

        }

        public override void MakeSound() {

            Console.WriteLine(_sound);

        }

    }

    //internal class which inherits from Mammal
    class Katt : Mammal {

        public string _colour;

        public Katt(float height, float weight, int age, string name, string sound, bool wild, string colour)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {

            //This class's value
            _colour = colour;

        }

        public override void Info() {

            //The base classes info + the new informaton
            base.Info();
            Console.Write($"Colour: {_colour}.");

        }

        public virtual void Meow() {

            Console.WriteLine("Meow");

        }

        public override void MakeSound() {

            Console.WriteLine("Purrrrr");

        }

    }

    //internal class which inherits from Mammal
    class Hund : Mammal {

        public string _race;
        public string _food;

        public Hund(float height, float weight, int age, string name, string sound, bool wild, string ras, string food)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {

            //This class's values
            _race = ras;
            _food = food;

        }

        public virtual void Bark() {

            Console.WriteLine("Bark!");

        }

        public override void MakeSound() {

            Console.WriteLine("Grrrrrr");

        }

    }

}
