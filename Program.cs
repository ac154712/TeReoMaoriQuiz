namespace TeReoMaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank ATM");
            Console.Write("Please enter your language by choosing number;\n1.English\n2.Maori\n3.Samoan\n4.Exit\nType here: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Hello!");
            }
            else if (num == 2)
            {
                Console.WriteLine("kia ora!");
            }
            else if (num == 3)
            {
                Console.WriteLine("talofa!");
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}