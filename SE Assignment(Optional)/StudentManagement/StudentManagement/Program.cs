using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course("HSC 1ST", 5000);
            Person t1 = new Tutor(10, "Eraj", "Honors");
            Person t2 = new Tutor(11, "Muntasir", "Honors");
            Person s1 = new Student(3, "Rahim", "Model Collage");
            Person s2 = new Student(5, "Kahim", "Kamarujjaman Collage");
            Person s3 = new Student(4, "Lahim", "City Collage");
            Person s4 = new Student(6, "Fahim", "Model Collage");
            Batch b1 = new Batch(101, "ABC");
            b1.AddStudent(s1,s2);
            b1.AddTutor(t1);
            b1.ShowBatch();
            Console.WriteLine();
            Console.WriteLine();
            Batch b2 = new Batch(102, "DEF");
            b2.AddStudent(s3, s4);
            b2.AddTutor(t2);
            b2.ShowBatch();
        }
    }
}
