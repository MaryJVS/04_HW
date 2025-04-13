namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, возводимое в степень");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите отрицательную степень числа");
            int b = Convert.ToInt32(Console.ReadLine());
            int absoluteB = -b;
            double p = 1;

            for (int i = 1; i <= absoluteB; i++)
            {
                p *= 1/a;
            }
            Console.WriteLine("{0} в степени {1} равно {2}", a, b, p);
            Console.ReadLine();
        }
    }
}
