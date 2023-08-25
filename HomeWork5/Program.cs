namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5; int y = 10; int z = 15;

            Console.WriteLine("FIRST x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            x += y >> x++ * z;

            Console.WriteLine("SECOND x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            z = ++x & y * 5;

            Console.WriteLine("THIRD x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            y /= x + 5 | z;

            Console.WriteLine("FOURTH x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            z = x++ & y * 5;

            Console.WriteLine("FIFTH x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            x = y << x++ ^ z;

            Console.WriteLine("SIXTH x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

        }
    }
}