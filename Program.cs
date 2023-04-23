namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MaxGenValue<string> max = new MaxGenValue<string>("Welcome", "Every", "One");
            Console.WriteLine("The maximum value is: " + max.maximumValue());

        }
    }
}