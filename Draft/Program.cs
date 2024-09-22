namespace Draft
{
    internal class Program
    {
        static void Main()
        {
            int keyA;
            int keyB;
            while (true)
            {
                Console.Write($"Write 1st number to add to another: ");
                string inputA = Console.ReadLine();
                while (!int.TryParse(inputA, out keyA))
                {
                    Console.WriteLine("an integer please");
                }

                Console.Write($"Write 2st number to add : ");
                string inputB = Console.ReadLine();
                while (!int.TryParse(inputB, out keyB))
                {
                    Console.WriteLine("an integer please");
                }
                
                Console.WriteLine($"{inputA} + {inputB} = {Addition(keyA, keyB)}");
            }
            int Addition(int e, int f)
            {
                
                return e + f;
            }
        }
    }
}
