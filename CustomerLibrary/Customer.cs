namespace CustomerLibrary
{
    public class Customer
    {
        private int _id;
        private string _name;

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void Display()
        {
            Console.WriteLine("ID : {0}\nName : {1} ", this._id, this._name);
        }
    }
}