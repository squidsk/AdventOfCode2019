/*
 * Created by SharpDevelop.
 * User: Steve
 * Date: 12/10/2019
 * Time: 1:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string fileContents = File.ReadAllText("input.txt");
            string[] temp = fileContents.Split(',');
            int[] code = new int[temp.Length];
            
            for(int i = 0; i < temp.Length; i += 1) {
                code[i] = int.Parse(temp[i]);
            }
            
            code[1] = 12;
            code[2] = 2;
            
            for(int i = 0; i < code.Length; i += 4) {
                if(code[i] == 1) {
                    code[code[i+3]] = code[code[i+1]] + code[code[i+2]];
                } else if (code[i] == 2) {
                    code[code[i+3]] = code[code[i+1]] * code[code[i+2]];
                } else //if(code[i] == 99)
                    break;
            }
            Console.WriteLine(string.Format("The value at position 0 is: {0}", code[0]));
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}