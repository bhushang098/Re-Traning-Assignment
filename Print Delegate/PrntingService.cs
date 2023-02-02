namespace Print_Delegate
{
    public delegate void PrintDelegate();

    public class PrintingService
    {
        public static void Print(PrintDelegate d)
        {
            d();
        }
    }
}