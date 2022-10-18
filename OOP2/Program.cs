using System;

namespace OOP2 {
    internal class Program {

        static void Main(string[] args) {

            //Katt
            Console.WriteLine("Katt:");
            var katt = new Katt(35f, 4f, 3, "Kitty", "Meow", false, "White");
            katt.Meow();
            katt.MakeSound();
            katt.Info();

            //Kanin
            Console.WriteLine("\n\nKanin:");
            var kanin = new Kanin(20f, 3f, 2, "Hoppy", "Squeak", false, 2f);
            kanin.Jump();
            kanin.MakeSound();
            kanin.Info();

            //Bulldog
            Console.WriteLine("\nBulldog:");
            var bulldog = new Bulldog(30f, 15f, 4, "Bosh", "Roof!", false, "Bulldog", "Beef", "Sit");
            bulldog.Bark();
            bulldog.MakeSound();
            bulldog.Trick();
            bulldog.Info();

            //Retriever
            Console.WriteLine("\nRetriever:");
            var retriever = new Retriever(50f, 15f, 8, "Doggy", "Woof!", false, "Retriever", "Duck", 50);
            retriever.Bark();
            retriever.MakeSound();
            retriever.Petted();
            retriever.Info();

            //Human
            Console.WriteLine("\nHuman");
            var human = new Human(190f, 70f, 40, "Karl", "Öh", false, true);
            human.MakeSound();
            human.Info();

            //Plant
            Console.WriteLine("\n\nRose");
            var rose = new Rose(1, 20f, "Rose", "Red");
            rose.Info();


        }

    }


    //Abstract makes the class restricted so it cannot be used to create objects (to access it, it must be inherited from another class).
    abstract class Life {

        public int _age { get; set; }

        public Life(int age) {

            //This class's value
            _age = age;

        }

    }

    abstract class Plants : Life {

        public float _height { get; set; }
        public string _name { get; set; }
        public string _colour { get; set; }

        public Plants(int age, float height, string name, string colour)
            //Sets the values to the base class's ones
            : base(age) {

            //This class's values
            _height = height;
            _name = name;
            _colour = colour;

        }

        public virtual void Info() {

            Console.WriteLine($"The {_name} is {_height}cm tall and is the colour {_colour}");

        }

    }

    abstract class Djur : Life {

        public float _height { get; set; }
        public float _weight { get; set; }
        public string _name { get; set; }
        public string _sound { get; set; }
        public bool _wild { get; set; }

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

    class Rose : Plants {

        public Rose(int age, float height, string name, string colour)
            : base(age, height, name, colour) {


        }

    }

    class Reptile : Djur {

        public Reptile(float height, float weight, int age, string name, string sound, bool wild)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {
        }

    }

    class Mammal : Djur {

        public Mammal(float height, float weight, int age, string name, string sound, bool wild)
            //Sets the values to the base class's ones
            : base(height, weight, age, name, sound, wild) {
        }

    }

    class Human : Mammal {

        public bool _doingTaxes { get; set; }

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

    class Kanin : Mammal {

        public float _jump { get; set; }

        public Kanin(float height, float weight, int age, string name, string sound, bool wild, float jump)
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

    class Katt : Mammal {

        public string _colour { get; set; }

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

    class Hund : Mammal {

        public string _race { get; set; }
        public string _food { get; set; }

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

    class Bulldog : Hund {

        public string _favTrick { get; set; }

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

        public int _petted { get; set; }

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
