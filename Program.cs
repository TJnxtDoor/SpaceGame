using System;

public class Program 
{
    static int totalDistance = 0;

    public static void Main() 
    {
        Console.WriteLine( "Enter jump distance in Light Years (LY).");
        Console.WriteLine("Type 'exit' to power down the engines.");

        while(true) 
        {
            Console.Write("\n> Enter Jump Distance: ");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") 
            {
                Console.WriteLine($"\nFinal Log: Total distance covered: {totalDistance} LY.");
                Console.WriteLine("Engines powered down. Safe travels, Captain.");
                break; 
            }

            try 
            {        
                int dist = int.Parse(input);

                if (dist < 0) 
                {
                    Console.WriteLine("![NAV ERROR]: Negative distance? We aren't going back in time.");
                } 
                else 
                {
                    totalDistance += dist;
                    Console.WriteLine($"Jump successful! +{dist} LY. [Current Odometer: {totalDistance} LY]");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("![SYSTEM ERROR]: Invalid coordinates. Please enter a whole number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("![SYSTEM ERROR]: Jump distance too large for ship's computer to calculate.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"![CRITICAL ERROR]: {ex.Message}");
            }
        }
    }
}