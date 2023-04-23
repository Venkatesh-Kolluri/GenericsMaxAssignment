namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GenericMaximum<string> strMax = new GenericMaximum<string>("apple", "pineapple", "banana", "orange", "grape");
            Console.WriteLine("Maximum string is: " + strMax.Maximum());

        }
    }
}