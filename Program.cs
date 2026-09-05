namespace My_Awesome_Program
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", nice to meet ya :3");

            Console.ReadKey();
        }
    }
}
