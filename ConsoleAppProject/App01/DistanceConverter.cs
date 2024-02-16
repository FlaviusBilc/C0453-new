using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Convert from one unit of measurement to another
    /// </summary>
    /// <author>
    /// Flavius Bilc
    /// </author>
    public class DistanceConverter
    {

        public const int FeetInMiles = 5280;
        public const double MetresInMiles = 1609.34;
        private double miles;
        private double feet;
        private double metres;



        public void Run()
        {
            MilesToFeet();
            FeetToMiles();
            MilesToMetres();
        }



        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");
            miles = InputDistance("Please enter the number of miles : ");
            CalculateFeet();
            OutputDistance(miles, "miles", feet, "feet");
        }
        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            feet = InputDistance("Please enter the number of feet : ");
            CalculateMiles();
            OutputDistance(feet, "feet", miles, "miles");
        }
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");
            miles = InputDistance("Please enter the number of miles : ");
            CalculateMetres();
            OutputDistance(miles, "miles", metres, "metres");
        }



        private double InputDistance(string prompt)
        {

            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }
        private void CalculateFeet()
        {
            feet = miles * FeetInMiles;
        }
        private void OutputDistance(double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit} ");
        }
        private void CalculateMiles()
        {
            miles = feet / FeetInMiles;
        }
        private void CalculateMetres()
        {
            metres = miles * MetresInMiles;
        }



        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("      Distance Converter");
            Console.WriteLine("      By Flavius Bilc");
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}