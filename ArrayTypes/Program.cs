
using System;
using System.Text;
public class MainClass
{
    static void SingleDimentionArray()
    {
        int[] a; // decliration
        a = new int[5]; // Instanciation of array in memory (reserving space for it 

        // Initializing Array 
        for (int i = 0; i < 5; i++)
        {
            a[i] = (i + 1) * 10;
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Cell A[{0}] : {1}", i, a[i]);
        }

    }

    static void TwoDimentionArray()
    {
        int[,] tary; // declaration

        tary = new int[3, 3];

        for (int i = 0; i < tary.GetLength(0); i++)
        {
            for (int j = 0; j < tary.GetLength(1); j++)
            {
                tary[i, j] = (i + j + 1) * 10;
            }
        }

        for (int i = 0; i < tary.GetLength(0); i++)
        {
            for (int j = 0; j < tary.GetLength(1); j++)
            {
                Console.Write("{0} ", tary[i, j]);
            }
            Console.WriteLine("");
        }

    }

    static void JaggedArray()
    {
        int rows;
        Console.WriteLine("Input Number of rows of jagged Array : ");
        rows = Convert.ToInt32(Console.ReadLine());

        int[][] jaggedArray = new int[rows][];

        //Assigning column values for each Rows

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Provide column length for row {0} :", i + 1);
            int col;
            col = Convert.ToInt32(Console.ReadLine());
            jaggedArray[i] = new int[col];

        }

        Console.WriteLine("");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine("Give Input To Cell Number [{0}] [{1}] ", i, j);
                jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write("{0} ", jaggedArray[i][j]);
            }
            Console.WriteLine("");
        }

    }

    public static void Main(string[] args)
    {
        //SingleDimentionArray();
        //TwoDimentionArray();
        JaggedArray();
    }
}