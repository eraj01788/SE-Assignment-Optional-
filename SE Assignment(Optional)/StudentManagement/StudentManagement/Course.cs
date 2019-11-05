using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
   public class Course
    {
        static int id=0;
        int courseId;
        string courseName;

        public Course(string courseName,int courseFee)
        {
            id++;
            this.CourseId = id;
            this.CourseName = courseName;
        }

        public int CourseId { get => courseId; set => courseId = value; }
        public string CourseName { get => courseName; set => courseName = value; }

        public void PrintCourse()
        {
            Console.WriteLine("Course Id :{0}\nCourse Name :{1}\nCourse Fee :{2}",this.CourseId,this.courseName);
        }
    }
}
