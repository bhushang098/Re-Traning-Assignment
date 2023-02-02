using DelegateLibrary;

namespace PrinterLibrary
{
    public class Printer
    {
        public static void Print(PrintDelegate p)
        {
            p();
        }
    }
}