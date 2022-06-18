/*

 Assignment #2 
 Problem #2
 CS-285
 Austin Pedigo
 June 18th, 2022
 
 Description: 
    This application takes a given value for miles and converts it 
    to feet and kilometers. Afterwards, it displays this information 
    to the console. 

*/

//standard libraries and namespace
using System;
using static System.Console; 

namespace Conversion
{
    class Convert_Mile_To_Ft_Km
    {
        static void Main()
        {
            //initializes miles constant 
            const double miles = 4.5;

            //performs calculations for miles -> ft and miles -> km
            double miles_to_ft = miles * 5280;  
            double miles_to_km = miles * 1.60934;

            //outputs the amount of miles and its equivalent in ft and km 
            WriteLine("{0:F2} miles is {1:F2} kilometers and {2:F0} feet.", 
                miles, miles_to_km, miles_to_ft);
            Write("{0:F2} miles, {1:F2} kilometers, {2:F0} feet.", 
                miles, miles_to_km, miles_to_ft);
            
        }
    }
}

