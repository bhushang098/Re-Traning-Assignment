using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Polymorphisam_Assignment
{
    internal class Formals : FootWear
    {
        private string _modelName;
        private string _companyName;
        private float _price;
        //private FootWearKind _kind;


        public Formals(int size, bool type, string modelName, string companyName, float price)
        {
            this._size = size;
            this._type = type;
            this._modelName = modelName;
            this._companyName = companyName;
            this._price = price;
            // this._kind = kind;
        }

        public override void ProductDetails()
        {
            Console.WriteLine(string.Format("The product Details of the Formals are : \n Company name : {0} \n Model name : {1} \n Wear Type : {2} \n Sleeper size : {3} \n Price : {4} RS. \n Product Id : {5}", this._companyName, this._modelName, this._type, this._size, this._price, this._footWearId));
        }
    }
}
