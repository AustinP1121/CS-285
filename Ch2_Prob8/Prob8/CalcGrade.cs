/*

 Assignment #2 
 Problem #8
 CS-285
 Austin Pedigo
 June 19th, 2022
 
 Description: 
 
 
 */
using System;
using static System.Console;

namespace Grades
{
    class CalcGrade
    {
        static void Main()
        {

            const decimal homeworkWght = .10M;
            const decimal projectWght = .35M;
            const decimal quizWght = .10M;
            const decimal examWght = .35M;
            const decimal finalExamWght = .15M; 

            decimal homeworkGrade = 97M;
            decimal projectGrade = 82M; 
            decimal quizGrade = 60M;
            decimal examGrade = 75M; 
            decimal finalExamGrade = 80M; 

            decimal wghtedCulmGrade = ((homeworkGrade*homeworkWght) +
                (projectGrade*projectWght) + (quizGrade*quizWght) +
                (examGrade * examWght) + (finalExamGrade*finalExamWght));  
            Write(wghtedCulmGrade);
        //display the values, along with the weights

        }
    }
}
