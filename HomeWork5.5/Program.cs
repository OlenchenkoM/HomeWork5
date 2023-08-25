namespace HomeWork5._5
{
    internal class Program
    {
        private bool IsPowerOfTwo(int number)
        {
            return number > 0 && (number & -number) == number;
        }

        static void Main(string[] args)
        {
            int a = 9; int b = 10;
        }
    }
}