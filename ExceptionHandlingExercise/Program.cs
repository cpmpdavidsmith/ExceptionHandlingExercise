﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c'};
            // Create a list called numbers that will hold integers
            var numbers = new List<int>();
            // Create an string variable with an empty string initializer - name it str
            var str = "";
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()

            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array

            // Now create a try catch


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);//no need to explicitely declear number or the int parse because already declared above 
                    numbers.Add(number);//this is from "THEN ADD EACH INT TO YOUR LIST"
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");//item because we are inside the for each loop vs str
                }
                //int.Parse(item);
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //character will be the name of each item in your collection




        }
    }
}
