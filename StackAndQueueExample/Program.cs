namespace StackAndQueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack Example
            Console.WriteLine("Stack Example\n");

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //int num = stack[1];

            Console.WriteLine("Total items: " + stack.Count);

            foreach (int i in stack)
                Console.WriteLine(i);

            int num = stack.Pop();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal items: " + stack.Count);

            foreach (int i in stack)
                Console.WriteLine(i);


            num = stack.Peek();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal items: " + stack.Count);

            foreach (int i in stack)
                Console.WriteLine(i);
        }
    }
}
