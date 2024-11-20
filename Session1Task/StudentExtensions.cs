using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Task
{
    // 3. Add Extension Methods for List<Student>
    public static class StudentExtensions
    {
       // Method to print student list 
        public static void PrintStudentList(this List<Student> students)
        {
            if (students == null) { return; }
            foreach(Student student in students)
            {
                Console.WriteLine($"Name: {student.Name} with Score: {student.Score}");
            }
        }

        // Method to print Top Scorer
        public static Student TopScorer(this List<Student> students)
        {
            if (students.Count == 0)
            {
                return null;
            }
            {
                
            }
            int maxScore = int.MinValue;
            Student topStudent = null;
            foreach(Student student in students)
            {
                if (student.Score > maxScore)
                {
                    maxScore = student.Score;
                    topStudent = student;
                }
            }
            return topStudent;
         
        }
    }
}
