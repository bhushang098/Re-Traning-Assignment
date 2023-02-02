using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialiizaton_Example
{
    [Serializable]
    public class Product
    {
        public int _id;
        public string _name;
        [NonSerialized]
        private int _price;
        public string _description;

        public Product()
        {

        }

        public Product(int id, string name, int price, string description)
        {
            _id = id;
            _name = name;
            _price = price;
            _description = description;
        }
        public int Id { get { return _id; } }

        public string Name { get { return _name; } }

        public int Price { get { return _price; } }

        public string Description { get { return _description; } }
    }
}
