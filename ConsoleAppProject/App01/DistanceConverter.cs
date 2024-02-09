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

        private double miles;
        private double feet;
        private double metres;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            MilesToFeet();
            FeetToMiles();
            MilesToMetres();
        }
        /// <summary>
        /// 
        /// </summary>
        /// 


        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading();
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }




        private void OutputHeading()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Miles to feet converter");
            Console.WriteLine("By Flavius Bilc");
            Console.WriteLine("-----------------------------\n");
        }
        private void InputMiles()
        {
            
            Console.Write("Please enter the number of miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " Miles is " + feet + " feet!");
        }


        private void InputFeet()
        {
            Console.Write("Please enter the number of feet: ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void CalculateMiles()
        {
            miles = feet / 5280;
        }

        public void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }


        private void CalculateMetres()
        {
            metres = miles * 1609.34;
        }

        public void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres!");
        }
    }
}
