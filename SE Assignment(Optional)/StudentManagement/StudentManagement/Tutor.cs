using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
   public class Tutor : Person
    {
        string qualification;
        int salary;

        public Tutor(int id,string Tutorname,string qualification)
        {
            this.Id = id;
            this.Name = Tutorname;
            this.qualification = qualification;
        }

        public override void AddPayment(int amount)
        {
            salary = amount;
        }
    }
}
