
public class MainClass
{
    static void ArrayOperation()
    {
        int[] a = { 6, 7, 3, 2, 51, 12, 5 };
        // Sorting Array 
        Array.Sort(a);

        foreach (int ele in a)
        {
            Console.Write("{0} ", ele);
        }

        Console.WriteLine("\n");

        // Reversing Array Values 
        Array.Reverse(a);
        foreach (int ele in a)
        {
            Console.Write("{0} ", ele);
        }

        // Copy Values of an array to another array 
        int[] b = new int[a.Length];
        Array.Copy(a, b, a.Length);

        Console.WriteLine("\n");

        foreach (int ele in a)
        {
            Console.Write("{0} ", ele);
        }


        // Check Array For Reference  Equality 
        bool eq = object.ReferenceEquals(a, b);
        Console.WriteLine(eq);

    }

    public static void Main(string[] args)
    {
        ArrayOperation();
    }
}