using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Is it leap year?");
            Console.WriteLine("Write any year, please.");
            
            string year = Console.ReadLine();
            
            int chosenYear = 0;
            
            Int32.TryParse(year, out chosenYear);
            if (chosenYear == 2016) 
            {
                Console.WriteLine("Yes, 2016 year is leap.");
            }
            else
            {
                Console.WriteLine($"No, {chosenYear} year is not leap.");
            }
        }
    }

}
