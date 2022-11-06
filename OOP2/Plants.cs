using System;

namespace OOP2 {

    //Abstact class which inherits from Life
    abstract class Plants : Life {

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected float _height;
        protected string _name;
        protected string _colour;

        //Constructor to create objects with the deafault variables
        public Plants() : base(3) {

            _height = 10;
            _name = "Planti";
            _colour = "Red";
        
        }

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

    //internal class which inherits from Plants
    class Rose : Plants {

        public Rose(int age, float height, string name, string colour)
            : base(age, height, name, colour) {

        }

    }

}
