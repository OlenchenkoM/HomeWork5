namespace HomeWork5._4
{

    internal class Program
    {
        public static bool IsPowerOfTwo(int number)
        {
            return number > 0 && (number & -number) == number;
        }

        static void Main(string[] args)
        {
            int a = 10;
            if (IsPowerOfTwo(a))
                Console.WriteLine("Є степенем двійки");
            else
                Console.WriteLine("Не є степенем двійки");
        }
    }
}