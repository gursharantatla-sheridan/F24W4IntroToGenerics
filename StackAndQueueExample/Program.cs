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


            // Queue Example
            Console.WriteLine("\n\n\nQueue Example\n");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            //num = queue[1];

            Console.WriteLine("Total items: " + queue.Count);

            foreach (int i in queue)
                Console.WriteLine(i);

            num = queue.Dequeue();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal items: " + queue.Count);

            foreach (int i in queue)
                Console.WriteLine(i);

            num = queue.Peek();
            Console.WriteLine("\nNum = " + num);

            Console.WriteLine("\nTotal items: " + queue.Count);

            foreach (int i in queue)
                Console.WriteLine(i);
        }
    }
}
