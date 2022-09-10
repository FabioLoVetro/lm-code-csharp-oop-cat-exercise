using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		private bool _isAsleep = false;
		private int _averageHeight = 0;
		private string _setting = "";

        public bool IsAsleep { get => _isAsleep; set => _isAsleep = value; }
        public int AverageHeight { get => _averageHeight; set => _averageHeight = value; }
        public string Setting { get => _setting; set => _setting = value; }

        public abstract string Eat();

		public virtual void GoToSleep()
		{
			this._isAsleep = true;
		}
        
        public virtual void WakeUp()
        {
            this._isAsleep = false;
        }
    }
}
