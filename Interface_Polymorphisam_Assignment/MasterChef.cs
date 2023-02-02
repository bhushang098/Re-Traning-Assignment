using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphisam_Assignment
{
    internal class MasterChef : Cook
    {
        private string _restorantName;

        public MasterChef(string name, int experience, string cuisine, string restorantName) : base(name, experience, cuisine)
        {
            this._restorantName = restorantName;
        }

        public override void cookFood()
        {
            Console.WriteLine(string.Format("The Cook {0} is cooking {1} food in {2} Find Dine Restorant", this._cookName, this._mainCuisine, this._restorantName));
        }
    }
}
