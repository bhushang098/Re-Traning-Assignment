using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Polymorphisam_Assignment
{
    internal class FootWearHolder
    {
        byte counter;
        private FootWear[] footwears;

        public FootWearHolder()
        {
            counter = 0;
            footwears = new FootWear[10];
        }

        public void createFootWear(FootWearKind wearKind, int size, bool type, string modelName, string companyName, float price)
        {
            switch (wearKind)
            {
                case FootWearKind.Sleepers:
                    FootWear sleeper = new Sleepers(size, type, modelName, companyName, price);
                    footwears[counter++] = sleeper;
                    break;
                case FootWearKind.Formals:
                    FootWear formal = new Formals(size, type, modelName, companyName, price);
                    footwears[counter++] = formal;
                    break;
                case FootWearKind.Sports:
                    FootWear sport = new Sport(size, type, modelName, companyName, price);
                    footwears[counter++] = sport;
                    break;
                default:
                    break;
            }
        }

        public void printAllproducts()
        {
            foreach (FootWear f in footwears)
            {
                if (f != null)
                {
                    f.ProductDetails();
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    break;
                }

            }
        }

    }
}
