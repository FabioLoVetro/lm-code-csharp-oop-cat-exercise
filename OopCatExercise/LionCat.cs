using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        public LionCat()
        {
            this.AverageHeight = 1100;
            this.Setting = "wild";
        }

        public override string Eat()
        {
            return "Roar!!!!";
        }
        

    }
}
