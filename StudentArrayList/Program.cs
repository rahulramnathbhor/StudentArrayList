using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudCourseListpgm
{
    public class Student
    {
        public string sname { get; set; }
        public string city { get; set; }

    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public ArrayList Students { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList stud1 = new ArrayList();
            {
                stud1.Add(new Student { sname = "Rahul", city = "Pune" });
                stud1.Add(new Student { sname = "Sham", city = "satara" });


                ArrayList stud2 = new ArrayList();
                stud2.Add(new Student { sname = "Radha", city = "Sangli" });
                stud2.Add(new Student { sname = "Gopal", city = "Bihar" });
                stud2.Add(new Student { sname = "Kunal", city = "Uttrakhand" });

                ArrayList stud3 = new ArrayList();
                stud3.Add(new Student { sname = "Ramesh", city = "Madhyapradesh" });
                stud3.Add(new Student { sname = "Sumit", city = "Zarkhand" });
                stud3.Add(new Student { sname = "Kumar", city = "Bhopal" });

                ArrayList courses = new ArrayList();
                {
                    courses.Add(new Course { Id = 1, Name = "C#", Fees = 25000, Students = stud1 });
                    courses.Add(new Course { Id = 2, Name = "Java", Fees = 27000, Students = stud2 });
                    courses.Add(new Course { Id = 3, Name = "MVC", Fees = 40000, Students = stud3 });

                };
                foreach (Course c in courses)
                {
                    Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
                    foreach (Student s in c.Students)
                    {
                        Console.WriteLine($"\t {s.sname} -> {s.city}");
                    }
                }

            }
        }
    }
}






