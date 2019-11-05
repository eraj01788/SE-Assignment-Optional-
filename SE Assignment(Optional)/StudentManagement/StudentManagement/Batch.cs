using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
   public class Batch
    {
        static int count = 0;
        int batchId;
        string batchName;
        Person[] student = new Student[6];
        Person[] tutor = new Tutor[2];

        public Batch(int batchId,string batchName)
        {
            this.BatchId = batchId;
            this.BatchName = batchName;
            count++;
        }

        public int BatchId { get => batchId; set => batchId = value; }
        public string BatchName { get => batchName; set => batchName = value; }
        public Person[] Student { get => student; set => student = value; }
        public Person[] Tutor { get => tutor; set => tutor = value; }

        public void AddStudent(params Person[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                if (this.student[i] == null)
                {
                    this.student[i] = student[i];
                    
                }
            }
        }

        public void AddTutor(params Person[] tutor)
        {
            for (int i = 0; i < tutor.Length; i++)
            {
                if (this.tutor[i] == null)
                {
                    this.tutor[i] = tutor[i];
                    
                }
            }
        }

        public void ShowBatch()
        {
            Console.WriteLine("Batch---------------------");
            Console.WriteLine();
            Console.WriteLine("Batch Id :"+this.batchId+"\n"+"Batch Name :"+this.batchName);
            Console.WriteLine();
            Console.WriteLine("Teacher-------------------");
            Console.WriteLine();
            tutor[0].Show();
            Console.WriteLine();
            Console.WriteLine("Student-------------------");
            Console.WriteLine();
            for (int i = 0; i < this.student.Length; i++)
            {
                if(this.student[i]!=null)
                student[i].Show();

            }
        }

    }
}
