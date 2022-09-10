using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        private bool _restless;

        //two kind of domestic cat
        public DomesticCat()
        {
            this.AverageHeight = 23;
            this.Setting = "domestic";
            Random rnd = new Random();
            if(rnd.Next()%2==0)
                this._restless = false;
            else
                this._restless = true;
        }
        // if is a just domestic cat will return "Purrrrrrr"
        // if is a domestic wild cat will return "It will do I suppose"
        public override string Eat()
        {
            if (this._restless == false)
                return "Purrrrrrr";
            else
                return "It will do I suppose";
        }
        public bool IsRestless()
        {
            return this._restless;
        }
    }
}
