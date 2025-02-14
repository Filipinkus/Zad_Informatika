namespace spi_mi_se
{
    internal class Program
    {
        static void Main()
        {
            int n = 9;
            bool result = IsPowerOfTwo(n);
            if (result)
            {
                Console.WriteLine(n + " е степен на 2.");
            }
            else
            {
                Console.WriteLine(n + " не е степен на 2.");
            }
        }

        static bool IsPowerOfTwo(int n)
        {            
            if (n <= 0)
            {
                return false;
            }
                      
            if (n == 1)
            {
                return true;
            }       
            if (n % 2 != 0)
            {
                return false;
            }
            return IsPowerOfTwo(n / 2);
        }
    }
}
