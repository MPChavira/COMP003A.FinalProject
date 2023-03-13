/*
 * Author: Michael Perez Chavira
 * Course: COMP003A
 * Purpose: New Patients Health Form
 */
using System.Text.RegularExpressions;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("New Patients Health History Form");

            Console.WriteLine("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            int birthYear;
            do
            {
                Console.WriteLine("Enter your birth year: ");
            } while (!int.TryParse(Console.ReadLine(), out birthYear));
            Console.WriteLine("Enter your gender (M/F/O): ");
            string genderInput = Console.ReadLine();
            if (genderInput == "M")
            {
                genderInput = "Male";
            }
            else if (genderInput == "F")
            {
                genderInput = "Female";
            }
            else if (genderInput == "O")
            {
                genderInput = "Other";
            }
            else
            {
                genderInput = "Unknown";
            }
            SectionSeparator("Please answer the following questions below: ");
            List<string> questionnaire = PatientResponse();
            SectionSeparator("Patient Form Summary: ");
            Console.WriteLine($"Name: {lastName}, {firstName}");
            Console.WriteLine($"Age: {DateTime.Now.Year - birthYear}");
            Console.WriteLine($"Gender: {genderInput}");
            Console.WriteLine("Questionnaire Responses:");
            for (int i = 0; i < questionnaire.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questionnaire[i]}");
            }
        }
        static void SectionSeparator(string sectionName)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{sectionName}");
            Console.WriteLine("".PadRight(50, '*'));
        }
        /// <summary>
        /// Gets the user response for the questions
        /// </summary>
        /// <param name="patient response">response</param>>
        /// <returns>The patients responses</returns>
        static List<string> PatientResponse()
        {
            List<string> response = new List<string>();
            string[] questions = new string[]
            {
                "What brings you in today?: ",
                "When was your last doctor visit?: ",
                "What was the reason for your visit?: ",
                "Do you consume alcohol?: ",
                "Do you smoke?: ",
                "Do you exercise regularly?: ",
                "Are you allergic to any medications?:",
                "Are you taking any medications?: ",
                "What is your family health history?: ",
                "Did you have any past surgical procedures?: ",
            };
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"{questions[i]}");
                string userResponse = Console.ReadLine();
                response.Add(userResponse);
            }
            return response;
        }

        
       
    }
}