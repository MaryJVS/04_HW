namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            double f = 0;

            for (double i = 1; i <= n; i++)
            {
                f += 1/i;
            }
            Console.WriteLine("Сумма дробей равна {0}", f);
            Console.ReadLine();
        }
    }
}
