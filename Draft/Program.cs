namespace Draft
{
    internal class Program
    {
        static void Main()
        {

            while (true)
            {                

                Console.Write($"Write your string, and I will reverse it: ");
                string inputA = Console.ReadLine();
                if (inputA == "x") return;

                Console.WriteLine(inputA.Reverse().ToArray());
            }
        }
    }
}

