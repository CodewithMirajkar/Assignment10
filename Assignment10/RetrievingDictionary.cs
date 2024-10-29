//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment10
//{
//    internal class RetrievingDictionary
//    {
//        public static void Main()
//        {
//            // Create a dictionary to store student names and their grades
//            Dictionary<string, string> studentGrades = new Dictionary<string, string>();

//            // Add entries to the dictionary
//            studentGrades.Add("Rohit", "A");
//            studentGrades.Add("Sachin", "B+");
//            studentGrades.Add("Virat", "A-");
//            studentGrades.Add("Manoj", "B");
//            studentGrades.Add("Sanjay", "C+");

//            // Prompt the user to enter a student's name
//            Console.WriteLine("Enter the student's name to retrieve their grade:");
//            string studentName = Console.ReadLine();

            
//            if (studentGrades.TryGetValue(studentName, out string grade))
//            {
//                Console.WriteLine($"{studentName}'s grade is: {grade}");
//            }
//            else
//            {
//                Console.WriteLine($"No record found for student: {studentName}");
//            }
//            Console.ReadLine();
//        }
//    }
//}
