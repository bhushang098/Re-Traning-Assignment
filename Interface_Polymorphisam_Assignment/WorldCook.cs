using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphisam_Assignment
{
    internal class WorldCook : Cook
    {
        private string _chainName;

        public WorldCook(string name, int experience, string cuisine, string chainName) : base(name, experience, cuisine)
        {
            this._chainName = chainName;
        }

        public override void cookFood()
        {
            Console.WriteLine(string.Format("The Cook {0} is cooking {1} food in {2} chains of Hotel", this._cookName, this._mainCuisine, this._chainName));
        }
    }
}
