using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Task
{
    internal class Program
    {
        static void Main(string[] args)         
        {
            // Initialize Data

            List<Student> students = new List<Student>
            {
                new Student("Sahar", 90),
                new Student("Salma", 72),
                new Student("Menna", 60),
                new Student("Alaa", 85),
                new Student("Asma", 42)
            };

            // create instance
            ScoreProcessor Processor = new ScoreProcessor(); 

            // Define Passing Criterias
            ScoreCreteria passingCriteria = s => s.Score >= 50;
            ScoreCreteria fallingCriteria = s => s.Score < 50;

            // Filter and Display Passing Students
            var passingStudents = Processor.FilterStudents(students, passingCriteria);
            Console.WriteLine("Passing Students: ");
            passingStudents.PrintStudentList();

            Console.WriteLine("-------------------------------------");

            // Filter and Display Falling Students
            var fallingStudents = Processor.FilterStudents(students, fallingCriteria);
            Console.WriteLine("\nFalling Student: ");
            fallingStudents.PrintStudentList();

            Console.WriteLine("-------------------------------------");

            // Calculate and display average score
            double avg = Processor.CalculateAverageScore(students);
            Console.WriteLine($"\nAverage Score: {avg}");

            Console.WriteLine("-------------------------------------");

            //	Identify and Display the Top Scorer:
            var topScorer = students.TopScorer();
            if (topScorer != null)
            {
                Console.WriteLine($"\nTop Scorer: {topScorer.Name} with Score: {topScorer.Score}");
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
