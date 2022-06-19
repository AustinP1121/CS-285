/*
 Assignment #2 
 Problem #6
 CS-285
 Austin Pedigo
 June 19th, 2022
 
 Description: 
    This application calculates the take-home pay of an employee after deducting
    various costs from their gross pay. The employee's earnings are computed from their
    overall commision of their total sales. After, the secondary costs, such as various 
    taxes and retirement funds, are deducted to calculate the employee's total pay.
     
*/

using System;
using static System.Console; 

namespace Pay
{
    class TakeHomePay
    {
        static void Main()
        {

            const string employeeName = "Joshua Montain";
            const decimal grossSales = 161432M;
            const decimal commission = .07M;
            decimal earnings = grossSales * commission; 
            decimal fedTax = earnings * .18M;
            decimal retireFund = earnings * .10M; 
            decimal socialSec = earnings * .06M;
            
            decimal totalDeductions = fedTax + retireFund + socialSec;
            decimal totalPay = earnings - totalDeductions;

            WriteLine("\t\t***Employee Pay Report***\n");
            WriteLine("Employee: {0}\n\tTotal Sales: {1,-40:C}\n\tEarnings: {2,13:C}", 
                employeeName, grossSales, earnings);
            WriteLine("\tDeductions:\n\t\tFederal Tax this period: {0,12:F2},\n\t\tRetirement Fund Deduction: {1,10:F2},\n\t\tSocial Security: {2,19:F2},", 
                fedTax, retireFund, socialSec); 
            WriteLine("\t\tTotal Deductions this period: {0:F2}", totalDeductions);
            WriteLine("\tTotal Take-Home Pay after Deductions: {0:C}", totalPay);
            ReadKey();

        }
    }
}
