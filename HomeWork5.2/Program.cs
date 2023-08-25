namespace HomeWork5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть змінну");
            int a;
            a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
                Console.WriteLine("Парне");
            else
                Console.WriteLine("Непарне");
        }
    }
}