using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Polymorphisam_Assignment
{
    internal abstract class FootWear
    {
        public static int No = 101;
        protected int _footWearId;
        protected int _size;
        protected bool _type; // true = jents false =  ladies


        public FootWear()
        {
            this._footWearId = No++;
        }

        public abstract void ProductDetails();
    }
}
