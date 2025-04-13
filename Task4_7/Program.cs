namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int i = 0;

            while (m > 0)
            {
                m = m / 10;
                i++;
            }

            Console.WriteLine("Введенное число {0} состоит из {1} цифр.", n, i);
            Console.ReadKey();

        }
    }
}
