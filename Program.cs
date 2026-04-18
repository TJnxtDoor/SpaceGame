using System;

public class Program 
{
    static int totalDistance = 0;

    public static void Main() 
    {
        Console.WriteLine("--- Warp Drive Terminal ---");

        while(true) 
        {
            Console.Write("Enter distance or 'exit': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") 
            {
                break; 
            }
            try 
            {
                int dist = int.Parse(input);
                if (dist < 0) {
                    Console.WriteLine("Can't go backwards!");
                } else {
                    totalDistance += dist;
                    Console.WriteLine("Jumped " + dist + " LY. Total: " + totalDistance);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: That's not a valid number.");
            }
        }
    }
}
