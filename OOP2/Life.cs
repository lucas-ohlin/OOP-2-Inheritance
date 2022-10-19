using System;

namespace OOP2 {

    //Abstract makes the class restricted so it cannot be used to create objects (to access it, it must be inherited from another class).
    //This is also the "main" class for all other lifeforms classes eventually derive from
    abstract class Life {

        //Private because we don't need to accsess this value outside from the public Life function
        public int _age;
        
        public Life(int age) {

            //This class's value
            _age = age;

        }

    }

}
