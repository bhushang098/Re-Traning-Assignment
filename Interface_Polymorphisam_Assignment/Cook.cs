using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphisam_Assignment
{
    internal class Cook : ICook
    {
        public static int No = 101;
        protected int _cookId;
        protected string _cookName;
        protected int _cookExpreience; // in Years
        protected string _mainCuisine;


        public Cook(string name, int experience, string cuisine)
        {
            this._cookId = No++;
            this._cookName = name;
            this._cookExpreience = experience;
            this._mainCuisine = cuisine;
        }

        public virtual void cookFood()
        {
            Console.WriteLine("The Con Can food Very Well");
        }

    }
}
