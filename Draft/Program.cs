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

                //Console.Clear();
                Console.Write($"Write 1st number to add to another: ");
                string inputA = Console.ReadLine();

                if (!int.TryParse(inputA, out keyA))
                {
                    Console.WriteLine("Enter an integer please");
                }


                Console.Write($"Write 2st number to add : ");
                string inputB = Console.ReadLine();

                if (!int.TryParse(inputB, out keyB))
                {
                    Console.WriteLine("Enter an integer please");
                }

                Console.WriteLine($"{keyA} + {keyB} = {Addition(keyA, keyB)}");

            }
                //Console.WriteLine("enter x to end");
                //char end = Console.ReadKey().KeyChar;

                //if (end == 'x') return;

            int Addition(int e, int f)
            {
                int result = e + f;


                return result;
            }
        }
    }
}

