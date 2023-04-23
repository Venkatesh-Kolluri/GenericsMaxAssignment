namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintMaxValue<int> integerMax = new PrintMaxValue<int>(1, 2, 3, 4, 5);
            integerMax.Maximum();

        }
    }
}