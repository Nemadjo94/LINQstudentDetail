using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQstudentDetails
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public List<int> Marks;

        public ContactInfo GetContactInfo(Program pg, int id)
        {
            ContactInfo allInfo = 
                (from ci in pg.contactList
                 where ci.ID == id
                select ci).FirstOrDefault();

            return allInfo;
        }

        private void ReturnMarks()
        {
            foreach(int s in Marks)
            {
                Console.Write(s.ToString() + " ");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName} {LastName}");
            Console.WriteLine($"ID: {ID}");
            Console.Write("Marks: ");
            ReturnMarks();
            Console.WriteLine("\n");
        }    
    }

}
