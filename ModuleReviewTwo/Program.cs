namespace ModuleReviewTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var student1 = new Student()
            {
                Name = "Miah",
                ID = 1
                
            };
            students.Add(student1);
            student1.AddGrade(94.5);
            student1.AddGrade(90.0, 76.8, 95.4);

            var student2 = new Student()
            {
                Name = "Cali",
                ID = 2
            };
            students.Add(student2);
            student2.AddGrade(85.5);
            student2.AddGrade(94.0, 55.6, 78.5);

            var student3 = new Student()
            {
                Name = "Dan",
                ID = 3
            };
            students.Add(student3);
            student3.AddGrade(45.2);
            student3.AddGrade(94.0, 99.9, 23.4);

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
                foreach (double grade in student.Grades)
                {
                    Console.Write($"{grade} ");
                }
                Console.WriteLine();
                double averageGrade = student.CalculateAverageGrade();
                Console.WriteLine($"Average Grade: {averageGrade}\n");
            }


            var course = new Course();

            course.CourseName = "Math";
            course.CourseCode = "CS103";
            course.StudentsEnrolled(student1);
            course.DisplayInfo();

            var course2 = new Course();

            course2.CourseName = "PE";
            course2.CourseCode = "CS102";
            course2.StudentsEnrolled(student2);
            course2.DisplayInfo();
           
            course2.CourseName = "PE";
            course2.CourseCode = "CS102";
            course2.StudentsEnrolled(student1);
            course2.DisplayInfo();


            course2.CourseName = "PE";
            course2.CourseCode = "CS102";
            course2.StudentsEnrolled(student2);
            course2.DisplayInfo();




        }
    }
}
