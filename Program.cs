namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxGenericValue maxGenericValue = new MaxGenericValue();
            int MaxValue = maxGenericValue.maximumValue(24, 65, 87);
            Console.WriteLine("The maximum Value is: " + MaxValue);

        }
    }
}