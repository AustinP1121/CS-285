/*

 Assignment #2 
 Problem #8
 CS-285
 Austin Pedigo
 June 19th, 2022
 
 Description: 
    This program calculates a student's culmative grade from a weighted average of 
    their raw grades. After doing so, it outputs a formatted report card.
 
 */
using System;
using static System.Console;

namespace Grades
{
    class CalcGrade
    {
        static void Main()
        {
            //constants declarations 
            const decimal homeworkWght = .10M;
            const decimal projectWght = .35M;
            const decimal quizWght = .10M;
            const decimal examWght = .30M;
            const decimal finalExamWght = .15M; 

            //variable declarations
            decimal homeworkGrade = 97M;
            decimal projectGrade = 82M; 
            decimal quizGrade = 60M;
            decimal examGrade = 75M; 
            decimal finalExamGrade = 80M; 

            //compute weighted grade from average
            decimal wghtedCulmGrade = ((homeworkGrade*homeworkWght) +
                (projectGrade*projectWght) + (quizGrade*quizWght) +
                (examGrade*examWght) + (finalExamGrade*finalExamWght))/100;  
            
            //format and output report card
            WriteLine("\t\t***Student Report Card***\n");
            
            WriteLine("\t\t\tWeights ");
            WriteLine("\t\tHomework Weight: {0,8:P},\n\t\tProjects Weight: {1,8:P},",
                homeworkWght, projectWght);
            WriteLine("\t\tQuizzes Weight: {0,9:P},\n\t\tExams Weight: {1,11:P},",
                quizWght, examWght);
            WriteLine("\t\tFinal Exam Weight: {0:P}", finalExamWght);

            //grades section
            WriteLine("\n\t\t\tGrades");
            WriteLine("\t\tHomework: {0,11},\n\t\tProjects: {1,11},",
                homeworkGrade, projectGrade);
            WriteLine("\t\tQuizzes: {0,12},\n\t\tExams: {1,14},",
                quizGrade, examGrade);
            WriteLine("\t\tFinal Exam: {0,9}\n", finalExamGrade);
            
            //culmative grade
            WriteLine("\t\tCulmative Weighted Grade");
            WriteLine("\t\tGrade: {0,18:P}",wghtedCulmGrade);
            ReadKey();
        }
    }
}
