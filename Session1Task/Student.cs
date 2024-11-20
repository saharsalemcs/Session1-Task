using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Task
{
    // Define a delegate to represent whether the student meets a particular score or not 
    public delegate bool ScoreCreteria(Student student); 


    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
  

    }
}
