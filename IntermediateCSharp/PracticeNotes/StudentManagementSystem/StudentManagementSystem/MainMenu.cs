﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.Workflows;

namespace StudentManagementSystem
{
    public class MainMenu
    {
         

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Student Management System");
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine("1. List Students");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Edit Student GPA");
            Console.WriteLine("");
            Console.WriteLine("Q - Quit");
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine("");
            Console.WriteLine("Enter Choice: ");
        }

        private static bool ProcessChoice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ListStudentWorkflow workflow = new ListStudentWorkflow();
                    workflow.Execute();
                    break;
                case "2":
                    Console.WriteLine("Add Student");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Remove Student");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Edit student");
                    Console.ReadKey();
                    break;
                case "Q":
                    return false;
                default:
                    Console.WriteLine("That is not a valid choice.  Press any key to continue...");
                    Console.ReadKey();
                    break;
            }

            return true;
        }

        public static void Show()
        {
            bool continueRunning = true;
            while(continueRunning)
            {

                DisplayMenu();
                continueRunning = ProcessChoice();
 
            
            }
        }
    }
}
