namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            int i = 0;

            while (m < n)
            {
                m *= 2;
                i++;
            }
            
            if (m == n) 
            {
                Console.WriteLine("Введенное число является степенью 2-ки");
            }
            else
            {
                Console.WriteLine("Введенное число НЕ является степенью 2-ки");
            }
            Console.WriteLine();
            Console.WriteLine("Проверка: Введенное число {0}. 2 возводим в степень {1} и получаем {2}",n, i, Math.Pow(2, i));
            Console.ReadKey();
        }
    }
}
