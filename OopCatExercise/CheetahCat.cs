using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat()
        {
            this.AverageHeight = 30;
            this.Setting = "domestic";
        }

        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
