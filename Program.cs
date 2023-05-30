namespace TempatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Welcome to the Tempature Converter");
            Console.WriteLine("--------------------");
            bool QuitProgram = false;
            while (!QuitProgram)
            {
                Console.WriteLine("Please enter a tempature value and scale (C or F) to convert.");
                Console.WriteLine("Write Q to quit the program.");
                Console.WriteLine("Use format: 32 F");
                Console.WriteLine("Please give you input now:");
                string? input = Console.ReadLine();
                if (input != null && input.ToUpper() == "Q")
                {
                    QuitProgram = true;
                    Console.WriteLine("Thank you for using the Tempature Converter!");
                    Console.WriteLine("--------------------");
                    continue;
                }
                if (input == null)
                {
                    Console.WriteLine("You must enter a tempature and scale!");
                    Console.WriteLine("--------------------");
                    continue;
                }
                string[] inputParts = input.Split(' ');
                if (inputParts.Length != 2)
                {
                    Console.WriteLine("Invalid input format. Please enter both temperature value and scale!");
                    Console.WriteLine("--------------------");
                    continue;
                }
                if (!double.TryParse(inputParts[0], out var temperature))
                {
                    Console.WriteLine("Invalid temperature value. Please enter a valid numeric value!");
                    Console.WriteLine("--------------------");
                    continue;
                }
                if (!(inputParts[1] is string scale))
                {
                    Console.WriteLine("Invalid scale. Please enter either 'C' or 'F'.");
                    Console.WriteLine("--------------------");
                    continue;
                }
                Converter converter = new Converter();
                converter.TempConvert(temperature, scale);
            }
        }
    }
}

