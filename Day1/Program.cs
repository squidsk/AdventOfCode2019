/*
 * Created by SharpDevelop.
 * User: Steve
 * Date: 12/9/2019
 * Time: 11:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Day1
{
    class Program
    {
        public static void Main(string[] args)
        {
            using(StringReader reader = new StringReader(File.ReadAllText("input.txt"))) {
                int totalFuel = 0;
                int currentModuleFuel = 0;
                string moduleMass;
                while((moduleMass = reader.ReadLine()) != null) {
                    currentModuleFuel = (int.Parse(moduleMass) / 3) - 2;
                    totalFuel += currentModuleFuel;
                }
                Console.WriteLine(string.Format("Total Fuel Cost is: {0}", totalFuel));
            }
            
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}