namespace spi_mi_se
{
    internal class Program
    {
        static void Main()
        {
            int n = 16;
            bool result = IsPowerOfTwo(n);
            Console.WriteLine(result ? $"{n} е степен на 2." : $"{n} не е степен на 2.");
        }

        static bool IsPowerOfTwo(int n)
        {
            // Ако числото е по-малко или равно на 0, не е степен на 2
            if (n <= 0)
                return false;

            // Ако числото е 1, то е степен на 2
            if (n == 1)
                return true;

            // Ако числото не е делимо на 2, не е степен на 2
            if (n % 2 != 0)
                return false;

            // Рекурсивно проверяваме дали половината от числото също е степен на 2
            return IsPowerOfTwo(n / 2);
        }
    }
}
