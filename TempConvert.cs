namespace TempatureConverter
{
    public class Converter
    {
        public double TempConvert(double temperature, string scale)
        {
            double convertedTemperature = 0.0;
            scale = scale.ToLower();
            switch (scale)
            {
                case "c":
                    convertedTemperature = (temperature - 32) * 5 / 9;
                    Console.WriteLine("The temperature in Celsius is: " + convertedTemperature);
                    Console.WriteLine("--------------------");
                    break;
                case "f":
                    convertedTemperature = (temperature * 9 / 5) + 32;
                    Console.WriteLine("The temperature in Fahrenheit is: " + convertedTemperature);
                    Console.WriteLine("--------------------");
                    break;
            }
            return convertedTemperature;
        }
    }
}
