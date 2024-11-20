using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session1Task.Student;

namespace Session1Task
{
    public class ScoreProcessor
    {
        //  Method to Filter a list of students by a specific criterion
        
        public List<Student> FilterStudents(List<Student> students, ScoreCreteria criteria)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in students)
            {
                if (criteria(student))
                {
                    result.Add(student);
                }
            }
            return result;  
        }

        // Method takes a list of student and Calculate the average of thier scores  
        public double CalculateAverageScore(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("No Students.");
                return 0;
            }
          
            // for each student s in the list students .. take their score 
            return students.Average(s => s.Score);
        }

    }
}
