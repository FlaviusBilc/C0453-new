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

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// 
        /// </summary>


        private void OutputHeading()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Miles to feet converter");
            Console.WriteLine("By Flavius Bilc");
            Console.WriteLine("-----------------------------");
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
    }
}
