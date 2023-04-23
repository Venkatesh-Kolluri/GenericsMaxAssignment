namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxInt maxInt = new MaxInt();
            int intValue = maxInt.maximumValue(210, 236, 456);
            Console.WriteLine("The Maximum Int Value is: " +intValue);
        }
    }
}