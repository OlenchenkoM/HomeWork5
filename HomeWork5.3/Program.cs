using System.Text;

namespace HomeWork5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть змінну");
            int a = int.Parse(Console.ReadLine());
            if (a < 5)
                Console.WriteLine("премія становить 10% від заробітної плати");
            else if (a < 10)
                Console.WriteLine("премія становить 15% від заробітної плати");
            else if (a < 15)
                Console.WriteLine("премія становить 25% від заробітної плати");
            else if (a < 20)
                Console.WriteLine("премія становить 35% від заробітної плати");
            else if (a < 25)
                Console.WriteLine("премія становить 45% від заробітної плати");
            else 
                Console.WriteLine("премія складає 50% від заробітної плати");
        }
    }
}