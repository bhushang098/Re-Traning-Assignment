namespace Product_Delegate
{
    using Print_Delegate;
 
    public class Product
    {
        int prodId;
        string prodName;

        public Product(int prodId, string prodName)
        {
            this.prodId = prodId;
            this.prodName = prodName;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Id :{0}", this.prodId);
            Console.WriteLine("Product Id :{0}", this.prodName);


        }
        public void UseService()
        {
            PrintDelegate d = new PrintDelegate(DisplayProductDetails);
            PrintingService.Print(d);
        }
    }
}