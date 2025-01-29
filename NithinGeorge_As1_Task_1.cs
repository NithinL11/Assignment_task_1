/*
 * Author: <Nithin George Lorance>
 * Date: <23-01-2025>
 * Project: <Carol's Travel Expenses>
 * 
 * Description:
 * <This program calculates the total money spent by Carlo ,the average price of the trip he took and 
 * Carlo lives in Toronto and must return to his native town after each trip >
*/

using System;

namespace AssignmentOne
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Define ticket prices for each destination, afer each trip he return to native town charges will be doubled
            double calgaryPrice = 1350 * 2;
            double vancouverPrice = 1500 * 2;
            double montrealPrice = 575 * 2;

            // Get the number of trips for Calgary
            Console.Write("Enter the number of trips to Calgary: ");
            int calgaryTrips = int.Parse(Console.ReadLine());

            // Get the number of trips for Vancouver
            Console.Write("Enter the number of trips to Vancouver: ");
            int vancouverTrips = int.Parse(Console.ReadLine());

            // Get the number of trips for Montreal
            Console.Write("Enter the number of trips to Montreal: ");
            int montrealTrips = int.Parse(Console.ReadLine());

            // Calculate total cost based on the number of trips to each destination
            double totalCost = (calgaryTrips * calgaryPrice) + (vancouverTrips * vancouverPrice) + (montrealTrips * montrealPrice);

            // Calculate total number of trips
            int totalTrips = calgaryTrips + vancouverTrips + montrealTrips;

            // Calculate the average cost per trip
            double averageCost = totalTrips > 0 ? totalCost / totalTrips : 0;

            // Display the total cost and average cost per trip
            Console.WriteLine("\n--- Travel Expenses Report ---");
            Console.WriteLine("Total money spent: " + totalCost);
            Console.WriteLine("Average price per trip: " + averageCost);
        }
    }
}