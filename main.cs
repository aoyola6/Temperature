using System;

class Program
{
    static void Main(string[] args)
    {
        int[] temperatures = new int[5];
        bool isValidTemperature;
        double sum = 0;

        for (int i = 0; i < 5; i++)
        {
          int temp;
            do
            {
                Console.Write($"Enter temperature {i + 1} (-30 to 130): ");
              isValidTemperature = Int32.TryParse(Console.ReadLine(), out temp) && temp >= -30 && temp <= 130;
                if (!isValidTemperature)
                {
                    Console.WriteLine("Invalid temperature. Please enter a temperature between -30 and 130.");
                }
            } while (!isValidTemperature);

            temperatures[i] = temp;
            sum += temp;
        }

        string message = DetermineOrder(temperatures)? "Getting warmer" : "Getting cooler";
        if (message == "Getting cooler")
        {
            message = "It’s a mixed bag";
        }

        Console.WriteLine($"\nTemperatures entered: {string.Join(", ", temperatures)}");
        Console.WriteLine($"Average temperature: {(sum / 5).ToString()}°F\n");

        Console.WriteLine(message);
    }

    static bool DetermineOrder(int[] temperatures)
    {
        // Check if temperatures are in ascending order
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            if (temperatures[i] > temperatures[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}
