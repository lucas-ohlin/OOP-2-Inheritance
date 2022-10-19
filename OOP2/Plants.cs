using System;

namespace OOP2 {

    //Abstact class which inherits from Life
    abstract class Plants : Life {

        public float _height;
        public string _name;
        public string _colour;

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
