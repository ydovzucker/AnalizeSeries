using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static bool isEmpty(string[] listOfString)
        {
            return listOfString.Length < 1;
        }
        static bool notValidArgs(string[] Args)
        {
            int Count = 0;
            foreach (string arg in Args)
            {
                int num = Convert.ToInt32(arg);
                if (num > 0)
                {
                    Count++;
                }
            }
            if (count < 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        
            static string askForSeries()
            {
                string input = Console.ReadLine();
                return input;
            }
            static string[] turnsSeriesToLIst(string seriesOfNums)
            {
                return seriesOfNums.Split(',');
            }
            static void displayListOfStr(string[] listOfStr) {
            foreach (string str in listOfStr) 
            {
                Console.WriteLine(str); 
            }

            static void Main(string[] args)
            {
                if (isEmpty(args) || notValidArgs(args)) { 
                
                    Console.WriteLine("enter a series of numbers");
                    string seriesOfNumbers = askForSeries();
                    args = turnsSeriesToLIst(seriesOfNumbers);
                }
            Console.WriteLine("enter a letter from a-j");
            string selectedLetter = Console.ReadLine();
            
            switch(selectedLetter) {
                case "a":
                    string newSeries = askForSeries();
                    args = turnsSeriesToLIst(newSeries);
                    break;
                 case "b":
                        displayListOfStr(args);
                        break;



            }
        }
    }

