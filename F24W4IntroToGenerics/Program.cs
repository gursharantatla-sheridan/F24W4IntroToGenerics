﻿namespace F24W4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing
            int num = 5;
            object obj = num;

            // unboxing
            num = (int)obj;

            //if (AreEqual(5, 5))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");



            int[] intArr = { 2, 3, 4, 5 };
            double[] doubleArr = { 2.2, 3.3, 4.4, 5.5 };
            char[] charArr = { 'h', 'e', 'l', 'l', 'o' };

            PrintArray<int>(intArr);
            PrintArray<double>(doubleArr);
            PrintArray<char>(charArr);
        }

        static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        // standard method
        static bool AreEqual(object a, object b)
        {
            return a.Equals(b);
        }

        // generic method
        static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
