using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunWithLINQ.Data;
using FunWithLINQ.Models;

namespace FunWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousTypes();
            Joins();
            GroupBy();
            Console.ReadLine();
        }


        static void AnonymousTypes()
        {
            Console.WriteLine("<= Anon Types");
            // student repo learn this
            List<Student> students = StudentRepository.GetAllStudents();

            //query syntax
            //var ladies = from student in students
            //    where student.Gender == "F"
            //    select new
            //    {
            //        Name = $"{student.FirstName} {student.LastName}",
            //        student.Major
            //    };

            //method syntax

            var ladies = students.Where(s => s.Gender == "F").Select(x => new {Name = $"{x.FirstName} {x.LastName}", x.Major});

            //have to use the var keyword...the collection has no assigned type
            foreach (var lady in ladies)
            {
                Console.WriteLine($"{lady.Name} is majoing in {lady.Major}");
            }
            Console.WriteLine();
        }

        static void Joins()
        {
            Console.WriteLine("<= Joins");

            List<Student> students = StudentRepository.GetAllStudents();
            List<StudentCourse> courses = StudentRepository.GetAllStudentCourses();

            //var results = from s in students
            //    join c in courses
            //        on s.ID equals c.StudentId
            //    select new
            //    {
            //        c.CourseName,
            //    StudentName = $"{s.FirstName} {s.LastName}"

            //    };


            //Method syntax
            var results = students.Join(courses, student => student.ID, course => course.StudentId,
                (student, course) => new
                {
                    course.CourseName,
                    StudentName = $"{student.FirstName} {student.LastName}"
                });

            foreach (var result in results)
            {
                Console.WriteLine($"{result.StudentName} is taking {result.CourseName}");
            }
        }

        static void GroupBy()
        {
            Console.WriteLine("<= Groub by");

            var students = StudentRepository.GetAllStudents();

            //Query syntax

            var results = (from s in students
                           where s.Major != "Chemistry"
                orderby s.Major descending, s.LastName
                group s by s.Major).Take(2);

            //method syntax
            //var results =
            //    students.Where(student => student.Major != "Chemistry")
            //        .OrderBy(s => s.Major)
            //        .ThenBy(s => s.LastName)
            //        .GroupBy(student => student.Major);

            foreach (var group in results)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.FirstName} {student.LastName} - {student.Major}");
                }
            }



            Console.WriteLine();
        }
    }
}
