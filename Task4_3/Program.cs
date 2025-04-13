namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, возводимое в степень");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            int b = Convert.ToInt32(Console.ReadLine());
            int p = 1;

            for (int i = 1; i <= b; i++)
            {
                p *= a;
            }
            Console.WriteLine("{0} в степени {1} равно {2}", a, b, p);
            Console.ReadLine();
        }
    }
}
