using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphisam_Assignment
{
    internal class CookHolder
    {
        byte counter;
        private ICook[] cooks;

        public CookHolder()
        {
            counter = 0;
            cooks = new ICook[10];
        }

        public void createCook(CookType type, string name, int experience, string cuisine, string workingName)
        {
            switch (type)
            {
                case CookType.HomeCook:
                    ICook homeCook = new HomeCook(name, experience, cuisine, workingName);
                    cooks[counter++] = homeCook;
                    break;
                case CookType.MasterChef:
                    ICook masterChef = new MasterChef(name, experience, cuisine, workingName);
                    cooks[counter++] = masterChef;
                    break;
                case CookType.WorldCook:
                    ICook worldCook = new WorldCook(name, experience, cuisine, workingName);
                    cooks[counter++] = worldCook;
                    break;
                default:
                    break;
            }
        }

        public void makeAllCookFood()
        {
            foreach (ICook cook in cooks)
            {
                if (cook != null)
                {
                    cook.cookFood();
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
