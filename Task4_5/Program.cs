namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число из диапазона от 20 до 60 включительно");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a < 20 || a > 60)
            {
                Console.WriteLine("Введите корректное число");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Число введено корректное");
            Console.ReadKey();
        }
    }
}
