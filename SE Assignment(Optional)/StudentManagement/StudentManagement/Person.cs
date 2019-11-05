using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
   public abstract class Person
    {
        int id;
        string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public abstract void AddPayment(int amount);
        public virtual void Show()
        {
            Console.WriteLine("Id :{0}\nName :{1}",this.id,this.name);
        }
    }
}
