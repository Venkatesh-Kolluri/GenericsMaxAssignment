namespace GenericsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxString maxString = new MaxString();
            String strValue = maxString.maximumValue("Hello", "World", "Welcome");
            Console.WriteLine("The Maximum String Value is: " + strValue);

        }
    }
}