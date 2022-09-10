using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
            this.AverageHeight = 23;
            this.Setting = "domestic";
        }

        public override string Eat()
        {
            return "Purrrrrrr";
        }
    }
}
