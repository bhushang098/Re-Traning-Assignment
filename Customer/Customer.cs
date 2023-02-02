using Print_Delegate;

namespace customer_delegate
{
    public class Customer
    {

        int _custId;
        string _custName;



        public Customer(int _custId, string _custName)
        {
            this._custId = _custId;
            this._custName = _custName;

        }



        private void Display()
        {
            Console.WriteLine("Customer Id {0}", this._custId);
            Console.WriteLine("Customer Name {0}", this._custName);

        }
        public void AvailService()
        {
            PrintDelegate d = new PrintDelegate(Display);
            PrintingService.Print(d);

        }
    }

}