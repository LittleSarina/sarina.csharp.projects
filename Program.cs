namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            int num03;

            Console.Write("Input a number: ");

            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second Number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a third Number: ");
            num03 = Convert.ToInt32(Console.ReadLine());



            float average = (num01 + num02 + num03) / 3f;
            // Console.WriteLine("The result as a integer is: " + Convert.ToInt32(average));
            // Console.WriteLine("The result as a integer is: " + Convert.ToInt32(average));
            // Console.WriteLine("The result as a decimal is: " + Convert.ToDecimal(average));
            Console.WriteLine("The result as a decimal is: " + average);

            Console.ReadKey();
        }
    }
}

