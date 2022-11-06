using System;

namespace OOP2 {

    //Abstract makes the class restricted so it cannot be used to create objects (to access it, it must be inherited from another class).
    //This is also the "main" class for all other lifeforms classes eventually derive from
    abstract class Life {

        //protected, cannot be accessed from a non-derived class from either the same assembly or a different one
        protected int _age = 0;
        
        public Life(int age) {

            _age = age;

        }

    }

}
