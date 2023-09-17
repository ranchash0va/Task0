namespace Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int number = r.Next(0, 20) - 10;
            int mathDegree = 3;
            Console.WriteLine("{0}^{1} = {2}", number, mathDegree, NumberInMathDegree(number, mathDegree));
        }

        /// <summary>
        /// Функция возведения в степень целого числа
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="mathDegree">степень</param>
        /// <returns>число в степени</returns>
        static int NumberInMathDegree(int number, int mathDegree)
        {
            return (int)Math.Pow(number, mathDegree);
        }
    }
}