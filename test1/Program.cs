using System.ComponentModel.Design;

namespace test1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int c = x * (-1);
            if (x > b) 
            {
                Console.WriteLine($"Модуль = {x} ");
            }
            else
                if (x < b)
            {
                Console.WriteLine($"Модуль = {c}");
            }
            else;
        }
    }
}
