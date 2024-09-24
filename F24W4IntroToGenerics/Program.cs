namespace F24W4IntroToGenerics
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
