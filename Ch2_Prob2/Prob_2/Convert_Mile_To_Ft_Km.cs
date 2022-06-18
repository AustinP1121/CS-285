/* 



*/

using System;
using static System.Console; 

namespace Conversion
{
    class Convert_Mile_To_Ft_Km
    {
        static void Main()
        {

            const double miles = 4.5;

            double miles_to_ft = miles * 5280;  
            double miles_to_km = miles * 1.60934;

            WriteLine("{0:F2} miles is {1:F2} kilometers and {2:F0} feet.", miles, miles_to_km, miles_to_ft);
            Write("{0:F2} miles, {1:F2} kilometers, {2:F0} feet.", miles, miles_to_km, miles_to_ft);
            
        }
    }
}

