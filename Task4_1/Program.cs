namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine("Факториал числа {0} равен {1}", n, f);
            Console.ReadLine();
        }
    }
}
