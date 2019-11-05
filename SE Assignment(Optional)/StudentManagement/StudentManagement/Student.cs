using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
   public class Student : Person
    {
        string schoolcollage;
        int tutionFee;

        public Student(int sId,string studentName,string schoolcollage)
        {
            this.Id = sId;
            this.Name = studentName;
            this.schoolcollage = schoolcollage;
        }

        public override void AddPayment(int amount)
        {
            this.tutionFee = amount;
        }

        public string School_collage { get => schoolcollage; set => schoolcollage = value; }
        public int TutionFee { get => tutionFee; set => tutionFee = value; }


    }
}
