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
        
        static bool isEmpty(string[] listOfString) //. checks if the list of strings is empty
        {
            return listOfString.Length < 1;
        }
        static bool isValidArgs(string[] Args) // checks if the series does not have  three positive numbers 
        {
            bool isValid = true;

            int Count = 0;
            foreach (string Arg in Args)
            {
                if (int.TryParse(Arg, out int num) == false)
                {
                    isValid = false;
                    break;
                }
                else
                {
                    if (num > 0)

                    {
                        Count++;

                    }
                }
            }
             if (Count < 3)
             {
                  isValid = false;
             }
                
             return isValid;

        }
        

        static string askForSeries() // asks the user to enter a series of numbers
        {
            string input = Console.ReadLine();
            return input;
        }
        static string[] turnsSeriesToLIst(string seriesOfNums) //. turns the series of numbers into a list of strings
        {
            return seriesOfNums.Split(' ');
        }
        static void displayListOfStr(string[] listOfStr) //. displays the list of strings
            {
                foreach (string str in listOfStr)
                {
                    Console.WriteLine(str);
                }
            }
        static string maxValueOfSeries(string[] listString) //. finds the max value of the series
         {
                int maxValue = Convert.ToInt32(listString[0]);
                for (int i = 0; i < listString.Length; i++)
                {
                    int num = Convert.ToInt32(listString[i]);
                    if (num > maxValue)
                    {
                        maxValue = num;
                    }
                }
                return Convert.ToString(maxValue);
        }
        static string minValueOfSeries(string[] arrayOfString)
        {
                int minValue = Convert.ToInt32(arrayOfString[0]);
                for (int i = 0; i < arrayOfString.Length; i++)
                {
                    int num = Convert.ToInt32(arrayOfString[i]);
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }
                return Convert.ToString(minValue);
        }

        static void displayReverseList(string[] listOfStr) // displays the list of strings in reverse order
        {
            for (int i = listOfStr.Length - 1; i >= 0; i -= 1)
            {
                Console.WriteLine(listOfStr[i]);

            }

        }
        static string[] sortListOfNumbers(string[] listOfString) //. sorts the list of strings in ascending order

        { 
                int[] nums = new int[listOfString.Length];
                string[] sortedList = new string[listOfString.Length];
                for (int i = 0; i < listOfString.Length; i++)
                {
                    nums[i] = Convert.ToInt32(listOfString[i]);
                }
                Array.Sort(nums);
                int[] sortedArray = nums;
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    sortedList[i] = Convert.ToString(sortedArray[i]);
                }

                return sortedList;
        }
        static int lenOfList(string[] listOfanyStr) //. counts the number of elements in the list of strings
            {
                int count = 0;
                foreach (string str in listOfanyStr)
                {
                    count++;
                }
                return count;
            }
        static int sumOfList(string[] anyListOfStr) // sums the elements of the list of strings
        {
                int sum = 0;
                foreach (string str in anyListOfStr)
                {
                    int num = Convert.ToInt32(str);
                    sum += num;
                }
                return sum;
            
            
        }
        static double avregeOfList(string[] anyArrayOfStr)// calculates the average of the elements in the list of strings
                {
               int sumOfarray = sumOfList(anyArrayOfStr);
                double len = lenOfList(anyArrayOfStr);
                double  average = (double)sumOfarray / len;
                return average;
        }




        static void Main(string[] args) // main method
        {
            while (true)
            {
                Console.WriteLine("welcome to the series of numbers program");
                Console.WriteLine("please enter a series of numbers");

                if (isEmpty(args) || !isValidArgs(args))
                {

                    Console.WriteLine("please enter a series of numbers");
                    string seriesOfNumbers = askForSeries();
                    args = turnsSeriesToLIst(seriesOfNumbers);
                }
                else
                {
                    break;
                }
            }

            do
            {
                Console.WriteLine("enter a letter from a-j");
                string selectedLetter = Console.ReadLine();

                switch (selectedLetter)
                {
                    case "a":
                        string newSeries = askForSeries();
                        args = turnsSeriesToLIst(newSeries);
                        break;
                    case "b":
                        displayListOfStr(args);
                        break;
                    case "c":
                        displayReverseList(args);
                        break;
                    case "d":
                        string[] sortedList = sortListOfNumbers(args);
                        displayListOfStr(sortedList);
                        break;
                    case "e":
                        string maxValue = maxValueOfSeries(args);
                        Console.WriteLine(maxValue);
                        break;
                    case "f":
                        string minValue = minValueOfSeries(args);
                        Console.WriteLine(minValue);
                        break;
                    case "g":
                        double avrege = avregeOfList(args);
                        Console.WriteLine(avrege);
                        break;

                    case "h":
                        int numberOfElements = lenOfList(args);
                        Console.WriteLine(numberOfElements);
                        break;
                    case "i":
                        int sumOfSeries = sumOfList(args);
                        Console.WriteLine(sumOfSeries);
                        break;
                    case "j":
                        Console.WriteLine("goodbye");
                        break;

                    default:
                        Console.WriteLine("invalid input.you must enter a letter between a -j");
                        break;

                }



             if (selectedLetter != "j")
                        {
                            break;
                        }

            } while (true);



             
            }
        }
    }
