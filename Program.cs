namespace StudentManagementSystem
{
    using System;
    using System.Collections.Generic;

   

   
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Course> courses = new List<Course>();
        static List<Enrollment> enrollments = new List<Enrollment>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Welcome to Student Management System!");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Enroll Student in Course");
                Console.WriteLine("4. View Enrollments");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddCourse();
                        break;
                    case 3:
                        EnrollStudent();
                        break;
                    case 4:
                        ViewEnrollments();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.WriteLine("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            string studentName = Console.ReadLine();

            Student student = new Student(studentId, studentName);
            students.Add(student);

            Console.WriteLine("Student added successfully!");
        }

        static void AddCourse()
        {
            Console.WriteLine("Enter Course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Name: ");
            string courseName = Console.ReadLine();

            Course course = new Course(courseId, courseName);
            courses.Add(course);

            Console.WriteLine("Course added successfully!");
        }

        static void EnrollStudent()
        {
            Console.WriteLine("Enter Enrollment ID: ");
            int enrollmentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            // Check if student and course exist
            Student student = students.Find(s => s.StudentId == studentId);
            Course course = courses.Find(c => c.CourseId == courseId);
            if (student == null || course == null)
            {
                Console.WriteLine("Student or Course does not exist!");
                //return;
            }
            else
            {

                Enrollment enrollment = new Enrollment(enrollmentId, studentId, courseId);
                enrollments.Add(enrollment);
                Console.WriteLine("Student enrolled in course successfully!");
            }
        }

        static void ViewEnrollments()
        {
            Console.WriteLine("Enrollments:");
            foreach (Enrollment enrollment in enrollments)
            {
                Student student = students.Find(s => s.StudentId == enrollment.StudentId);
                Course course = courses.Find(c => c.CourseId == enrollment.CourseId);

                Console.WriteLine($"Enrollment ID: {enrollment.EnrollmentId}, Student ID: {enrollment.StudentId}, Student Name: {student?.Name}, Course ID: {enrollment.CourseId}, Course Name: {course?.CourseName}");
            }
        }
    }

}