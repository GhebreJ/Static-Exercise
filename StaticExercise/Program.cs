namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"10 degrees Celsius is {TempConverter.CelsiusToFahrenheit(10)} Fahrenheit");

            Console.WriteLine($"33 degrees Fahrenheit is {TempConverter.FahrenheitToCelsius(33)} Celsius");

        }
    }
}
