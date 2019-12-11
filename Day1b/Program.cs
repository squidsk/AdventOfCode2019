/*
 * Created by SharpDevelop.
 * User: Steve
 * Date: 12/10/2019
 * Time: 8:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Day1b
{
    class Program
    {
        public static void Main(string[] args)
        {
            using(StringReader reader = new StringReader(File.ReadAllText("input.txt"))) {
                int totalFuel = 0;
                int currentModuleFuel = 0;
                string moduleMassAsString;
                while((moduleMassAsString = reader.ReadLine()) != null) {
                    int moduleMass = int.Parse(moduleMassAsString);
                    while(moduleMass >= 6) {
                        currentModuleFuel = ( moduleMass / 3) - 2;
                        //Console.WriteLine(string.Format("Mass: {0}, Fuel {1}", moduleMass, currentModuleFuel));
                        totalFuel += currentModuleFuel;
                        moduleMass = currentModuleFuel;
                    }
                }
                Console.WriteLine(string.Format("Total Fuel Cost is: {0}", totalFuel));
            }
            
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}