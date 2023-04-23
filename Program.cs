namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxFloat maxFloat = new MaxFloat();
            float floatValue = maxFloat.maximumValue(54.54f, 65.87f, 97.21f);
            Console.WriteLine("The Maximum Int Value is: " + floatValue);

        }
    }
}