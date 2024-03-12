using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleReviewTwo
{
    internal class Course
    {
        public string CourseName { get; set; }
        
        public string CourseCode { get;set; }

        public List<Student> EnrolledStudents;

        public Course()
        {
            EnrolledStudents = new List<Student>();
        }

        public void StudentsEnrolled(Student student)
        {
            if (!EnrolledStudents.Contains(student)) //checks if the EnrolledStudents list does not already contain the student being passed to the method.
            {
                EnrolledStudents.Add(student);
                Console.WriteLine($"{student.Name} has been enrolled");
            }
            else
            {
                Console.WriteLine($"{student.Name} has already been enrolled");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Course Code: {CourseCode}");
            Console.WriteLine("Enrolled Students:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"Student ID: {student.ID}, Student name {student.Name}");
                
            }
        }
    }
}
