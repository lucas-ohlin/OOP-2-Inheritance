using System;

namespace OOP2 {

    //internal class which inherits from Mammal
    internal class Human : Mammal {

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected bool _doingTaxes;

        //Constructor to create objects with the deafault variables
        public Human() : base(1, 2, 3, "Kalle", "Aj", false) { 
        
            _doingTaxes = true;

        }

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

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected float _jump;

        //Constructor to create objects with the deafault variables
        public Rabbit() : base(1, 2, 3, "Kalle", "Aj", false) {

            _jump = 10;
            
        } 

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

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected string _colour;

        //Constructor to create objects with the deafault variables
        public Katt() : base(1, 2, 3, "Kalle", "Aj", false) {

            _colour = "Red";
            
        }

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

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected string _race;
        protected string _food;

        public Hund() : base(1, 2, 3, "Kalle", "Aj", false) {

            _race = "Dog";
            _food = "Food";
        
        }

        //Constructor to create objects with the deafault variables
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
