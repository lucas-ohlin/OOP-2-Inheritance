using System;

namespace OOP2 {

    internal class Program {

        private static void Main(string[] args) {

            //Creating a new object using the Katt constructor
            Katt katt = new Katt(35f, 4f, 3, "Kitty", "Meow", false, "White");
            Console.WriteLine("Katt:");
            katt.Meow();
            katt.MakeSound();
            katt.Info();

            //Creating a new object using the Rabbit constructor
            Rabbit rabbit = new Rabbit(20f, 3f, 2, "Hoppy", "Squeak", false, 2f);
            Console.WriteLine("\n\nRabbit:");
            rabbit.Jump();
            rabbit.MakeSound();
            rabbit.Info();

            //Creating a new object using the Bulldog constructor
            Bulldog bulldog = new Bulldog(30f, 15f, 4, "Bosh", "Roof!", false, "Bulldog", "Beef", "Sit");
            Console.WriteLine("\nBulldog:");
            bulldog.Bark();
            bulldog.MakeSound();
            bulldog.Trick();
            bulldog.Info();

            //Creating a new object using the Retriever constructor
            Retriever retriever = new Retriever(50f, 17f, 8, "Doggy", "Woof!", false, "Retriever", "Duck", 50);
            Console.WriteLine("\nRetriever:");
            retriever.Bark();
            retriever.MakeSound();
            retriever.Petted();
            retriever.Info();

            //Creating a new object using the Human constructor
            Console.WriteLine("\nHuman");
            Human human = new Human(190f, 70f, 40, "Karl", "Öh", false, true);
            human.MakeSound();
            human.Info();

            //Using the default constructor for Human
            Console.WriteLine("\n\nDefault Contructor");
            Human test = new Human();
            test.Info();

        }

    }

}
