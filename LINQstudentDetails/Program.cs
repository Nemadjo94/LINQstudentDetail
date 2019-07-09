using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQstudentDetails
{
    public class Program
    {
        List<Student> students = new List<Student>()
        {
             new Student {FirstName="Tom", LastName="S.", ID=1,
                          Marks= new List<int>() {97, 92, 81, 60}},
             new Student {FirstName="Jerry", LastName="M.", ID=2,
                          Marks= new List<int>() {75, 84, 91, 39}},
             new Student {FirstName="Bob", LastName="P.", ID=3,
                          Marks= new List<int>() {88, 94, 65, 91}},
             new Student {FirstName="Mark", LastName="G.", ID=4,
                          Marks= new List<int>() {97, 89, 85, 82}},
        };
        public List<ContactInfo> contactList = new List<ContactInfo>()
        {
            new ContactInfo {ID=111, Email="Tom@abc.com", Phone="9328298765"},
            new ContactInfo {ID=112, Email="Jerry123@aaa.com", Phone="9876543201"},
            new ContactInfo {ID=113, Email="Bobstar@aaa.com", Phone="9087467653"},
            new ContactInfo {ID=114, Email="Markantony@qqq.com", Phone="9870098761"}
        };

        static void Main(string[] args)
        {
            Program pg = new Program();

            IEnumerable<Student> studentQuery =
                from student in pg.students
                where student.ID > 0
                select student;

            Console.WriteLine("Query : Select range_variable");
            Console.WriteLine("Name : ID");

            foreach(Student s in studentQuery)
            {
                s.PrintInfo();
            }
        }
    }
}
