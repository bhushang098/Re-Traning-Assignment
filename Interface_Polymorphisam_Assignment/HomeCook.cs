using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphisam_Assignment
{
    internal class HomeCook : Cook
    {
        private string _hotelName;

        public HomeCook(string name, int experience, string cuisine, string hotelName) : base(name, experience, cuisine)
        {
            this._hotelName = hotelName;
        }

        public override void cookFood()
        {
            Console.WriteLine(string.Format("The Cook {0} is cooking {1} food in {2} Hotel", this._cookName, this._mainCuisine, this._hotelName));
        }
    }
}
