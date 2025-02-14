namespace zad_3
{
    internal class Program
    {
        static int Reverse(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return int.Parse(n % 10 + "" + Reverse(n / 10));
            }
        }

        static void Main()
        {
            int number = 911;
            int reversedNumber = Reverse(number);
            Console.WriteLine(reversedNumber);  
        }
    }
}
