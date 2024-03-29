﻿/* 
 * Author: Ethen Gonzalez
 * Course: COMP-003A
 * Purpose: Replicate output provided by instructor
 */

using System.Transactions;

namespace COMP003A.Assignment2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("**************************************************");
            Console.Title = ("COMP-003A - Assignment 2");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("**************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("**************************************************");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: "); 
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Age in 2023: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("**************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("**************************************************");
            Console.Write("Enter an integer for integer1: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer for integer2: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("**************************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("**************************************************");
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The area is: {area}");
            Console.WriteLine($"The circumference is: {circumference}");
        }
    }
}
